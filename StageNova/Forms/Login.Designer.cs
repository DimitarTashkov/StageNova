namespace StageNova.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            formPanel = new Panel();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            passwordError = new Label();
            usernameError = new Label();
            register = new Label();
            loginBtn = new Button();
            passwordField = new TextBox();
            passwordLabel = new Label();
            usernameField = new TextBox();
            usernameLabel = new Label();
            logo = new PictureBox();
            label3 = new Label();
            formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // formPanel
            // 
            formPanel.BackColor = Color.White;
            formPanel.BackgroundImage = Properties.Resources.gradient_img__4_;
            formPanel.BackgroundImageLayout = ImageLayout.Stretch;
            formPanel.Controls.Add(label8);
            formPanel.Controls.Add(label7);
            formPanel.Controls.Add(label4);
            formPanel.Controls.Add(label6);
            formPanel.Controls.Add(label2);
            formPanel.Controls.Add(label1);
            formPanel.Controls.Add(passwordError);
            formPanel.Controls.Add(usernameError);
            formPanel.Controls.Add(register);
            formPanel.Controls.Add(loginBtn);
            formPanel.Controls.Add(passwordField);
            formPanel.Controls.Add(passwordLabel);
            formPanel.Controls.Add(usernameField);
            formPanel.Controls.Add(usernameLabel);
            formPanel.Controls.Add(logo);
            formPanel.Location = new Point(57, 72);
            formPanel.Margin = new Padding(3, 4, 3, 4);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(800, 467);
            formPanel.TabIndex = 1;
            formPanel.Paint += formPanel_Paint;
            // 
            // label8
            // 
            label8.AllowDrop = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold | FontStyle.Italic);
            label8.ForeColor = Color.Goldenrod;
            label8.Location = new Point(47, 347);
            label8.Name = "label8";
            label8.Size = new Size(446, 83);
            label8.TabIndex = 17;
            label8.Text = "🔑 Log in now and discover the magic of live theater!";
            // 
            // label7
            // 
            label7.AllowDrop = true;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.ForeColor = Color.Goldenrod;
            label7.Location = new Point(47, 269);
            label7.MaximumSize = new Size(343, 0);
            label7.Name = "label7";
            label7.Size = new Size(314, 84);
            label7.TabIndex = 16;
            label7.Text = "✨ Immerse yourself in unforgettable performances and stories";
            // 
            // label4
            // 
            label4.AllowDrop = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.Goldenrod;
            label4.Location = new Point(21, 371);
            label4.Name = "label4";
            label4.Size = new Size(114, 31);
            label4.TabIndex = 15;
            // 
            // label6
            // 
            label6.AllowDrop = true;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.ForeColor = Color.Goldenrod;
            label6.Location = new Point(47, 192);
            label6.MaximumSize = new Size(343, 0);
            label6.Name = "label6";
            label6.Size = new Size(282, 28);
            label6.TabIndex = 14;
            label6.Text = "🎭 Live stage. Real emotions.";
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Goldenrod;
            label2.Location = new Point(47, 113);
            label2.MaximumSize = new Size(343, 0);
            label2.Name = "label2";
            label2.Size = new Size(292, 56);
            label2.TabIndex = 10;
            label2.Text = "🌀 Welcome to a place where stories come alive on stage.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold);
            label1.Location = new Point(77, 11);
            label1.Name = "label1";
            label1.Size = new Size(466, 40);
            label1.TabIndex = 9;
            label1.Text = "Welcome to StageNova Theater";
            // 
            // passwordError
            // 
            passwordError.AutoSize = true;
            passwordError.BackColor = Color.Transparent;
            passwordError.Font = new Font("Verdana", 8.25F, FontStyle.Bold | FontStyle.Italic);
            passwordError.ForeColor = Color.Red;
            passwordError.Location = new Point(400, 303);
            passwordError.Name = "passwordError";
            passwordError.Size = new Size(54, 17);
            passwordError.TabIndex = 8;
            passwordError.Text = "label1";
            passwordError.Visible = false;
            // 
            // usernameError
            // 
            usernameError.AutoSize = true;
            usernameError.BackColor = Color.Transparent;
            usernameError.Font = new Font("Verdana", 8.25F, FontStyle.Bold | FontStyle.Italic);
            usernameError.ForeColor = Color.Red;
            usernameError.Location = new Point(400, 192);
            usernameError.Name = "usernameError";
            usernameError.Size = new Size(54, 17);
            usernameError.TabIndex = 7;
            usernameError.Text = "label1";
            usernameError.Visible = false;
            // 
            // register
            // 
            register.AutoSize = true;
            register.BackColor = Color.Transparent;
            register.Cursor = Cursors.Hand;
            register.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            register.ForeColor = Color.Blue;
            register.Location = new Point(560, 420);
            register.Name = "register";
            register.Size = new Size(81, 25);
            register.TabIndex = 6;
            register.Text = "Register";
            register.Click += register_Click;
            register.MouseLeave += register_leave;
            register.MouseHover += register_hover;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.SkyBlue;
            loginBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            loginBtn.ForeColor = Color.Black;
            loginBtn.Location = new Point(503, 347);
            loginBtn.Margin = new Padding(3, 4, 3, 4);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(183, 55);
            loginBtn.TabIndex = 5;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += login_Click;
            loginBtn.MouseLeave += login_leave;
            loginBtn.MouseHover += login_hover;
            // 
            // passwordField
            // 
            passwordField.BackColor = Color.LightGray;
            passwordField.Font = new Font("Verdana", 12F);
            passwordField.ForeColor = Color.DimGray;
            passwordField.Location = new Point(400, 263);
            passwordField.Margin = new Padding(3, 4, 3, 4);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(395, 32);
            passwordField.TabIndex = 4;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            passwordLabel.Location = new Point(543, 219);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(132, 37);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password";
            // 
            // usernameField
            // 
            usernameField.BackColor = Color.LightGray;
            usernameField.Font = new Font("Verdana", 12F);
            usernameField.ForeColor = Color.DimGray;
            usernameField.Location = new Point(400, 153);
            usernameField.Margin = new Padding(3, 4, 3, 4);
            usernameField.Name = "usernameField";
            usernameField.Size = new Size(395, 32);
            usernameField.TabIndex = 2;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            usernameLabel.Location = new Point(535, 112);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(140, 37);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username";
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.BackgroundImage = Properties.Resources.StageNova_logo;
            logo.BackgroundImageLayout = ImageLayout.Stretch;
            logo.Location = new Point(614, -59);
            logo.Margin = new Padding(3, 4, 3, 4);
            logo.Name = "logo";
            logo.Size = new Size(231, 228);
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // label3
            // 
            label3.AllowDrop = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.Goldenrod;
            label3.Location = new Point(213, -8);
            label3.Name = "label3";
            label3.Size = new Size(114, 31);
            label3.TabIndex = 11;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_stagenova;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(formPanel);
            Controls.Add(label3);
            DoubleBuffered = true;
            Icon = Properties.Resources.StageNova_logo1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel formPanel;
        private Label register;
        private Button loginBtn;
        private TextBox passwordField;
        private Label passwordLabel;
        private TextBox usernameField;
        private Label usernameLabel;
        private PictureBox logo;
        private Label usernameError;
        private Label passwordError;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label6;
        private Label label4;
        private Label label8;
        private Label label7;
    }
}