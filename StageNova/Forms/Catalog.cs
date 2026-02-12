using StageNova.Extensions;
using StageNova.Models;
using StageNova.Services.Interfaces;
using StageNova.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StageNova.Forms
{
    public partial class Catalog : Form
    {
        private readonly IPlayService _service;
        private readonly IUserService _userService;
        private readonly ITicketService _ticketService;
        private User activeUser;

        public Catalog()
        {
            InitializeComponent();
            _userService = ServiceLocator.GetService<IUserService>();
            _ticketService = ServiceLocator.GetService<ITicketService>();
            _service = ServiceLocator.GetService<IPlayService>();
            activeUser = _userService.GetLoggedInUserAsync();
        }
        private void CatalogForm_Load(object sender, EventArgs e)
        {
            roundPictureBox1.ImageLocation = activeUser?.AvatarUrl;
            bool isAdmin = AuthorizationHelper.IsAuthorized();
            Users.Visible = isAdmin;
            Management.Visible = isAdmin;

            MenuHelper.ApplyMenuLabels(Home, Vehicles, Store, MyReservations, Users, Management, manageProducts, manageVehicles);

            LoadCatalog();
        }

        private void LoadCatalog()
        {
            flowPanel.Controls.Clear();
            var plays = _service.GetAllPlays();

            foreach (var item in plays)
            {
                // --- 1. CARD (Panel) ---
                Panel card = new Panel
                {
                    Size = new Size(230, 320),
                    BorderStyle = BorderStyle.None,
                    BackColor = Color.White,
                    Margin = new Padding(15)
                };

                // --- 2. IMAGE (RoundPictureBox) ---
                RoundPictureBox pb = new RoundPictureBox
                {
                    Size = new Size(210, 160),
                    Location = new Point(10, 10),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BackColor = Color.LightGray
                };

                // Load poster image from byte array
                try
                {
                    if (item.PosterImage != null && item.PosterImage.Length > 0)
                    {
                        using (var ms = new MemoryStream(item.PosterImage))
                        {
                            pb.Image = Image.FromStream(ms);
                        }
                    }
                }
                catch { }

                card.Controls.Add(pb);

                // --- 3. TITLE ---
                Label lblTitle = new Label
                {
                    Text = item.Title,
                    Location = new Point(10, 180),
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    ForeColor = Color.DarkSlateBlue
                };
                card.Controls.Add(lblTitle);

                // --- 4. GENRE & DURATION ---
                Label lblInfo = new Label
                {
                    Text = $"{item.Genre} | {item.DurationMinutes} min | {item.TicketPrice:F2} BGN",
                    Location = new Point(10, 210),
                    AutoSize = true,
                    ForeColor = Color.Gray
                };
                card.Controls.Add(lblInfo);

                // --- 5. BOOK TICKET BUTTON ---
                Button btnBook = new Button
                {
                    Text = "Book Ticket",
                    Location = new Point(20, 260),
                    Size = new Size(200, 40),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.Black,
                    ForeColor = Color.White,
                    Cursor = Cursors.Hand,
                    Tag = item
                };
                btnBook.Click += BtnBook_Click;
                card.Controls.Add(btnBook);

                flowPanel.Controls.Add(card);
            }
        }

        private void BtnBook_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var play = (Play)btn.Tag;

            Program.SwitchMainForm(new BookVisit(_ticketService, play));
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
                Profile profileForm = new Profile(_userService, activeUser.Id);
                Program.SwitchMainForm(profileForm);
            }
        }
    }
}
