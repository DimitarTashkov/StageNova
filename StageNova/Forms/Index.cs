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
        }

        private void Index_Load(object sender, EventArgs e)
        {
            roundPictureBox1.ImageLocation = activeUser.AvatarUrl;

            bool isAdmin = AuthorizationHelper.IsAuthorized();
            Users.Visible = isAdmin;
            Management.Visible = isAdmin;
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