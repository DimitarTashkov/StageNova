using StageNova.Extensions;
using StageNova.Models;
using StageNova.Services.Interfaces;
using StageNova.Utilities;
using System;
using System.Windows.Forms;

namespace StageNova.Forms
{
    public partial class Checkout : Form
    {
        private readonly ISouvenirService _service;
        private readonly Souvenir _item;
        private readonly User _user;
        private readonly IUserService userService;
        private User activeUser;

        public Checkout(ISouvenirService service, Souvenir item, User user)
        {
            InitializeComponent();
            _service = service;
            _item = item;
            _user = user;
            this.userService = ServiceLocator.GetService<IUserService>();
            activeUser = userService.GetLoggedInUserAsync();
            SetupUI();
        }

        private void SetupUI()
        {
            this.Text = "Checkout";
            this.StartPosition = FormStartPosition.CenterScreen;

            itemsBox.Items.Add(itemsBox.Items.Count + 1 + $". {_item.Name} - {_item.Price:F2} BGN");
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please enter both Delivery Address and Phone Number.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _service.PurchaseItem(_user.Id, _item.Id, 1, txtAddress.Text, txtPhone.Text);
                MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Order Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Checkout_Load(object sender, EventArgs e)
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
    }
}
