using StageNova.Extensions;
using StageNova.Models;
using StageNova.Services.Interfaces;
using StageNova.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StageNova.Forms
{
    public partial class BookTicket : Form
    {
        private readonly ITicketService _ticketService;
        private readonly Play _selectedPlay;
        private readonly IPlayService playService;
        private readonly IUserService userService = ServiceLocator.GetService<IUserService>();
        private User? currrentUser;
        private List<Performance> _performances;

        public BookTicket(ITicketService ticketService, Play play)
        {
            InitializeComponent();
            _ticketService = ticketService;
            _selectedPlay = play;
            playService = ServiceLocator.GetService<IPlayService>();
            currrentUser = userService.GetLoggedInUserAsync();
        }

        private void BookTicket_Load(object sender, EventArgs e)
        {
            // Load poster image from byte array
            if (_selectedPlay.PosterImage != null && _selectedPlay.PosterImage.Length > 0)
            {
                try
                {
                    using (var ms = new MemoryStream(_selectedPlay.PosterImage))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                catch { }
            }

            roundPictureBox1.ImageLocation = currrentUser?.AvatarUrl;

            bool isAdmin = AuthorizationHelper.IsAuthorized();
            Users.Visible = isAdmin;
            Management.Visible = isAdmin;

            // Display play info
            lblPlayInfo.Text = $"🎭 {_selectedPlay.Title}\n" +
                               $"Director: {_selectedPlay.Director}\n" +
                               $"Genre: {_selectedPlay.Genre} | {_selectedPlay.DurationMinutes} min\n" +
                               $"Price per ticket: {_selectedPlay.TicketPrice:F2} BGN";

            // Load performances into ComboBox
            LoadPerformances();
            UpdateTotalPrice();
        }

        private void LoadPerformances()
        {
            _performances = _ticketService.GetPerformancesByPlayId(_selectedPlay.Id);

            cmbPerformance.Items.Clear();

            if (_performances == null || _performances.Count == 0)
            {
                cmbPerformance.Items.Add("No performances available");
                cmbPerformance.SelectedIndex = 0;
                cmbPerformance.Enabled = false;
                btnBook.Enabled = false;
                return;
            }

            foreach (var perf in _performances)
            {
                string displayText = $"{perf.Date:dd MMM yyyy, HH:mm} — {perf.AvailableSeats}/{perf.TotalSeats} seats available";
                cmbPerformance.Items.Add(displayText);
            }

            cmbPerformance.SelectedIndex = 0;
            UpdateMaxTickets();
        }

        private void cmbPerformance_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMaxTickets();
            UpdateTotalPrice();
        }

        private void nudTicketCount_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void UpdateMaxTickets()
        {
            if (_performances == null || _performances.Count == 0) return;

            int selectedIndex = cmbPerformance.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= _performances.Count) return;

            var perf = _performances[selectedIndex];
            nudTicketCount.Maximum = Math.Max(1, Math.Min(perf.AvailableSeats, 20));
            nudTicketCount.Value = 1;
        }

        private void UpdateTotalPrice()
        {
            decimal total = _selectedPlay.TicketPrice * nudTicketCount.Value;
            lblTotalPrice.Text = $"Total: {total:F2} BGN";
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (_performances == null || _performances.Count == 0)
            {
                MessageBox.Show("No performances available for booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedIndex = cmbPerformance.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= _performances.Count)
            {
                MessageBox.Show("Please select a performance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedPerformance = _performances[selectedIndex];
            int count = (int)nudTicketCount.Value;

            if (selectedPerformance.AvailableSeats < count)
            {
                MessageBox.Show($"Only {selectedPerformance.AvailableSeats} seats available.", "Not Enough Seats", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _ticketService.BookTicket(currrentUser.Id, selectedPerformance.Id, count);

                decimal total = _selectedPlay.TicketPrice * count;
                MessageBox.Show(
                    $"Booking Confirmed!\n\n" +
                    $"Play: {_selectedPlay.Title}\n" +
                    $"Date: {selectedPerformance.Date:dd MMM yyyy, HH:mm}\n" +
                    $"Tickets: {count}\n" +
                    $"Total: {total:F2} BGN",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var ticketService = ServiceLocator.GetService<ITicketService>();
                var userService = ServiceLocator.GetService<IUserService>();
                var souvenirService = ServiceLocator.GetService<ISouvenirService>();

                Program.SwitchMainForm(new Orders(ticketService, souvenirService, userService));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Booking failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.SwitchMainForm(new Plays());
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
