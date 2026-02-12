using StageNova.Extensions;
using StageNova.Models;
using StageNova.Services.Interfaces;
using StageNova.Utilities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StageNova.Forms
{
    public partial class Index : Form
    {
        private readonly IUserService userService;
        private readonly ISouvenirService shopService;
        private readonly ITicketService ticketService;
        private readonly IPlayService playService;

        private User activeUser;

        public Index(IUserService userService)
        {
            this.userService = userService;
            this.shopService = ServiceLocator.GetService<ISouvenirService>();
            this.ticketService = ServiceLocator.GetService<ITicketService>();
            this.playService = ServiceLocator.GetService<IPlayService>();
            activeUser = userService.GetLoggedInUserAsync();

            InitializeComponent();
            ApplyCustomStyles();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            roundPictureBox1.ImageLocation = activeUser.AvatarUrl;

            bool isAdmin = AuthorizationHelper.IsAuthorized();
            Users.Visible = isAdmin;
            Management.Visible = isAdmin;

            MenuHelper.ApplyMenuLabels(Home, Vehicles, Store, MyReservations, Users, Management, manageProducts, manageVehicles);

            ApplyCustomStyles();
        }

        private void roundPictureBox1_Click(object sender, EventArgs e)
        {
            Profile profileForm = new Profile(userService, activeUser.Id);
            Program.SwitchMainForm(profileForm);
        }

        private void store_button_Click(object sender, EventArgs e)
        {
            Shop shopForm = new Shop(shopService);
            Program.SwitchMainForm(shopForm);
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

        private void ApplyCustomStyles()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.FromArgb(120, 27, 51);
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Cursor = Cursors.Hand;
                    btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(155, 40, 70);
                    btn.MouseLeave += (s, e) => btn.BackColor = Color.FromArgb(120, 27, 51);
                }
                else if (ctrl is Label lbl)
                {
                    lbl.BackColor = Color.Transparent;
                    lbl.ForeColor = Color.White;
                    lbl.Cursor = Cursors.Hand;
                    lbl.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                }
            }
        }

        private void aboutUs_Click(object sender, EventArgs e)
        {
            AboutUs aboutUsForm = new AboutUs();
            Program.SwitchMainForm(aboutUsForm);
        }

        private void contactUs_Click(object sender, EventArgs e)
        {
            ContactUs contactUsForm = new ContactUs();
            Program.SwitchMainForm(contactUsForm);
        }

        private void exhibitionsButton_Click(object sender, EventArgs e)
        {
            Plays plays = new Plays();
            Program.SwitchMainForm(plays);
        }
    }
}