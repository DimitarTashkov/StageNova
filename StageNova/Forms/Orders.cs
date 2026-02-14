using StageNova.Models;
using StageNova.Services.Interfaces;
using StageNova.Utilities;
using StageNova.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StageNova.Forms
{
    public partial class Orders : Form
    {
        private readonly ITicketService _ticketService;
        private readonly ISouvenirService _souvenirService;
        private readonly IUserService _userService;
        private User? activeUser;
        public Orders(ITicketService ticketService, ISouvenirService soupService, IUserService userService)
        {
            InitializeComponent();
            _ticketService = ticketService;
            _souvenirService = soupService;
            _userService = userService;
            activeUser = _userService.GetLoggedInUserAsync();
        }
        private void SetupGrids()
        {
            // === 1. Tickets Table ===
            dgvReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservations.ReadOnly = true;
            dgvReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (!dgvReservations.Columns.Contains("Cancel"))
            {
                var btnCancel = new DataGridViewButtonColumn
                {
                    Name = "Cancel",
                    HeaderText = "Actions",
                    Text = "Cancel Ticket",
                    UseColumnTextForButtonValue = true
                };
                dgvReservations.Columns.Add(btnCancel);
            }

            dgvReservations.CellContentClick -= DgvReservations_CellContentClick;
            dgvReservations.CellContentClick += DgvReservations_CellContentClick;


            // === 2. Orders Table ===
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.ReadOnly = true;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (!dgvOrders.Columns.Contains("Delete"))
            {
                var btnDelete = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "Actions",
                    Text = "Delete Order",
                    UseColumnTextForButtonValue = true
                };
                dgvOrders.Columns.Add(btnDelete);
            }
            if (!dgvOrders.Columns.Contains("Invoice"))
            {
                var btnInvoice = new DataGridViewButtonColumn
                {
                    Name = "Invoice",
                    HeaderText = "Document",
                    Text = "View Invoice",
                    UseColumnTextForButtonValue = true
                };
                dgvOrders.Columns.Add(btnInvoice);
            }

            dgvOrders.CellContentClick -= DgvOrders_CellContentClick;
            dgvOrders.CellContentClick += DgvOrders_CellContentClick;
        }

        private void LoadData()
        {
            if (activeUser == null) return;

            bool isAdmin = AuthorizationHelper.IsAuthorized();

            // --- LOAD TICKETS ---
            var tickets = isAdmin
                ? _ticketService.GetAllTickets()
                : _ticketService.GetTicketsByUser(activeUser.Id);

            dgvReservations.DataSource = tickets.Select(t => new
            {
                Id = t.Id,
                Play = t.Performance?.Play?.Title ?? "N/A",
                Date = t.Performance?.Date,
                Seats = t.TicketsCount,
                Total = $"{t.TotalPrice:F2} BGN",
                User = isAdmin ? (t.User?.Username ?? "N/A") : "Me"
            }).ToList();

            if (dgvReservations.Columns["Id"] != null) dgvReservations.Columns["Id"].Visible = false;


            // --- LOAD ORDERS ---
            var orders = isAdmin
                ? _souvenirService.GetAllOrders()
                : _souvenirService.GetOrdersByUserId(activeUser.Id);

            dgvOrders.DataSource = orders.Select(o => new
            {
                Id = o.Id,
                OrderDate = o.OrderDate,
                Total = $"{o.TotalAmount:F2} BGN",
                ItemsCount = o.OrderItems.Count,
                Details = string.Join(", ", o.OrderItems.Select(i => $"{i.Souvenir?.Name} (x{i.Quantity})")),
                User = isAdmin ? o.User.Username : "Me"
            }).ToList();

            if (dgvOrders.Columns["Id"] != null) dgvOrders.Columns["Id"].Visible = false;
        }

        // === CANCEL TICKET ===
        private void DgvReservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvReservations.Columns[e.ColumnIndex].Name == "Cancel")
            {
                if (MessageBox.Show("Are you sure you want to cancel this ticket?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        Guid id = (Guid)dgvReservations.Rows[e.RowIndex].Cells["Id"].Value;
                        _ticketService.DeleteTicket(id);
                        LoadData();
                        MessageBox.Show("Ticket cancelled.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        // === DELETE ORDER ===
        private void DgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvOrders.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this order record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        Guid id = (Guid)dgvOrders.Rows[e.RowIndex].Cells["Id"].Value;
                        _souvenirService.DeleteOrder(id);
                        LoadData();
                        MessageBox.Show("Order deleted.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            if (e.RowIndex >= 0 && dgvOrders.Columns[e.ColumnIndex].Name == "Invoice")
            {
                Guid orderId = (Guid)dgvOrders.Rows[e.RowIndex].Cells["Id"].Value;
                var order = _souvenirService.GetAllOrders().FirstOrDefault(o => o.Id == orderId);

                if (order != null)
                {
                    string invoiceText = InvoiceHelper.GenerateOrderInvoice(order);
                    MessageBox.Show(invoiceText, "Order Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            SetupGrids();
            LoadData();

            bool isAdmin = AuthorizationHelper.IsAuthorized();
            Users.Visible = isAdmin;
            Management.Visible = isAdmin;
            roundPictureBox1.ImageLocation = activeUser?.AvatarUrl;
        }

        private void menu_ItemClicked(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item == null) return;

            string formName = item.Name;
            var userService = ServiceLocator.GetService<IUserService>();
            Form form = new Index(userService);

            switch (formName)
            {
                case "Store":
                    form = new Shop(ServiceLocator.GetService<ISouvenirService>());
                    break;
                case "Vehicles":
                    form = new Plays();
                    break;
                case "MyReservations":
                    form = new Orders(ServiceLocator.GetService<ITicketService>(), ServiceLocator.GetService<ISouvenirService>(), userService);
                    break;
                case "Users":
                    form = new Users(userService);
                    break;
                case "manageProducts":
                    form = new ManageSouvenirs(ServiceLocator.GetService<ISouvenirService>());
                    break;
                case "manageVehicles":
                    form = new ManagePlays(ServiceLocator.GetService<IPlayService>());
                    break;
                case "Home":
                    form = new Index(userService);
                    break;
            }

            Program.SwitchMainForm(form);
        }

        private void roundPictureBox1_Click(object sender, EventArgs e)
        {
            var userService = ServiceLocator.GetService<IUserService>();
            var activeUser = userService.GetLoggedInUserAsync();
            if (activeUser != null)
            {
                Profile profileForm = new Profile(userService, activeUser.Id);
                Program.SwitchMainForm(profileForm);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Index homeForm = new Index(_userService);
            Program.SwitchMainForm(homeForm);
        }
    }
}
