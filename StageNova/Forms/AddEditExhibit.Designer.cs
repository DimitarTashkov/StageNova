namespace StageNova.Forms
{
    partial class AddEditExhibit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditExhibit));
            btnBack = new Button();
            btnSave = new Button();
            pictureBox1 = new PictureBox();
            pbImage = new Button();
            txtDescription = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtMake = new TextBox();
            label1 = new Label();
            txtModel = new TextBox();
            cmbType = new ComboBox();
            numYear = new NumericUpDown();
            label2 = new Label();
            label6 = new Label();
            lblPrice = new Label();
            txtPrice = new TextBox();
            grpPerformances = new GroupBox();
            dgvPerformances = new DataGridView();
            btnAddPerformance = new Button();
            dtpPerformanceDate = new DateTimePicker();
            nudTotalSeats = new NumericUpDown();
            lblPerfDate = new Label();
            lblPerfSeats = new Label();
            roundPictureBox1 = new StageNova.Utilities.RoundPictureBox();
            menu = new MenuStrip();
            Home = new ToolStripMenuItem();
            Vehicles = new ToolStripMenuItem();
            Store = new ToolStripMenuItem();
            MyReservations = new ToolStripMenuItem();
            Users = new ToolStripMenuItem();
            Management = new ToolStripMenuItem();
            manageProducts = new ToolStripMenuItem();
            manageVehicles = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTotalSeats).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPerformances).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).BeginInit();
            grpPerformances.SuspendLayout();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(355, 49);
            label6.Name = "label6";
            label6.Size = new Size(265, 38);
            label6.TabIndex = 46;
            label6.Text = "Add or Edit Play";
            // 
            // label1 - Title
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 100);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 28;
            label1.Text = "Title:";
            // 
            // txtMake - Title input
            // 
            txtMake.Location = new Point(50, 128);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(200, 27);
            txtMake.TabIndex = 29;
            // 
            // label3 - Director
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(50, 165);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 30;
            label3.Text = "Director:";
            // 
            // txtModel - Director input
            // 
            txtModel.Location = new Point(50, 193);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(200, 27);
            txtModel.TabIndex = 42;
            // 
            // label4 - Genre
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(50, 230);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 32;
            label4.Text = "Genre:";
            // 
            // cmbType - Genre dropdown
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Drama", "Comedy", "Tragedy", "Musical", "Opera", "Ballet", "Thriller", "Historical", "Experimental", "Children" });
            cmbType.Location = new Point(50, 258);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(200, 28);
            cmbType.TabIndex = 43;
            // 
            // label2 - Duration
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(50, 296);
            label2.Name = "label2";
            label2.Size = new Size(146, 25);
            label2.TabIndex = 45;
            label2.Text = "Duration (min):";
            // 
            // numYear - Duration input
            // 
            numYear.Location = new Point(50, 324);
            numYear.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
            numYear.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numYear.Name = "numYear";
            numYear.Size = new Size(120, 27);
            numYear.TabIndex = 44;
            numYear.Value = new decimal(new int[] { 90, 0, 0, 0 });
            // 
            // lblPrice - Ticket Price
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.Transparent;
            lblPrice.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.White;
            lblPrice.Location = new Point(50, 362);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(141, 25);
            lblPrice.TabIndex = 60;
            lblPrice.Text = "Ticket Price (BGN):";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(50, 390);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(120, 27);
            txtPrice.TabIndex = 61;
            txtPrice.Text = "0.00";
            // 
            // label5 - Description
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(50, 428);
            label5.Name = "label5";
            label5.Size = new Size(107, 25);
            label5.TabIndex = 34;
            label5.Text = "Description:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(50, 456);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(300, 70);
            txtDescription.TabIndex = 35;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(300, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // pbImage
            // 
            pbImage.BackColor = SystemColors.ActiveBorder;
            pbImage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            pbImage.ImeMode = ImeMode.NoControl;
            pbImage.Location = new Point(300, 268);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(160, 30);
            pbImage.TabIndex = 36;
            pbImage.Text = "Upload Poster";
            pbImage.UseVisualStyleBackColor = false;
            pbImage.Click += PbImage_Click;
            // 
            // grpPerformances
            // 
            grpPerformances.BackColor = Color.FromArgb(40, 40, 60);
            grpPerformances.Controls.Add(dgvPerformances);
            grpPerformances.Controls.Add(lblPerfDate);
            grpPerformances.Controls.Add(dtpPerformanceDate);
            grpPerformances.Controls.Add(lblPerfSeats);
            grpPerformances.Controls.Add(nudTotalSeats);
            grpPerformances.Controls.Add(btnAddPerformance);
            grpPerformances.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            grpPerformances.ForeColor = Color.White;
            grpPerformances.Location = new Point(500, 88);
            grpPerformances.Name = "grpPerformances";
            grpPerformances.Size = new Size(460, 440);
            grpPerformances.TabIndex = 62;
            grpPerformances.TabStop = false;
            grpPerformances.Text = "Show Dates (Performances)";
            // 
            // lblPerfDate
            // 
            lblPerfDate.AutoSize = true;
            lblPerfDate.Font = new Font("Segoe UI", 10F);
            lblPerfDate.Location = new Point(10, 35);
            lblPerfDate.Name = "lblPerfDate";
            lblPerfDate.Size = new Size(46, 23);
            lblPerfDate.Text = "Date:";
            // 
            // dtpPerformanceDate
            // 
            dtpPerformanceDate.Format = DateTimePickerFormat.Custom;
            dtpPerformanceDate.CustomFormat = "dd MMM yyyy  HH:mm";
            dtpPerformanceDate.Location = new Point(60, 33);
            dtpPerformanceDate.Name = "dtpPerformanceDate";
            dtpPerformanceDate.Size = new Size(210, 27);
            dtpPerformanceDate.TabIndex = 63;
            // 
            // lblPerfSeats
            // 
            lblPerfSeats.AutoSize = true;
            lblPerfSeats.Font = new Font("Segoe UI", 10F);
            lblPerfSeats.Location = new Point(280, 35);
            lblPerfSeats.Name = "lblPerfSeats";
            lblPerfSeats.Size = new Size(52, 23);
            lblPerfSeats.Text = "Seats:";
            // 
            // nudTotalSeats
            // 
            nudTotalSeats.Location = new Point(338, 33);
            nudTotalSeats.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudTotalSeats.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudTotalSeats.Name = "nudTotalSeats";
            nudTotalSeats.Size = new Size(60, 27);
            nudTotalSeats.TabIndex = 64;
            nudTotalSeats.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // btnAddPerformance
            // 
            btnAddPerformance.BackColor = Color.FromArgb(39, 174, 96);
            btnAddPerformance.FlatStyle = FlatStyle.Flat;
            btnAddPerformance.FlatAppearance.BorderSize = 0;
            btnAddPerformance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddPerformance.ForeColor = Color.White;
            btnAddPerformance.Location = new Point(405, 30);
            btnAddPerformance.Name = "btnAddPerformance";
            btnAddPerformance.Size = new Size(45, 30);
            btnAddPerformance.TabIndex = 65;
            btnAddPerformance.Text = "+";
            btnAddPerformance.UseVisualStyleBackColor = false;
            btnAddPerformance.Click += btnAddPerformance_Click;
            // 
            // dgvPerformances
            // 
            dgvPerformances.AllowUserToAddRows = false;
            dgvPerformances.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPerformances.BackgroundColor = Color.White;
            dgvPerformances.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPerformances.Location = new Point(10, 70);
            dgvPerformances.Name = "dgvPerformances";
            dgvPerformances.ReadOnly = true;
            dgvPerformances.RowHeadersWidth = 30;
            dgvPerformances.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPerformances.Size = new Size(440, 360);
            dgvPerformances.TabIndex = 66;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(39, 174, 96);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(50, 540);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 40);
            btnSave.TabIndex = 39;
            btnSave.Text = "Save Play";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DarkOrange;
            btnBack.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnBack.ForeColor = SystemColors.ControlText;
            btnBack.Location = new Point(200, 540);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 40);
            btnBack.TabIndex = 41;
            btnBack.Text = "<- Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // roundPictureBox1
            // 
            roundPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            roundPictureBox1.ImeMode = ImeMode.NoControl;
            roundPictureBox1.Location = new Point(925, 0);
            roundPictureBox1.Name = "roundPictureBox1";
            roundPictureBox1.Size = new Size(57, 47);
            roundPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            roundPictureBox1.TabIndex = 48;
            roundPictureBox1.TabStop = false;
            roundPictureBox1.Click += roundPictureBox1_Click;
            // 
            // menu
            // 
            menu.BackColor = SystemColors.ScrollBar;
            menu.BackgroundImageLayout = ImageLayout.Stretch;
            menu.Font = new Font("Verdana", 12F, FontStyle.Bold);
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { Home, Vehicles, Store, MyReservations, Users, Management });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Padding = new Padding(7, 1, 0, 7);
            menu.Size = new Size(982, 42);
            menu.TabIndex = 47;
            menu.Text = "Menu";
            // 
            // Home
            // 
            Home.Name = "Home";
            Home.Size = new Size(91, 34);
            Home.Text = "Home";
            Home.Click += menu_ItemClicked;
            // 
            // Vehicles
            // 
            Vehicles.ForeColor = SystemColors.ActiveCaptionText;
            Vehicles.Name = "Vehicles";
            Vehicles.Padding = new Padding(4, 0, 4, 5);
            Vehicles.Size = new Size(117, 34);
            Vehicles.Text = "Plays";
            Vehicles.Click += menu_ItemClicked;
            // 
            // Store
            // 
            Store.ForeColor = SystemColors.ActiveCaptionText;
            Store.Name = "Store";
            Store.Padding = new Padding(4, 0, 4, 5);
            Store.Size = new Size(84, 34);
            Store.Text = "Store";
            Store.Click += menu_ItemClicked;
            // 
            // MyReservations
            // 
            MyReservations.Font = new Font("Verdana", 12F, FontStyle.Bold);
            MyReservations.ForeColor = SystemColors.ActiveCaptionText;
            MyReservations.Name = "MyReservations";
            MyReservations.Padding = new Padding(4, 0, 4, 5);
            MyReservations.Size = new Size(136, 34);
            MyReservations.Text = "My Tickets";
            MyReservations.Click += menu_ItemClicked;
            // 
            // Users
            // 
            Users.Font = new Font("Verdana", 12F, FontStyle.Bold);
            Users.ForeColor = SystemColors.MenuText;
            Users.Name = "Users";
            Users.Padding = new Padding(4, 0, 4, 5);
            Users.Size = new Size(87, 34);
            Users.Text = "Users";
            Users.Visible = false;
            Users.Click += menu_ItemClicked;
            // 
            // Management
            // 
            Management.DropDownItems.AddRange(new ToolStripItem[] { manageProducts, manageVehicles });
            Management.Font = new Font("Verdana", 12F, FontStyle.Bold);
            Management.Name = "Management";
            Management.Size = new Size(169, 34);
            Management.Text = "Management";
            Management.Visible = false;
            // 
            // manageProducts
            // 
            manageProducts.Name = "manageProducts";
            manageProducts.Size = new Size(198, 30);
            manageProducts.Text = "Souvenirs";
            manageProducts.Click += menu_ItemClicked;
            // 
            // manageVehicles
            // 
            manageVehicles.Name = "manageVehicles";
            manageVehicles.Size = new Size(198, 30);
            manageVehicles.Text = "Plays";
            manageVehicles.Click += menu_ItemClicked;
            // 
            // AddEditExhibit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_stagenova;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 600);
            Controls.Add(roundPictureBox1);
            Controls.Add(menu);
            Controls.Add(grpPerformances);
            Controls.Add(label6);
            Controls.Add(lblPrice);
            Controls.Add(txtPrice);
            Controls.Add(label2);
            Controls.Add(numYear);
            Controls.Add(cmbType);
            Controls.Add(txtModel);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(pictureBox1);
            Controls.Add(pbImage);
            Controls.Add(txtDescription);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtMake);
            Controls.Add(label1);
            DoubleBuffered = true;
            Icon = Properties.Resources.StageNova_logo1;
            Name = "AddEditExhibit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add / Edit Play";
            Load += AddEditExhibit_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTotalSeats).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPerformances).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).EndInit();
            grpPerformances.ResumeLayout(false);
            grpPerformances.PerformLayout();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnSave;
        private PictureBox pictureBox1;
        private Button pbImage;
        private TextBox txtDescription;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtMake;
        private Label label1;
        private TextBox txtModel;
        private ComboBox cmbType;
        private NumericUpDown numYear;
        private Label label2;
        private Label label6;
        private Label lblPrice;
        private TextBox txtPrice;
        private GroupBox grpPerformances;
        private DataGridView dgvPerformances;
        private Button btnAddPerformance;
        private DateTimePicker dtpPerformanceDate;
        private NumericUpDown nudTotalSeats;
        private Label lblPerfDate;
        private Label lblPerfSeats;
        private Utilities.RoundPictureBox roundPictureBox1;
        private MenuStrip menu;
        private ToolStripMenuItem Home;
        private ToolStripMenuItem Vehicles;
        private ToolStripMenuItem Store;
        private ToolStripMenuItem MyReservations;
        private ToolStripMenuItem Users;
        private ToolStripMenuItem Management;
        private ToolStripMenuItem manageProducts;
        private ToolStripMenuItem manageVehicles;
    }
}