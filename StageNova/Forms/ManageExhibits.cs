using StageNova.Extensions;
using StageNova.Models;
using StageNova.Services.Interfaces;
using StageNova.Utilities;
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
    public partial class ManagePlays : Form
    {
        private readonly IPlayService _service;
        private readonly IUserService _userService;
        private User? activeUser;
        public ManagePlays(IPlayService service)
        {
            InitializeComponent();
            this._service = service;
            this._userService = ServiceLocator.GetService<IUserService>();
            activeUser = _userService.GetLoggedInUserAsync();
        }

        private void ManagePlays_Load(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.FromArgb(120, 27, 51);
            btnAdd.ForeColor = Color.White;
            SetupGrid();
            LoadData();

            bool isAdmin = AuthorizationHelper.IsAuthorized();
            Users.Visible = isAdmin;
            Management.Visible = isAdmin;
            roundPictureBox1.ImageLocation = activeUser?.AvatarUrl;

            MenuHelper.ApplyMenuLabels(Home, Vehicles, Store, MyReservations, Users, Management, manageProducts, manageVehicles);
        }
        private void SetupGrid()
        {
            dgvExhibits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExhibits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (!dgvExhibits.Columns.Contains("Edit"))
            {
                var editBtn = new DataGridViewButtonColumn { Name = "Edit", Text = "Edit", UseColumnTextForButtonValue = true };
                dgvExhibits.Columns.Add(editBtn);
            }
            if (!dgvExhibits.Columns.Contains("Delete"))
            {
                var delBtn = new DataGridViewButtonColumn { Name = "Delete", Text = "Delete", UseColumnTextForButtonValue = true };
                dgvExhibits.Columns.Add(delBtn);
            }

            dgvExhibits.CellContentClick -= DgvExhibits_CellContentClick;
            dgvExhibits.CellContentClick += DgvExhibits_CellContentClick;
        }

        private void LoadData()
        {
            dgvExhibits.DataSource = null;
            dgvExhibits.DataSource = _service.GetAllPlays();
            if (dgvExhibits.Columns["Id"] != null) dgvExhibits.Columns["Id"].Visible = false;
            if (dgvExhibits.Columns["PosterImage"] != null) dgvExhibits.Columns["PosterImage"].Visible = false;
            if (dgvExhibits.Columns["Performances"] != null) dgvExhibits.Columns["Performances"].Visible = false;
        }

        private void DgvExhibits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var play = (Play)dgvExhibits.Rows[e.RowIndex].DataBoundItem;

            if (dgvExhibits.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Delete?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _service.DeletePlay(play.Id);
                    LoadData();
                }
            }
            else if (dgvExhibits.Columns[e.ColumnIndex].Name == "Edit")
            {
                Program.SwitchMainForm(new AddEditPlay(_service, play));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Program.SwitchMainForm(new AddEditPlay(_service, null));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.SwitchMainForm(new Index(_userService));
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
    }
}
