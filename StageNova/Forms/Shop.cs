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
    public partial class Shop : Form
    {
        private readonly ISouvenirService _service;
        private readonly IUserService userService;
        private User activeUser;

        public Shop(ISouvenirService service)
        {
            InitializeComponent();
            this._service = service;
            userService = ServiceLocator.GetService<IUserService>();
            activeUser = userService.GetLoggedInUserAsync();
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            if (activeUser != null && roundPictureBox1 != null)
                roundPictureBox1.ImageLocation = activeUser.AvatarUrl;

            bool isAdmin = AuthorizationHelper.IsAuthorized();

            Users.Visible = isAdmin;
            Management.Visible = isAdmin;

            MenuHelper.ApplyMenuLabels(Home, Vehicles, Store, MyReservations, Users, Management, manageProducts, manageVehicles);

            LoadShop();
        }
        private void LoadShop()
        {
            if (flowLayoutPanel1 == null) return;
            flowLayoutPanel1.Controls.Clear();

            var items = _service.GetAllSouvenirs();

            foreach (var item in items)
            {
                if (item.StockQuantity <= 0) continue;

                Panel card = new Panel
                {
                    Size = new Size(200, 260),
                    BackColor = Color.WhiteSmoke,
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle
                };

                Label lblName = new Label
                {
                    Text = item.Name,
                    Location = new Point(10, 10),
                    Width = 180,
                    Font = new Font("Arial", 10, FontStyle.Bold)
                };

                Label lblPrice = new Label
                {
                    Text = $"{item.Price:F2} BGN",
                    Location = new Point(10, 40),
                    AutoSize = true,
                    ForeColor = Color.Green,
                    Font = new Font("Arial", 12, FontStyle.Bold)
                };

                Label lblQuantity = new Label
                {
                    Text = $"Available: {item.StockQuantity}",
                    Location = new Point(120, 45),
                    AutoSize = true,
                    ForeColor = Color.DimGray,
                    Font = new Font("Arial", 9, FontStyle.Regular)
                };

                PictureBox pbImage = new PictureBox
                {
                    ImageLocation = item.ImagePath,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Location = new Point(10, 70),
                    Size = new Size(178, 120)
                };

                Button btnBuy = new Button
                {
                    Text = "Buy Now",
                    Location = new Point(10, 200),
                    Size = new Size(178, 40),
                    BackColor = Color.Orange,
                    FlatStyle = FlatStyle.Flat,
                    Tag = item
                };
                btnBuy.Click += BtnBuy_Click;

                card.Controls.Add(lblName);
                card.Controls.Add(lblPrice);
                card.Controls.Add(lblQuantity);
                card.Controls.Add(pbImage);
                card.Controls.Add(btnBuy);

                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void BtnBuy_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var item = (Souvenir)btn.Tag;

            using (var checkout = new Checkout(_service, item, activeUser))
            {
                if (checkout.ShowDialog() == DialogResult.OK)
                {
                    LoadShop();
                }
            }
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
                    form = new Catalog();
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
                    form = new ManageExhibits(ServiceLocator.GetService<IPlayService>());
                    break;
                case "Home":
                    form = new Index(userService);
                    break;
            }

            Program.SwitchMainForm(form);
        }

        private void roundPictureBox1_Click(object sender, EventArgs e)
        {
            if (activeUser != null)
            {
                Profile profileForm = new Profile(userService, activeUser.Id);
                Program.SwitchMainForm(profileForm);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Index indexForm = new Index(userService);
            Program.SwitchMainForm(indexForm);
        }
    }
}
