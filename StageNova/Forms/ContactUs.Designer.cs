namespace StageNova.Forms
{
    partial class ContactUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactUs));
            label2 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).BeginInit();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(0, 144);
            label2.Name = "label2";
            label2.Size = new Size(585, 224);
            label2.TabIndex = 25;
            label2.Text = resources.GetString("label2.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.StageNova_logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(591, 144);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(330, 266);
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // roundPictureBox1
            // 
            roundPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            roundPictureBox1.ImeMode = ImeMode.NoControl;
            roundPictureBox1.Location = new Point(890, 0);
            roundPictureBox1.Name = "roundPictureBox1";
            roundPictureBox1.Size = new Size(57, 47);
            roundPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            roundPictureBox1.TabIndex = 54;
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
            menu.Size = new Size(950, 42);
            menu.TabIndex = 53;
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
            // ContactUs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_stagenova;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(950, 600);
            Controls.Add(roundPictureBox1);
            Controls.Add(menu);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            DoubleBuffered = true;
            Icon = Properties.Resources.StageNova_logo1;
            Name = "ContactUs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contact us";
            Load += ContactUs_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).EndInit();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
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