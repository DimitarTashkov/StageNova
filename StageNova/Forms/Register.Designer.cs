namespace StageNova.Forms
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            formPanel = new Panel();
            pfpErrorMessages = new Label();
            ageErrors = new Label();
            emailErrors = new Label();
            passwordErrors = new Label();
            usernameErrors = new Label();
            disclaimer = new Label();
            navigationButton = new Button();
            profilePicture = new StageNova.Utilities.RoundPictureBox();
            registerButton = new Button();
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
            register_label = new Label();
            formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // formPanel
            // 
            formPanel.BackColor = SystemColors.Control;
            formPanel.BackgroundImage = Properties.Resources.gradient_img__4_;
            formPanel.BackgroundImageLayout = ImageLayout.Stretch;
            formPanel.Controls.Add(pfpErrorMessages);
            formPanel.Controls.Add(ageErrors);
            formPanel.Controls.Add(emailErrors);
            formPanel.Controls.Add(passwordErrors);
            formPanel.Controls.Add(usernameErrors);
            formPanel.Controls.Add(disclaimer);
            formPanel.Controls.Add(navigationButton);
            formPanel.Controls.Add(profilePicture);
            formPanel.Controls.Add(registerButton);
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
            formPanel.Controls.Add(register_label);
            formPanel.Location = new Point(81, 33);
            formPanel.Margin = new Padding(3, 4, 3, 4);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(753, 533);
            formPanel.TabIndex = 1;
            formPanel.Paint += formPanel_Paint;
            // 
            // pfpErrorMessages
            // 
            pfpErrorMessages.AutoSize = true;
            pfpErrorMessages.BackColor = Color.Transparent;
            pfpErrorMessages.Font = new Font("Verdana", 8.25F, FontStyle.Bold | FontStyle.Italic);
            pfpErrorMessages.ForeColor = Color.Red;
            pfpErrorMessages.Location = new Point(487, 337);
            pfpErrorMessages.Name = "pfpErrorMessages";
            pfpErrorMessages.Size = new Size(54, 17);
            pfpErrorMessages.TabIndex = 23;
            pfpErrorMessages.Text = "label1";
            pfpErrorMessages.Visible = false;
            // 
            // ageErrors
            // 
            ageErrors.AutoSize = true;
            ageErrors.BackColor = Color.Transparent;
            ageErrors.Font = new Font("Verdana", 8.25F, FontStyle.Bold | FontStyle.Italic);
            ageErrors.ForeColor = Color.Red;
            ageErrors.Location = new Point(131, 393);
            ageErrors.Name = "ageErrors";
            ageErrors.Size = new Size(54, 17);
            ageErrors.TabIndex = 22;
            ageErrors.Text = "label1";
            ageErrors.Visible = false;
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
            emailErrors.TabIndex = 21;
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
            passwordErrors.TabIndex = 20;
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
            usernameErrors.TabIndex = 19;
            usernameErrors.Text = "label1";
            usernameErrors.Visible = false;
            // 
            // disclaimer
            // 
            disclaimer.AutoSize = true;
            disclaimer.BackColor = Color.Transparent;
            disclaimer.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            disclaimer.ForeColor = Color.DimGray;
            disclaimer.Location = new Point(0, 483);
            disclaimer.Name = "disclaimer";
            disclaimer.Size = new Size(199, 25);
            disclaimer.TabIndex = 18;
            disclaimer.Text = "(if you have account)";
            // 
            // navigationButton
            // 
            navigationButton.BackColor = Color.DarkOrange;
            navigationButton.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic);
            navigationButton.Location = new Point(0, 424);
            navigationButton.Margin = new Padding(3, 4, 3, 4);
            navigationButton.Name = "navigationButton";
            navigationButton.Size = new Size(183, 55);
            navigationButton.TabIndex = 17;
            navigationButton.Text = "Return to login";
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
            // registerButton
            // 
            registerButton.BackColor = Color.LightGreen;
            registerButton.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic);
            registerButton.Location = new Point(507, 424);
            registerButton.Margin = new Padding(3, 4, 3, 4);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(183, 55);
            registerButton.TabIndex = 15;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += btnRegister_Click;
            // 
            // uploadButton
            // 
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
            ageLabel.Location = new Point(215, 321);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(59, 32);
            ageLabel.TabIndex = 11;
            ageLabel.Text = "Age";
            // 
            // emailField
            // 
            emailField.BackColor = Color.LightGray;
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
            emailLabel.Location = new Point(215, 229);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(87, 32);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "*Email";
            // 
            // passwordField
            // 
            passwordField.BackColor = Color.LightGray;
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
            passwordLabel.Location = new Point(215, 139);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(133, 32);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "*Password";
            // 
            // usernameField
            // 
            usernameField.BackColor = Color.LightGray;
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
            usernameLabel.Location = new Point(215, 48);
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
            logo.Location = new Point(-13, -32);
            logo.Margin = new Padding(3, 4, 3, 4);
            logo.Name = "logo";
            logo.Size = new Size(184, 213);
            logo.TabIndex = 1;
            logo.TabStop = false;
            // 
            // register_label
            // 
            register_label.AutoSize = true;
            register_label.BackColor = Color.Transparent;
            register_label.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            register_label.Location = new Point(261, 0);
            register_label.Name = "register_label";
            register_label.Size = new Size(275, 37);
            register_label.TabIndex = 0;
            register_label.Text = "Register Credentials";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_stagenova;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(formPanel);
            DoubleBuffered = true;
            Icon = Properties.Resources.StageNova_logo1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Register_Load;
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profilePicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel formPanel;
        private Label disclaimer;
        private Button navigationButton;
        private StageNova.Utilities.RoundPictureBox profilePicture;
        private Button registerButton;
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
        private Label register_label;
        private Label usernameErrors;
        private Label ageErrors;
        private Label emailErrors;
        private Label passwordErrors;
        private Label pfpErrorMessages;
    }
}