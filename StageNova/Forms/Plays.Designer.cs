namespace StageNova.Forms
{
    partial class Plays
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            flowPanel = new FlowLayoutPanel();
            btnBack = new Button();
            label1 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).BeginInit();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // flowPanel
            // 
            flowPanel.AutoScroll = true;
            flowPanel.BackColor = SystemColors.ScrollBar;
            flowPanel.BackgroundImage = Properties.Resources.gradient_img__4_;
            flowPanel.BackgroundImageLayout = ImageLayout.Stretch;
            flowPanel.Location = new Point(27, 105);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(925, 448);
            flowPanel.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DarkOrange;
            btnBack.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ControlText;
            btnBack.Location = new Point(12, 50);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(85, 39);
            btnBack.TabIndex = 25;
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
            label1.Location = new Point(376, 51);
            label1.Name = "label1";
            label1.Size = new Size(249, 38);
            label1.TabIndex = 26;
            label1.Text = "Repertoire";
            // 
            // roundPictureBox1
            // 
            roundPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            roundPictureBox1.ImeMode = ImeMode.NoControl;
            roundPictureBox1.Location = new Point(925, 0);
            roundPictureBox1.Name = "roundPictureBox1";
            roundPictureBox1.Size = new Size(57, 47);
            roundPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            roundPictureBox1.TabIndex = 52;
            roundPictureBox1.TabStop = false;
            roundPictureBox1.Click += roundPictureBox1_Click;
            // 
            // menu
            // 
            menu.BackColor = Color.FromArgb(30, 15, 30);
            menu.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            menu.BackgroundImageLayout = ImageLayout.Stretch;
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { Home, Vehicles, Store, MyReservations, Users, Management });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Padding = new Padding(7, 1, 0, 7);
            menu.Size = new Size(982, 42);
            menu.TabIndex = 51;
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
            // Plays
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_stagenova;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 600);
            Controls.Add(roundPictureBox1);
            Controls.Add(menu);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(flowPanel);
            DoubleBuffered = true;
            Icon = Properties.Resources.StageNova_logo1;
            Name = "Plays";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Plays";
            Load += Plays_Load;
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).EndInit();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowPanel;
        private Button btnBack;
        private Label label1;
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
