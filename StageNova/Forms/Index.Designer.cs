namespace StageNova.Forms
{
    partial class Index
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
            footer = new Button();
            storeButton = new Button();
            exhibitionsButton = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            menu = new MenuStrip();
            Home = new ToolStripMenuItem();
            Vehicles = new ToolStripMenuItem();
            Store = new ToolStripMenuItem();
            MyReservations = new ToolStripMenuItem();
            Users = new ToolStripMenuItem();
            Management = new ToolStripMenuItem();
            manageProducts = new ToolStripMenuItem();
            manageVehicles = new ToolStripMenuItem();
            aboutUs = new Label();
            contactUs = new Label();
            welcomeMessage = new Label();
            roundPictureBox1 = new StageNova.Utilities.RoundPictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // footer
            // 
            footer.BackColor = Color.FromArgb(120, 27, 51);
            footer.Cursor = Cursors.Hand;
            footer.FlatStyle = FlatStyle.Flat;
            footer.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            footer.ForeColor = Color.White;
            footer.Location = new Point(0, 545);
            footer.Margin = new Padding(3, 4, 3, 4);
            footer.Name = "footer";
            footer.Size = new Size(931, 52);
            footer.TabIndex = 18;
            footer.Text = "Ⓒ StageNova 2026";
            footer.UseVisualStyleBackColor = false;
            // 
            // storeButton
            // 
            storeButton.BackColor = Color.FromArgb(120, 27, 51);
            storeButton.Cursor = Cursors.Hand;
            storeButton.FlatStyle = FlatStyle.Flat;
            storeButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            storeButton.ForeColor = Color.White;
            storeButton.Location = new Point(605, 437);
            storeButton.Margin = new Padding(3, 4, 3, 4);
            storeButton.Name = "storeButton";
            storeButton.Size = new Size(232, 67);
            storeButton.TabIndex = 16;
            storeButton.Text = "Browse Merchandise";
            storeButton.UseVisualStyleBackColor = false;
            storeButton.Click += store_button_Click;
            // 
            // exhibitionsButton
            // 
            exhibitionsButton.BackColor = Color.FromArgb(120, 27, 51);
            exhibitionsButton.Cursor = Cursors.Hand;
            exhibitionsButton.FlatStyle = FlatStyle.Flat;
            exhibitionsButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            exhibitionsButton.ForeColor = Color.White;
            exhibitionsButton.Location = new Point(95, 436);
            exhibitionsButton.Margin = new Padding(3, 4, 3, 4);
            exhibitionsButton.Name = "exhibitionsButton";
            exhibitionsButton.Size = new Size(217, 67);
            exhibitionsButton.TabIndex = 15;
            exhibitionsButton.Text = "Explore Our Repertoire";
            exhibitionsButton.UseVisualStyleBackColor = false;
            exhibitionsButton.Click += exhibitionsButton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.drama_background_wt956l4ngvrqc6w5;
            pictureBox2.Location = new Point(0, 115);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(457, 309);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.throw_pillows_blankets_featured;
            pictureBox1.Location = new Point(458, 116);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(457, 309);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
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
            menu.Size = new Size(914, 42);
            menu.TabIndex = 11;
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
            // aboutUs
            // 
            aboutUs.AutoSize = true;
            aboutUs.BackColor = Color.Transparent;
            aboutUs.Cursor = Cursors.Hand;
            aboutUs.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            aboutUs.ForeColor = Color.White;
            aboutUs.Location = new Point(160, 556);
            aboutUs.Name = "aboutUs";
            aboutUs.Size = new Size(93, 25);
            aboutUs.TabIndex = 20;
            aboutUs.Text = "About us";
            aboutUs.TextAlign = ContentAlignment.MiddleCenter;
            aboutUs.Click += aboutUs_Click;
            // 
            // contactUs
            // 
            contactUs.AutoSize = true;
            contactUs.BackColor = Color.Transparent;
            contactUs.Cursor = Cursors.Hand;
            contactUs.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            contactUs.ForeColor = Color.White;
            contactUs.Location = new Point(704, 556);
            contactUs.Name = "contactUs";
            contactUs.Size = new Size(106, 25);
            contactUs.TabIndex = 21;
            contactUs.Text = "Contact us";
            contactUs.TextAlign = ContentAlignment.MiddleCenter;
            contactUs.Click += contactUs_Click;
            // 
            // welcomeMessage
            // 
            welcomeMessage.BackColor = Color.Transparent;
            welcomeMessage.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            welcomeMessage.ForeColor = Color.White;
            welcomeMessage.Location = new Point(28, 70);
            welcomeMessage.Name = "welcomeMessage";
            welcomeMessage.Size = new Size(856, 41);
            welcomeMessage.TabIndex = 23;
            welcomeMessage.Text = "Welcome to StageNova — where stories come alive on stage.";
            welcomeMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // roundPictureBox1
            // 
            roundPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            roundPictureBox1.Location = new Point(853, 0);
            roundPictureBox1.Name = "roundPictureBox1";
            roundPictureBox1.Size = new Size(57, 47);
            roundPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            roundPictureBox1.TabIndex = 24;
            roundPictureBox1.TabStop = false;
            roundPictureBox1.Click += roundPictureBox1_Click;
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_stagenova;
            ClientSize = new Size(914, 600);
            Controls.Add(roundPictureBox1);
            Controls.Add(welcomeMessage);
            Controls.Add(contactUs);
            Controls.Add(aboutUs);
            Controls.Add(footer);
            Controls.Add(storeButton);
            Controls.Add(exhibitionsButton);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(menu);
            DoubleBuffered = true;
            Icon = Properties.Resources.StageNova_logo1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Index";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StageNova";
            Load += Index_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button footer;
        private Button storeButton;
        private Button exhibitionsButton;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private MenuStrip menu;
        private ToolStripMenuItem Store;
        private ToolStripMenuItem Vehicles;
        private ToolStripMenuItem Users;
        private ToolStripMenuItem MyReservations;
        private ToolStripMenuItem Management;
        private ToolStripMenuItem Home;
        private Label aboutUs;
        private Label contactUs;
        private Label welcomeMessage;
        private ToolStripMenuItem manageProducts;
        private ToolStripMenuItem manageVehicles;
        private Utilities.RoundPictureBox roundPictureBox1;
    }
}