using StageNova.Models;
using StageNova.Services.Interfaces;
using StageNova.Utilities;
using StageNova.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StageNova.Forms
{
    public partial class AddEditPlay : Form
    {
        private readonly IPlayService _service;
        private Play _play;
        private byte[] _selectedImageBytes = null;
        private readonly IUserService userService;
        private User activeUser;

        public AddEditPlay(IPlayService playService, Play? play)
        {
            InitializeComponent();
            _service = playService;
            _play = play;
            userService = ServiceLocator.GetService<IUserService>();
            activeUser = userService.GetLoggedInUserAsync();
        }

        private void AddEditPlay_Load(object sender, EventArgs e)
        {
            SetupUI();
            bool isAdmin = AuthorizationHelper.IsAuthorized();
            Users.Visible = isAdmin;
            Management.Visible = isAdmin;
            roundPictureBox1.ImageLocation = activeUser?.AvatarUrl;

            MenuHelper.ApplyMenuLabels(Home, Vehicles, Store, MyReservations, Users, Management, manageProducts, manageVehicles);

            SetupPerformanceGrid();
        }

        private void SetupUI()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            dtpPerformanceDate.MinDate = DateTime.Now;

            if (_play != null)
            {
                this.Text = "Edit Play";
                FillForm();
                LoadPerformances();
            }
            else
            {
                this.Text = "Add New Play";
                _play = new Play();
                grpPerformances.Enabled = false;
                grpPerformances.Text = "Show Dates (save play first)";
            }
        }

        private void FillForm()
        {
            txtMake.Text = _play.Title;
            txtModel.Text = _play.Director;
            txtDescription.Text = _play.Description;
            txtPrice.Text = _play.TicketPrice.ToString("F2");

            if (!string.IsNullOrEmpty(_play.Genre))
                cmbType.SelectedItem = _play.Genre;

            if (_play.DurationMinutes > 0)
                numYear.Value = Math.Max(numYear.Minimum, Math.Min(numYear.Maximum, _play.DurationMinutes));

            if (_play.PosterImage != null && _play.PosterImage.Length > 0)
            {
                try
                {
                    using (var ms = new MemoryStream(_play.PosterImage))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                    _selectedImageBytes = _play.PosterImage;
                }
                catch { }
            }
        }

        private void SetupPerformanceGrid()
        {
            dgvPerformances.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPerformances.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPerformances.ReadOnly = true;

            if (!dgvPerformances.Columns.Contains("DeletePerf"))
            {
                var delBtn = new DataGridViewButtonColumn
                {
                    Name = "DeletePerf",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true,
                    HeaderText = ""
                };
                dgvPerformances.Columns.Add(delBtn);
            }

            dgvPerformances.CellContentClick -= DgvPerformances_CellContentClick;
            dgvPerformances.CellContentClick += DgvPerformances_CellContentClick;
        }

        private void LoadPerformances()
        {
            if (_play == null || _play.Id == Guid.Empty) return;

            var performances = _service.GetPerformancesByPlayId(_play.Id);
            dgvPerformances.DataSource = performances.Select(p => new
            {
                Id = p.Id,
                Date = p.Date.ToString("dd MMM yyyy HH:mm"),
                TotalSeats = p.TotalSeats,
                Available = p.AvailableSeats
            }).ToList();

            if (dgvPerformances.Columns["Id"] != null)
                dgvPerformances.Columns["Id"].Visible = false;
        }

        private void btnAddPerformance_Click(object sender, EventArgs e)
        {
            if (_play == null || _play.Id == Guid.Empty)
            {
                MessageBox.Show("Please save the play first before adding performances.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int totalSeats = (int)nudTotalSeats.Value;
            var performance = new Performance
            {
                Id = Guid.NewGuid(),
                PlayId = _play.Id,
                Date = dtpPerformanceDate.Value,
                TotalSeats = totalSeats,
                AvailableSeats = totalSeats
            };

            try
            {
                _service.AddPerformance(performance);
                LoadPerformances();
                MessageBox.Show("Performance added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvPerformances_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvPerformances.Columns[e.ColumnIndex].Name == "DeletePerf")
            {
                if (MessageBox.Show("Delete this performance?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Guid perfId = (Guid)dgvPerformances.Rows[e.RowIndex].Cells["Id"].Value;
                    _service.DeletePerformance(perfId);
                    LoadPerformances();
                }
            }
        }

        private void PbImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Title = "Select Play Poster";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    _selectedImageBytes = File.ReadAllBytes(ofd.FileName);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMake.Text) || string.IsNullOrWhiteSpace(txtModel.Text))
            {
                MessageBox.Show("Title and Director are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbType.SelectedItem == null)
            {
                MessageBox.Show("Please select a Genre!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal ticketPrice) || ticketPrice < 0)
            {
                MessageBox.Show("Please enter a valid ticket price!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isNew = _play.Id == Guid.Empty;

            _play.Title = txtMake.Text.Trim();
            _play.Director = txtModel.Text.Trim();
            _play.Genre = cmbType.SelectedItem.ToString();
            _play.DurationMinutes = (int)numYear.Value;
            _play.TicketPrice = ticketPrice;
            _play.Description = txtDescription.Text.Trim();
            _play.PosterImage = _selectedImageBytes;
            _play.IsActive = true;

            try
            {
                if (isNew)
                {
                    _service.AddPlay(_play);
                    MessageBox.Show("Play created! You can now add show dates.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grpPerformances.Enabled = true;
                    grpPerformances.Text = "Show Dates (Performances)";
                    LoadPerformances();
                }
                else
                {
                    _service.UpdatePlay(_play);
                    MessageBox.Show("Play updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.SwitchMainForm(new ManagePlays(_service));
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
