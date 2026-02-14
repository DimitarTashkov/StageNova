namespace StageNova.Forms
{
    partial class Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvReservations = new DataGridView();
            tabPage2 = new TabPage();
            dgvOrders = new DataGridView();
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
            btnBack = new Button();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).BeginInit();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(31, 81);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(914, 520);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvReservations);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(906, 487);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "My Tickets";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvReservations
            // 
            dgvReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservations.Dock = DockStyle.Fill;
            dgvReservations.Location = new Point(3, 3);
            dgvReservations.Name = "dgvReservations";
            dgvReservations.RowHeadersWidth = 51;
            dgvReservations.Size = new Size(900, 481);
            dgvReservations.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvOrders);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(906, 487);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Merchandise Orders";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Dock = DockStyle.Fill;
            dgvOrders.Location = new Point(3, 3);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.Size = new Size(900, 481);
            dgvOrders.TabIndex = 0;
            // 
            // roundPictureBox1
            // 
            roundPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            roundPictureBox1.ImeMode = ImeMode.NoControl;
            roundPictureBox1.Location = new Point(925, 0);
            roundPictureBox1.Name = "roundPictureBox1";
            roundPictureBox1.Size = new Size(57, 47);
            roundPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            roundPictureBox1.TabIndex = 60;
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
            menu.TabIndex = 59;
            menu.Text = "Menu";
            // 
            // Home
            // 
            Home.ForeColor = Color.FromArgb(225, 200, 160);
            Home.Name = "Home";
            Home.Size = new Size(91, 34);
            Home.Text = "Home";
            Home.Click += menu_ItemClicked;
            // 
            // Vehicles
            // 
            Vehicles.ForeColor = Color.FromArgb(225, 200, 160);
            Vehicles.Name = "Vehicles";
            Vehicles.Padding = new Padding(4, 0, 4, 5);
            Vehicles.Size = new Size(117, 34);
            Vehicles.Text = "Repertoire";
            Vehicles.Click += menu_ItemClicked;
            // 
            // Store
            // 
            Store.ForeColor = Color.FromArgb(225, 200, 160);
            Store.Name = "Store";
            Store.Padding = new Padding(4, 0, 4, 5);
            Store.Size = new Size(84, 34);
            Store.Text = "Merchandise";
            Store.Click += menu_ItemClicked;
            // 
            // MyReservations
            // 
            MyReservations.ForeColor = Color.FromArgb(225, 200, 160);
            MyReservations.Name = "MyReservations";
            MyReservations.Padding = new Padding(4, 0, 4, 5);
            MyReservations.Size = new Size(136, 34);
            MyReservations.Text = "My Bookings";
            MyReservations.Click += menu_ItemClicked;
            // 
            // Users
            // 
            Users.ForeColor = Color.FromArgb(225, 200, 160);
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
            Management.ForeColor = Color.FromArgb(225, 200, 160);
            Management.Name = "Management";
            Management.Size = new Size(169, 34);
            Management.Text = "Management";
            Management.Visible = false;
            // 
            // manageProducts
            // 
            manageProducts.BackColor = Color.FromArgb(30, 15, 30);
            manageProducts.ForeColor = Color.FromArgb(225, 200, 160);
            manageProducts.Name = "manageProducts";
            manageProducts.Size = new Size(198, 30);
            manageProducts.Text = "Merchandise";
            manageProducts.Click += menu_ItemClicked;
            // 
            // manageVehicles
            // 
            manageVehicles.BackColor = Color.FromArgb(30, 15, 30);
            manageVehicles.ForeColor = Color.FromArgb(225, 200, 160);
            manageVehicles.Name = "manageVehicles";
            manageVehicles.Size = new Size(198, 30);
            manageVehicles.Text = "Plays";
            manageVehicles.Click += menu_ItemClicked;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DarkOrange;
            btnBack.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ControlText;
            btnBack.Location = new Point(12, 45);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(77, 30);
            btnBack.TabIndex = 61;
            btnBack.Text = "<-Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(418, 45);
            label1.Name = "label1";
            label1.Size = new Size(155, 38);
            label1.TabIndex = 62;
            label1.Text = "My Bookings";
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_stagenova;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 613);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(roundPictureBox1);
            Controls.Add(menu);
            Controls.Add(tabControl1);
            DoubleBuffered = true;
            Icon = Properties.Resources.StageNova_logo1;
            Name = "Orders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Bookings";
            Load += Orders_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReservations).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).EndInit();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvReservations;
        private DataGridView dgvOrders;
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
        private Button btnBack;
        private Label label1;
    }
}