namespace StageNova.Forms
{
    partial class BookTicket
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
            lblTitle = new Label();
            lblPlayInfo = new Label();
            cmbPerformance = new ComboBox();
            lblPerformance = new Label();
            lblTicketCount = new Label();
            nudTicketCount = new NumericUpDown();
            lblTotalPrice = new Label();
            btnBook = new Button();
            btnBack = new Button();
            pictureBox1 = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)nudTicketCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).BeginInit();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(340, 51);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(280, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Book Theater Ticket";
            // 
            // lblPlayInfo
            // 
            lblPlayInfo.BackColor = Color.Transparent;
            lblPlayInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayInfo.ForeColor = Color.White;
            lblPlayInfo.Location = new Point(60, 110);
            lblPlayInfo.MaximumSize = new Size(600, 120);
            lblPlayInfo.Name = "lblPlayInfo";
            lblPlayInfo.Size = new Size(600, 120);
            lblPlayInfo.TabIndex = 1;
            lblPlayInfo.Text = "Selected:";
            // 
            // cmbPerformance
            // 
            cmbPerformance.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPerformance.Font = new Font("Segoe UI", 11F);
            cmbPerformance.FormattingEnabled = true;
            cmbPerformance.Location = new Point(60, 280);
            cmbPerformance.Name = "cmbPerformance";
            cmbPerformance.Size = new Size(420, 33);
            cmbPerformance.TabIndex = 2;
            cmbPerformance.SelectedIndexChanged += cmbPerformance_SelectedIndexChanged;
            // 
            // lblPerformance
            // 
            lblPerformance.AutoSize = true;
            lblPerformance.BackColor = Color.Transparent;
            lblPerformance.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPerformance.ForeColor = Color.White;
            lblPerformance.Location = new Point(60, 245);
            lblPerformance.Name = "lblPerformance";
            lblPerformance.Size = new Size(220, 31);
            lblPerformance.TabIndex = 3;
            lblPerformance.Text = "Select Performance:";
            // 
            // lblTicketCount
            // 
            lblTicketCount.AutoSize = true;
            lblTicketCount.BackColor = Color.Transparent;
            lblTicketCount.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTicketCount.ForeColor = Color.White;
            lblTicketCount.Location = new Point(60, 330);
            lblTicketCount.Name = "lblTicketCount";
            lblTicketCount.Size = new Size(212, 31);
            lblTicketCount.TabIndex = 4;
            lblTicketCount.Text = "Number of Tickets:";
            // 
            // nudTicketCount
            // 
            nudTicketCount.Font = new Font("Segoe UI", 12F);
            nudTicketCount.Location = new Point(60, 370);
            nudTicketCount.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudTicketCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudTicketCount.Name = "nudTicketCount";
            nudTicketCount.Size = new Size(120, 34);
            nudTicketCount.TabIndex = 5;
            nudTicketCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudTicketCount.ValueChanged += nudTicketCount_ValueChanged;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.BackColor = Color.Transparent;
            lblTotalPrice.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPrice.ForeColor = Color.LightGreen;
            lblTotalPrice.Location = new Point(60, 420);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(182, 32);
            lblTotalPrice.TabIndex = 8;
            lblTotalPrice.Text = "Total: 0.00 BGN";
            // 
            // btnBook
            // 
            btnBook.BackColor = Color.FromArgb(39, 174, 96);
            btnBook.FlatAppearance.BorderSize = 0;
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBook.ForeColor = Color.White;
            btnBook.Location = new Point(60, 470);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(180, 45);
            btnBook.TabIndex = 6;
            btnBook.Text = "🎫 Book Tickets";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DarkOrange;
            btnBack.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ControlText;
            btnBack.Location = new Point(260, 475);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 39);
            btnBack.TabIndex = 27;
            btnBack.Text = "<- Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(700, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // roundPictureBox1
            // 
            roundPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            roundPictureBox1.ImeMode = ImeMode.NoControl;
            roundPictureBox1.Location = new Point(925, 0);
            roundPictureBox1.Name = "roundPictureBox1";
            roundPictureBox1.Size = new Size(57, 47);
            roundPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            roundPictureBox1.TabIndex = 50;
            roundPictureBox1.TabStop = false;
            roundPictureBox1.Click += roundPictureBox1_Click;
            // 
            // menu
            // 
            menu.BackColor = Color.FromArgb(30, 15, 30);
            menu.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { Home, Vehicles, Store, MyReservations, Users, Management });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Padding = new Padding(7, 1, 0, 7);
            menu.Size = new Size(982, 42);
            menu.TabIndex = 49;
            menu.Text = "Menu";
            // 
            // Home
            // 
            Home.ForeColor = Color.FromArgb(225, 200, 160);
            Home.Name = "Home";
            Home.Size = new Size(80, 34);
            Home.Text = "Home";
            Home.Click += menu_ItemClicked;
            // 
            // Vehicles
            // 
            Vehicles.ForeColor = Color.FromArgb(225, 200, 160);
            Vehicles.Name = "Vehicles";
            Vehicles.Padding = new Padding(4, 0, 4, 5);
            Vehicles.Size = new Size(119, 34);
            Vehicles.Text = "Repertoire";
            Vehicles.Click += menu_ItemClicked;
            // 
            // Store
            // 
            Store.ForeColor = Color.FromArgb(225, 200, 160);
            Store.Name = "Store";
            Store.Padding = new Padding(4, 0, 4, 5);
            Store.Size = new Size(137, 34);
            Store.Text = "Merchandise";
            Store.Click += menu_ItemClicked;
            // 
            // MyReservations
            // 
            MyReservations.ForeColor = Color.FromArgb(225, 200, 160);
            MyReservations.Name = "MyReservations";
            MyReservations.Padding = new Padding(4, 0, 4, 5);
            MyReservations.Size = new Size(141, 34);
            MyReservations.Text = "My Bookings";
            MyReservations.Click += menu_ItemClicked;
            // 
            // Users
            // 
            Users.ForeColor = Color.FromArgb(225, 200, 160);
            Users.Name = "Users";
            Users.Padding = new Padding(4, 0, 4, 5);
            Users.Size = new Size(72, 34);
            Users.Text = "Users";
            Users.Visible = false;
            Users.Click += menu_ItemClicked;
            // 
            // Management
            // 
            Management.DropDownItems.AddRange(new ToolStripItem[] { manageProducts, manageVehicles });
            Management.ForeColor = Color.FromArgb(225, 200, 160);
            Management.Name = "Management";
            Management.Size = new Size(144, 34);
            Management.Text = "Management";
            Management.Visible = false;
            // 
            // manageProducts
            // 
            manageProducts.BackColor = Color.FromArgb(30, 15, 30);
            manageProducts.ForeColor = Color.FromArgb(225, 200, 160);
            manageProducts.Name = "manageProducts";
            manageProducts.Size = new Size(211, 30);
            manageProducts.Text = "Merchandise";
            manageProducts.Click += menu_ItemClicked;
            // 
            // manageVehicles
            // 
            manageVehicles.BackColor = Color.FromArgb(30, 15, 30);
            manageVehicles.ForeColor = Color.FromArgb(225, 200, 160);
            manageVehicles.Name = "manageVehicles";
            manageVehicles.Size = new Size(211, 30);
            manageVehicles.Text = "Plays";
            manageVehicles.Click += menu_ItemClicked;
            // 
            // BookTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_stagenova;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 553);
            Controls.Add(roundPictureBox1);
            Controls.Add(menu);
            Controls.Add(pictureBox1);
            Controls.Add(btnBack);
            Controls.Add(btnBook);
            Controls.Add(lblTotalPrice);
            Controls.Add(nudTicketCount);
            Controls.Add(lblTicketCount);
            Controls.Add(cmbPerformance);
            Controls.Add(lblPerformance);
            Controls.Add(lblPlayInfo);
            Controls.Add(lblTitle);
            DoubleBuffered = true;
            Icon = Properties.Resources.StageNova_logo1;
            Name = "BookTicket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Theater Ticket";
            Load += BookTicket_Load;
            ((System.ComponentModel.ISupportInitialize)nudTicketCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).EndInit();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblPlayInfo;
        private ComboBox cmbPerformance;
        private Label lblPerformance;
        private Label lblTicketCount;
        private NumericUpDown nudTicketCount;
        private Label lblTotalPrice;
        private Button btnBook;
        private Button btnBack;
        private PictureBox pictureBox1;
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