namespace StageNova.Forms
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            logoutButton = new Button();
            saveButton = new Button();
            deleteButton = new Button();
            navigationButton = new Button();
            profilePicture = new StageNova.Utilities.RoundPictureBox();
            editButton = new Button();
            uploadButton = new Button();
            ageField = new TextBox();
            ageLabel = new Label();
            emailField = new TextBox();
            emailLabel = new Label();
            passwordField = new TextBox();
            passwordLabel = new Label();
            usernameField = new TextBox();
            usernameLabel = new Label();
            logo = new PictureBox();
            profileLabel = new Label();
            formPanel = new Panel();
            pfpErrors = new Label();
            emailErrors = new Label();
            passwordErrors = new Label();
            usernameErrors = new Label();
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
            ((System.ComponentModel.ISupportInitialize)profilePicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).BeginInit();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.Red;
            logoutButton.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic);
            logoutButton.Location = new Point(542, 479);
            logoutButton.Margin = new Padding(3, 4, 3, 4);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(183, 55);
            logoutButton.TabIndex = 21;
            logoutButton.Text = "Log out";
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.LightGreen;
            saveButton.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic);
            saveButton.Location = new Point(352, 416);
            saveButton.Margin = new Padding(3, 4, 3, 4);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(183, 55);
            saveButton.TabIndex = 20;
            saveButton.Text = "Save data";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Visible = false;
            saveButton.Click += saveButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Red;
            deleteButton.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic);
            deleteButton.Location = new Point(542, 416);
            deleteButton.Margin = new Padding(3, 4, 3, 4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(183, 55);
            deleteButton.TabIndex = 19;
            deleteButton.Text = "Delete user";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // navigationButton
            // 
            navigationButton.BackColor = Color.DarkOrange;
            navigationButton.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic);
            navigationButton.Location = new Point(3, 416);
            navigationButton.Margin = new Padding(3, 4, 3, 4);
            navigationButton.Name = "navigationButton";
            navigationButton.Size = new Size(183, 55);
            navigationButton.TabIndex = 17;
            navigationButton.Text = "Return to home";
            navigationButton.UseVisualStyleBackColor = false;
            navigationButton.Click += navigationButton_Click;
            // 
            // profilePicture
            // 
            profilePicture.Location = new Point(526, 69);
            profilePicture.Margin = new Padding(3, 4, 3, 4);
            profilePicture.Name = "profilePicture";
            profilePicture.Size = new Size(165, 157);
            profilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            profilePicture.TabIndex = 16;
            profilePicture.TabStop = false;
            // 
            // editButton
            // 
            editButton.BackColor = Color.LightGray;
            editButton.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic);
            editButton.Location = new Point(352, 416);
            editButton.Margin = new Padding(3, 4, 3, 4);
            editButton.Name = "editButton";
            editButton.Size = new Size(183, 55);
            editButton.TabIndex = 15;
            editButton.Text = "Edit information";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // uploadButton
            // 
            uploadButton.Enabled = false;
            uploadButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            uploadButton.Location = new Point(526, 267);
            uploadButton.Margin = new Padding(3, 4, 3, 4);
            uploadButton.Name = "uploadButton";
            uploadButton.Size = new Size(149, 40);
            uploadButton.TabIndex = 13;
            uploadButton.Text = "Upload pfp";
            uploadButton.UseVisualStyleBackColor = true;
            uploadButton.Click += uploadImage_click;
            // 
            // ageField
            // 
            ageField.BackColor = Color.LightGray;
            ageField.Enabled = false;
            ageField.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            ageField.ForeColor = Color.DimGray;
            ageField.Location = new Point(131, 359);
            ageField.Margin = new Padding(3, 4, 3, 4);
            ageField.Name = "ageField";
            ageField.Size = new Size(278, 27);
            ageField.TabIndex = 12;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.BackColor = Color.Transparent;
            ageLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            ageLabel.Location = new Point(221, 321);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(59, 32);
            ageLabel.TabIndex = 11;
            ageLabel.Text = "Age";
            // 
            // emailField
            // 
            emailField.BackColor = Color.LightGray;
            emailField.Enabled = false;
            emailField.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            emailField.ForeColor = Color.DimGray;
            emailField.Location = new Point(131, 267);
            emailField.Margin = new Padding(3, 4, 3, 4);
            emailField.Name = "emailField";
            emailField.Size = new Size(278, 27);
            emailField.TabIndex = 10;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.Transparent;
            emailLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            emailLabel.Location = new Point(221, 229);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(87, 32);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "*Email";
            // 
            // passwordField
            // 
            passwordField.BackColor = Color.LightGray;
            passwordField.Enabled = false;
            passwordField.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            passwordField.ForeColor = Color.DimGray;
            passwordField.Location = new Point(131, 176);
            passwordField.Margin = new Padding(3, 4, 3, 4);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(278, 27);
            passwordField.TabIndex = 8;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            passwordLabel.Location = new Point(221, 139);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(133, 32);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "*Password";
            // 
            // usernameField
            // 
            usernameField.BackColor = Color.LightGray;
            usernameField.Enabled = false;
            usernameField.Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic);
            usernameField.ForeColor = Color.DimGray;
            usernameField.Location = new Point(131, 85);
            usernameField.Margin = new Padding(3, 4, 3, 4);
            usernameField.Name = "usernameField";
            usernameField.Size = new Size(278, 27);
            usernameField.TabIndex = 6;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            usernameLabel.Location = new Point(221, 48);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(139, 32);
            usernameLabel.TabIndex = 5;
            usernameLabel.Text = "*Username";
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.BackgroundImage = Properties.Resources.StageNova_logo;
            logo.BackgroundImageLayout = ImageLayout.Stretch;
            logo.Location = new Point(-14, -29);
            logo.Margin = new Padding(3, 4, 3, 4);
            logo.Name = "logo";
            logo.Size = new Size(157, 197);
            logo.TabIndex = 1;
            logo.TabStop = false;
            // 
            // profileLabel
            // 
            profileLabel.AutoSize = true;
            profileLabel.BackColor = Color.Transparent;
            profileLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            profileLabel.Location = new Point(333, 0);
            profileLabel.Name = "profileLabel";
            profileLabel.Size = new Size(103, 37);
            profileLabel.TabIndex = 0;
            profileLabel.Text = "Profile";
            // 
            // formPanel
            // 
            formPanel.BackColor = SystemColors.Control;
            formPanel.BackgroundImage = Properties.Resources.gradient_img__4_;
            formPanel.BackgroundImageLayout = ImageLayout.Stretch;
            formPanel.Controls.Add(pfpErrors);
            formPanel.Controls.Add(emailErrors);
            formPanel.Controls.Add(passwordErrors);
            formPanel.Controls.Add(usernameErrors);
            formPanel.Controls.Add(logoutButton);
            formPanel.Controls.Add(saveButton);
            formPanel.Controls.Add(deleteButton);
            formPanel.Controls.Add(navigationButton);
            formPanel.Controls.Add(profilePicture);
            formPanel.Controls.Add(editButton);
            formPanel.Controls.Add(uploadButton);
            formPanel.Controls.Add(ageField);
            formPanel.Controls.Add(ageLabel);
            formPanel.Controls.Add(emailField);
            formPanel.Controls.Add(emailLabel);
            formPanel.Controls.Add(passwordField);
            formPanel.Controls.Add(passwordLabel);
            formPanel.Controls.Add(usernameField);
            formPanel.Controls.Add(usernameLabel);
            formPanel.Controls.Add(logo);
            formPanel.Controls.Add(profileLabel);
            formPanel.Location = new Point(80, 53);
            formPanel.Margin = new Padding(3, 4, 3, 4);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(753, 533);
            formPanel.TabIndex = 2;
            // 
            // pfpErrors
            // 
            pfpErrors.AutoSize = true;
            pfpErrors.BackColor = Color.Transparent;
            pfpErrors.Font = new Font("Verdana", 8.25F, FontStyle.Bold | FontStyle.Italic);
            pfpErrors.ForeColor = Color.Red;
            pfpErrors.Location = new Point(526, 331);
            pfpErrors.Name = "pfpErrors";
            pfpErrors.Size = new Size(54, 17);
            pfpErrors.TabIndex = 25;
            pfpErrors.Text = "label1";
            pfpErrors.Visible = false;
            // 
            // emailErrors
            // 
            emailErrors.AutoSize = true;
            emailErrors.BackColor = Color.Transparent;
            emailErrors.Font = new Font("Verdana", 8.25F, FontStyle.Bold | FontStyle.Italic);
            emailErrors.ForeColor = Color.Red;
            emailErrors.Location = new Point(131, 301);
            emailErrors.Name = "emailErrors";
            emailErrors.Size = new Size(54, 17);
            emailErrors.TabIndex = 24;
            emailErrors.Text = "label1";
            emailErrors.Visible = false;
            // 
            // passwordErrors
            // 
            passwordErrors.AutoSize = true;
            passwordErrors.BackColor = Color.Transparent;
            passwordErrors.Font = new Font("Verdana", 8.25F, FontStyle.Bold | FontStyle.Italic);
            passwordErrors.ForeColor = Color.Red;
            passwordErrors.Location = new Point(131, 211);
            passwordErrors.Name = "passwordErrors";
            passwordErrors.Size = new Size(54, 17);
            passwordErrors.TabIndex = 23;
            passwordErrors.Text = "label1";
            passwordErrors.Visible = false;
            // 
            // usernameErrors
            // 
            usernameErrors.AutoSize = true;
            usernameErrors.BackColor = Color.Transparent;
            usernameErrors.Font = new Font("Verdana", 8.25F, FontStyle.Bold | FontStyle.Italic);
            usernameErrors.ForeColor = Color.Red;
            usernameErrors.Location = new Point(131, 120);
            usernameErrors.Name = "usernameErrors";
            usernameErrors.Size = new Size(54, 17);
            usernameErrors.TabIndex = 22;
            usernameErrors.Text = "label1";
            usernameErrors.Visible = false;
            // 
            // roundPictureBox1
            // 
            roundPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            roundPictureBox1.ImeMode = ImeMode.NoControl;
            roundPictureBox1.Location = new Point(857, 0);
            roundPictureBox1.Name = "roundPictureBox1";
            roundPictureBox1.Size = new Size(57, 47);
            roundPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            roundPictureBox1.TabIndex = 62;
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
            menu.Size = new Size(914, 42);
            menu.TabIndex = 61;
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
            Vehicles.Text = "Repertoire";
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
            MyReservations.Text = "My Bookings";
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
            manageProducts.Text = "Merchandise";
            manageProducts.Click += menu_ItemClicked;
            // 
            // manageVehicles
            // 
            manageVehicles.Name = "manageVehicles";
            manageVehicles.Size = new Size(198, 30);
            manageVehicles.Text = "Plays";
            manageVehicles.Click += menu_ItemClicked;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_stagenova;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(roundPictureBox1);
            Controls.Add(menu);
            Controls.Add(formPanel);
            Icon = Properties.Resources.StageNova_logo1;
            Margin = new Padding(3, 5, 3, 5);
            Name = "Profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            Load += Profile_Load;
            ((System.ComponentModel.ISupportInitialize)profilePicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).EndInit();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logoutButton;
        private Button saveButton;
        private Button deleteButton;
        private Button navigationButton;
        private StageNova.Utilities.RoundPictureBox profilePicture;
        private Button editButton;
        private Button uploadButton;
        private TextBox ageField;
        private Label ageLabel;
        private TextBox emailField;
        private Label emailLabel;
        private TextBox passwordField;
        private Label passwordLabel;
        private TextBox usernameField;
        private Label usernameLabel;
        private PictureBox logo;
        private Label profileLabel;
        private Panel formPanel;
        private Label pfpErrors;
        private Label emailErrors;
        private Label passwordErrors;
        private Label usernameErrors;
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