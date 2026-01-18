namespace Lifepoint
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            vectorOne = new PictureBox();
            vectorTwo = new PictureBox();
            tb_username = new TextBox();
            tb_password = new TextBox();
            usernameLabel = new Label();
            passwordLabel = new Label();
            loginBtn = new Button();
            label1 = new Label();
            registerLinkLabel = new LinkLabel();
            loginBG = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)vectorOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vectorTwo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loginBG).BeginInit();
            SuspendLayout();
            // 
            // vectorOne
            // 
            vectorOne.Image = (Image)resources.GetObject("vectorOne.Image");
            vectorOne.Location = new Point(406, -2);
            vectorOne.Name = "vectorOne";
            vectorOne.Size = new Size(428, 361);
            vectorOne.TabIndex = 1;
            vectorOne.TabStop = false;
            // 
            // vectorTwo
            // 
            vectorTwo.Image = (Image)resources.GetObject("vectorTwo.Image");
            vectorTwo.Location = new Point(0, 198);
            vectorTwo.Name = "vectorTwo";
            vectorTwo.Size = new Size(428, 361);
            vectorTwo.TabIndex = 2;
            vectorTwo.TabStop = false;
            // 
            // tb_username
            // 
            tb_username.Anchor = AnchorStyles.Bottom;
            tb_username.BackColor = Color.FromArgb(224, 242, 254);
            tb_username.BorderStyle = BorderStyle.FixedSingle;
            tb_username.Font = new Font("Inter Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_username.Location = new Point(315, 275);
            tb_username.Multiline = true;
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(200, 30);
            tb_username.TabIndex = 4;
            tb_username.TextChanged += tb_username_TextChanged;
            // 
            // tb_password
            // 
            tb_password.Anchor = AnchorStyles.Bottom;
            tb_password.BackColor = Color.FromArgb(224, 242, 254);
            tb_password.BorderStyle = BorderStyle.FixedSingle;
            tb_password.Font = new Font("Inter Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_password.Location = new Point(315, 311);
            tb_password.Multiline = true;
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(200, 30);
            tb_password.TabIndex = 5;
            tb_password.TextChanged += tb_password_TextChanged;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.FromArgb(209, 250, 229);
            usernameLabel.Cursor = Cursors.IBeam;
            usernameLabel.Font = new Font("Inter Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.Image = (Image)resources.GetObject("usernameLabel.Image");
            usernameLabel.ImageAlign = ContentAlignment.MiddleLeft;
            usernameLabel.Location = new Point(320, 277);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(113, 22);
            usernameLabel.TabIndex = 6;
            usernameLabel.Text = "     USERNAME";
            usernameLabel.TextAlign = ContentAlignment.MiddleRight;
            usernameLabel.Click += usernameLabel_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.FromArgb(209, 250, 229);
            passwordLabel.Cursor = Cursors.IBeam;
            passwordLabel.Font = new Font("Inter Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.Image = (Image)resources.GetObject("passwordLabel.Image");
            passwordLabel.ImageAlign = ContentAlignment.MiddleLeft;
            passwordLabel.Location = new Point(320, 313);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(112, 22);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "     PASSWORD";
            passwordLabel.TextAlign = ContentAlignment.MiddleRight;
            passwordLabel.Click += passwordLabel_Click;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.White;
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.FlatAppearance.BorderColor = Color.White;
            loginBtn.FlatAppearance.BorderSize = 2;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Inter SemiBold", 12.25F, FontStyle.Bold);
            loginBtn.ForeColor = Color.FromArgb(28, 164, 172);
            loginBtn.Location = new Point(315, 351);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(200, 38);
            loginBtn.TabIndex = 8;
            loginBtn.Text = "LOGIN";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(209, 250, 229);
            label1.Font = new Font("Inter Light", 8.25F);
            label1.Location = new Point(320, 421);
            label1.Name = "label1";
            label1.Size = new Size(125, 16);
            label1.TabIndex = 9;
            label1.Text = "Don't have an account?";
            // 
            // registerLinkLabel
            // 
            registerLinkLabel.ActiveLinkColor = Color.FromArgb(16, 185, 129);
            registerLinkLabel.AutoSize = true;
            registerLinkLabel.BackColor = Color.FromArgb(209, 250, 229);
            registerLinkLabel.Cursor = Cursors.Hand;
            registerLinkLabel.DisabledLinkColor = Color.Black;
            registerLinkLabel.Font = new Font("Inter ExtraBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerLinkLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            registerLinkLabel.LinkColor = Color.FromArgb(16, 185, 129);
            registerLinkLabel.Location = new Point(451, 421);
            registerLinkLabel.Name = "registerLinkLabel";
            registerLinkLabel.Size = new Size(53, 16);
            registerLinkLabel.TabIndex = 10;
            registerLinkLabel.TabStop = true;
            registerLinkLabel.Text = "Register";
            registerLinkLabel.LinkClicked += registerLinkLabel_LinkClicked;
            // 
            // loginBG
            // 
            loginBG.Image = (Image)resources.GetObject("loginBG.Image");
            loginBG.Location = new Point(248, 66);
            loginBG.Name = "loginBG";
            loginBG.Size = new Size(324, 411);
            loginBG.SizeMode = PictureBoxSizeMode.AutoSize;
            loginBG.TabIndex = 3;
            loginBG.TabStop = false;
            loginBG.Click += loginBG_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(6, 95, 70);
            ClientSize = new Size(821, 542);
            Controls.Add(registerLinkLabel);
            Controls.Add(label1);
            Controls.Add(loginBtn);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(tb_password);
            Controls.Add(tb_username);
            Controls.Add(loginBG);
            Controls.Add(vectorTwo);
            Controls.Add(vectorOne);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lifepoint - Login";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)vectorOne).EndInit();
            ((System.ComponentModel.ISupportInitialize)vectorTwo).EndInit();
            ((System.ComponentModel.ISupportInitialize)loginBG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox vectorOne;
        private PictureBox vectorTwo;
        private TextBox tb_username;
        private TextBox tb_password;
        private Label usernameLabel;
        private Label passwordLabel;
        private Button loginBtn;
        private Label label1;
        private LinkLabel registerLinkLabel;
        private PictureBox loginBG;
    }
}
