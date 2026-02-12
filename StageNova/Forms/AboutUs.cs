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
    public partial class AboutUs : Form
    {
        private readonly IUserService userService;
        
        private User activeUser;
        public AboutUs()
        {
            this.userService = ServiceLocator.GetService<IUserService>();
            activeUser = userService.GetLoggedInUserAsync();
            InitializeComponent();
        }
        private void LoadPortfolioContent()
        {
            lblTitle.Text = "StageNova Theater";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            string text = "Welcome to StageNova!\n\n" +
              "We are a theater dedicated to the art of live performance. " +
              "Our mission is to bring stories to life on stage.\n\n" +
              "Here you can explore our repertoire of plays, " +
              "learn about upcoming performances, and book your tickets.\n\n" +
              "Thank you for being part of our journey!";

            if (lblDescription != null)
                lblDescription.Text = text;

            if (lblStats != null)
            {
                lblStats.Text = "⭐ 3+ Years Experience   |   🎭 50+ Plays   |   ❤️ 200+ Happy Viewers";
                lblStats.ForeColor = Color.DarkSlateGray;
                lblStats.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void AboutUs_Load(object sender, EventArgs e)
        {
            if (activeUser != null && roundPictureBox1 != null)
                 roundPictureBox1.ImageLocation = activeUser.AvatarUrl;
            
            bool isAdmin = AuthorizationHelper.IsAuthorized();

            Users.Visible = isAdmin;
            Management.Visible = isAdmin;

            MenuHelper.ApplyMenuLabels(Home, Vehicles, Store, MyReservations, Users, Management, manageProducts, manageVehicles);
            
            LoadPortfolioContent();
        }
        
        private void roundPictureBox1_Click(object sender, EventArgs e)
        {
            Profile profileForm = new Profile(userService, activeUser.Id);
            Program.SwitchMainForm(profileForm);
        }

        private void menu_ItemClicked(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item == null) return;

            string formName = item.Name;
            
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
    }
}
