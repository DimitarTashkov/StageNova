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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
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
            footer.BackColor = Color.Transparent;
            footer.BackgroundImageLayout = ImageLayout.Stretch;
            footer.Font = new Font("Verdana", 11.25F, FontStyle.Italic);
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
            storeButton.BackColor = SystemColors.ButtonFace;
            storeButton.BackgroundImageLayout = ImageLayout.Stretch;
            storeButton.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic);
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
            exhibitionsButton.BackColor = SystemColors.ButtonFace;
            exhibitionsButton.BackgroundImageLayout = ImageLayout.Stretch;
            exhibitionsButton.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic);
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
            menu.BackColor = SystemColors.ScrollBar;
            menu.BackgroundImageLayout = ImageLayout.Stretch;
            menu.Font = new Font("Verdana", 12F, FontStyle.Bold);
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
            Vehicles.Text = "Vehicles";
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
            MyReservations.Text = "My orders";
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
            manageProducts.Text = "Products";
            manageProducts.Click += menu_ItemClicked;
            // 
            // manageVehicles
            // 
            manageVehicles.Name = "manageVehicles";
            manageVehicles.Size = new Size(198, 30);
            manageVehicles.Text = "Vehicles";
            manageVehicles.Click += menu_ItemClicked;
            // 
            // aboutUs
            // 
            aboutUs.AutoSize = true;
            aboutUs.BackColor = Color.Transparent;
            aboutUs.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            aboutUs.ForeColor = Color.White;
            aboutUs.Location = new Point(160, 556);
            aboutUs.Name = "aboutUs";
            aboutUs.Size = new Size(93, 25);
            aboutUs.TabIndex = 20;
            aboutUs.Text = "About us";
            aboutUs.Click += aboutUs_Click;
            // 
            // contactUs
            // 
            contactUs.AutoSize = true;
            contactUs.BackColor = Color.Transparent;
            contactUs.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            contactUs.ForeColor = Color.White;
            contactUs.ImeMode = ImeMode.NoControl;
            contactUs.Location = new Point(704, 556);
            contactUs.Name = "contactUs";
            contactUs.Size = new Size(106, 25);
            contactUs.TabIndex = 21;
            contactUs.Text = "Contact us";
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
            resources.ApplyResources(this, "$this");
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