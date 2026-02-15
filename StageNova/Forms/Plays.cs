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
    public partial class Plays : Form
    {
        private readonly IPlayService _service;
        private readonly IUserService _userService;
        private readonly ITicketService _ticketService;
        private User activeUser;

        public Plays()
        {
            InitializeComponent();
            _userService = ServiceLocator.GetService<IUserService>();
            _ticketService = ServiceLocator.GetService<ITicketService>();
            _service = ServiceLocator.GetService<IPlayService>();
            activeUser = _userService.GetLoggedInUserAsync();
        }
        private void Plays_Load(object sender, EventArgs e)
        {
            roundPictureBox1.ImageLocation = activeUser?.AvatarUrl;
            bool isAdmin = AuthorizationHelper.IsAuthorized();
            Users.Visible = isAdmin;
            Management.Visible = isAdmin;

            LoadPlays();
        }

        private void LoadPlays()
        {
            flowPanel.Controls.Clear();
            var plays = _service.GetAllPlays().Where(p => p.IsActive).ToList();

            foreach (var item in plays)
            {
                Panel card = new Panel
                {
                    Size = new Size(250, 320),
                    BorderStyle = BorderStyle.None,
                    BackColor = Color.White,
                    Margin = new Padding(15)
                };

                RoundPictureBox pb = new RoundPictureBox
                {
                    Size = new Size(210, 160),
                    Location = new Point(20, 10),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BackColor = Color.LightGray
                };

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

                Label lblTitle = new Label
                {
                    Text = item.Title,
                    Location = new Point(20, 180),
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    ForeColor = Color.DarkSlateBlue
                };
                card.Controls.Add(lblTitle);

                Label lblInfo = new Label
                {
                    Text = $"{item.Genre} | {item.DurationMinutes} min | {item.TicketPrice:F2} BGN",
                    Location = new Point(20, 210),
                    AutoSize = true,
                    ForeColor = Color.Gray
                };
                card.Controls.Add(lblInfo);

                Button btnBook = new Button
                {
                    Text = "Book Ticket",
                    Location = new Point(25, 260),
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

            Program.SwitchMainForm(new BookTicket(_ticketService, play));
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
                    form = new ManageMerchandise(ServiceLocator.GetService<ISouvenirService>());
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
            if (activeUser != null)
            {
                Profile profileForm = new Profile(_userService, activeUser.Id);
                Program.SwitchMainForm(profileForm);
            }
        }
    }
}
