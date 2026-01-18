namespace Lifepoint
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
            description = new PictureBox();
            secondBG = new PictureBox();
            tb_fullname = new TextBox();
            tb_username = new TextBox();
            tb_password = new TextBox();
            tb_confirmPassword = new TextBox();
            fullNameLabel = new Label();
            usernameLabel = new Label();
            passwordLabel = new Label();
            confirmPasswordLabel = new Label();
            cb_TermsOfService = new CheckBox();
            createBtn = new Button();
            label1 = new Label();
            loginLinkLabel = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)description).BeginInit();
            ((System.ComponentModel.ISupportInitialize)secondBG).BeginInit();
            SuspendLayout();
            // 
            // description
            // 
            description.BackgroundImage = (Image)resources.GetObject("description.BackgroundImage");
            description.Location = new Point(397, -4);
            description.Name = "description";
            description.Size = new Size(427, 547);
            description.TabIndex = 18;
            description.TabStop = false;
            // 
            // secondBG
            // 
            secondBG.BackgroundImage = (Image)resources.GetObject("secondBG.BackgroundImage");
            secondBG.Location = new Point(40, 27);
            secondBG.Name = "secondBG";
            secondBG.Size = new Size(190, 120);
            secondBG.TabIndex = 19;
            secondBG.TabStop = false;
            // 
            // tb_fullname
            // 
            tb_fullname.Anchor = AnchorStyles.Bottom;
            tb_fullname.BackColor = Color.FromArgb(6, 95, 70);
            tb_fullname.BorderStyle = BorderStyle.FixedSingle;
            tb_fullname.Font = new Font("Inter Light", 9.5F);
            tb_fullname.ForeColor = Color.White;
            tb_fullname.Location = new Point(58, 172);
            tb_fullname.Multiline = true;
            tb_fullname.Name = "tb_fullname";
            tb_fullname.Size = new Size(283, 26);
            tb_fullname.TabIndex = 20;
            tb_fullname.TextChanged += tb_fullname_TextChanged;
            // 
            // tb_username
            // 
            tb_username.Anchor = AnchorStyles.Bottom;
            tb_username.BackColor = Color.FromArgb(6, 95, 70);
            tb_username.BorderStyle = BorderStyle.FixedSingle;
            tb_username.Font = new Font("Inter Light", 9.5F);
            tb_username.ForeColor = Color.White;
            tb_username.Location = new Point(58, 217);
            tb_username.Multiline = true;
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(283, 26);
            tb_username.TabIndex = 21;
            tb_username.TextChanged += tb_username_TextChanged;
            // 
            // tb_password
            // 
            tb_password.Anchor = AnchorStyles.Bottom;
            tb_password.BackColor = Color.FromArgb(6, 95, 70);
            tb_password.BorderStyle = BorderStyle.FixedSingle;
            tb_password.Font = new Font("Inter Light", 9.5F);
            tb_password.ForeColor = Color.White;
            tb_password.Location = new Point(58, 264);
            tb_password.Multiline = true;
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(283, 26);
            tb_password.TabIndex = 22;
            tb_password.TextChanged += tb_password_TextChanged;
            // 
            // tb_confirmPassword
            // 
            tb_confirmPassword.Anchor = AnchorStyles.Bottom;
            tb_confirmPassword.BackColor = Color.FromArgb(6, 95, 70);
            tb_confirmPassword.BorderStyle = BorderStyle.FixedSingle;
            tb_confirmPassword.Font = new Font("Inter Light", 9.5F);
            tb_confirmPassword.ForeColor = Color.White;
            tb_confirmPassword.Location = new Point(58, 309);
            tb_confirmPassword.Multiline = true;
            tb_confirmPassword.Name = "tb_confirmPassword";
            tb_confirmPassword.Size = new Size(283, 26);
            tb_confirmPassword.TabIndex = 23;
            tb_confirmPassword.TextChanged += tb_confirmPassword_TextChanged;
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.BackColor = Color.FromArgb(6, 95, 70);
            fullNameLabel.Cursor = Cursors.IBeam;
            fullNameLabel.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fullNameLabel.ForeColor = Color.White;
            fullNameLabel.ImageAlign = ContentAlignment.MiddleLeft;
            fullNameLabel.Location = new Point(60, 173);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(80, 22);
            fullNameLabel.TabIndex = 24;
            fullNameLabel.Text = "Full name";
            fullNameLabel.TextAlign = ContentAlignment.MiddleRight;
            fullNameLabel.Click += fullNameLabel_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.FromArgb(6, 95, 70);
            usernameLabel.Cursor = Cursors.IBeam;
            usernameLabel.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = Color.White;
            usernameLabel.ImageAlign = ContentAlignment.MiddleLeft;
            usernameLabel.Location = new Point(60, 219);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(85, 22);
            usernameLabel.TabIndex = 25;
            usernameLabel.Text = "Username";
            usernameLabel.TextAlign = ContentAlignment.MiddleRight;
            usernameLabel.Click += usernameLabel_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.FromArgb(6, 95, 70);
            passwordLabel.Cursor = Cursors.IBeam;
            passwordLabel.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.ForeColor = Color.White;
            passwordLabel.ImageAlign = ContentAlignment.MiddleLeft;
            passwordLabel.Location = new Point(60, 266);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(82, 22);
            passwordLabel.TabIndex = 26;
            passwordLabel.Text = "Password";
            passwordLabel.TextAlign = ContentAlignment.MiddleRight;
            passwordLabel.Click += passwordLabel_Click;
            // 
            // confirmPasswordLabel
            // 
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.BackColor = Color.FromArgb(6, 95, 70);
            confirmPasswordLabel.Cursor = Cursors.IBeam;
            confirmPasswordLabel.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmPasswordLabel.ForeColor = Color.White;
            confirmPasswordLabel.ImageAlign = ContentAlignment.MiddleLeft;
            confirmPasswordLabel.Location = new Point(60, 310);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(144, 22);
            confirmPasswordLabel.TabIndex = 27;
            confirmPasswordLabel.Text = "Confirm password";
            confirmPasswordLabel.TextAlign = ContentAlignment.MiddleRight;
            confirmPasswordLabel.Click += confirmPasswordLabel_Click;
            // 
            // cb_TermsOfService
            // 
            cb_TermsOfService.AutoSize = true;
            cb_TermsOfService.Cursor = Cursors.Hand;
            cb_TermsOfService.Font = new Font("Inter Medium", 8.25F, FontStyle.Bold);
            cb_TermsOfService.Location = new Point(107, 354);
            cb_TermsOfService.Name = "cb_TermsOfService";
            cb_TermsOfService.Size = new Size(185, 20);
            cb_TermsOfService.TabIndex = 28;
            cb_TermsOfService.Text = "I agree to the Terms of Service";
            cb_TermsOfService.BackColor = Color.Transparent;
            cb_TermsOfService.ForeColor = Color.Black;
            cb_TermsOfService.FlatStyle = FlatStyle.Flat;
            cb_TermsOfService.UseVisualStyleBackColor = false;
            // 
            // createBtn
            // 
            createBtn.Cursor = Cursors.Hand;
            createBtn.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createBtn.ForeColor = Color.FromArgb(62, 180, 137);
            createBtn.Location = new Point(100, 390);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(200, 32);
            createBtn.TabIndex = 29;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(6, 95, 70);
            label1.Font = new Font("Inter Light", 8.25F);
            label1.Location = new Point(110, 443);
            label1.Name = "label1";
            label1.Size = new Size(137, 16);
            label1.TabIndex = 30;
            label1.Text = "Already have an account?";
            // 
            // loginLinkLabel
            // 
            loginLinkLabel.ActiveLinkColor = Color.White;
            loginLinkLabel.AutoSize = true;
            loginLinkLabel.Cursor = Cursors.Hand;
            loginLinkLabel.DisabledLinkColor = Color.Black;
            loginLinkLabel.Font = new Font("Inter ExtraBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLinkLabel.ForeColor = Color.White;
            loginLinkLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            loginLinkLabel.LinkColor = Color.White;
            loginLinkLabel.Location = new Point(247, 443);
            loginLinkLabel.Name = "loginLinkLabel";
            loginLinkLabel.Size = new Size(37, 16);
            loginLinkLabel.TabIndex = 31;
            loginLinkLabel.TabStop = true;
            loginLinkLabel.Text = "Login";
            loginLinkLabel.LinkClicked += loginLinkLabel_LinkClicked;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(6, 95, 70);
            ClientSize = new Size(821, 542);
            Controls.Add(loginLinkLabel);
            Controls.Add(label1);
            Controls.Add(createBtn);
            Controls.Add(cb_TermsOfService);
            Controls.Add(confirmPasswordLabel);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(fullNameLabel);
            Controls.Add(tb_confirmPassword);
            Controls.Add(tb_password);
            Controls.Add(tb_username);
            Controls.Add(tb_fullname);
            Controls.Add(secondBG);
            Controls.Add(description);
            MaximizeBox = false;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lifepoint - Register";
            Load += Register_Load;
            ((System.ComponentModel.ISupportInitialize)description).EndInit();
            ((System.ComponentModel.ISupportInitialize)secondBG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox description;
        private PictureBox secondBG;
        private TextBox tb_fullname;
        private TextBox tb_username;
        private TextBox tb_password;
        private TextBox tb_confirmPassword;
        private Label fullNameLabel;
        private Label usernameLabel;
        private Label passwordLabel;
        private Label confirmPasswordLabel;
        private CheckBox cb_TermsOfService;
        private Button createBtn;
        private Label label1;
        private LinkLabel loginLinkLabel;
    }
}