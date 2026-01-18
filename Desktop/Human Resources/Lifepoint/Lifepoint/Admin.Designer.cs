using System.DirectoryServices.ActiveDirectory;

namespace Lifepoint
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            dashboardButton = new Button();
            dashboardPanel = new Panel();
            searchLabel = new Label();
            activeIndicator = new Panel();
            usersButton = new Button();
            salariesButton = new Button();
            performanceButton = new Button();
            calendarButton = new Button();
            searchBar = new TextBox();
            addUserPanel = new Panel();
            dbLogo = new PictureBox();
            posLabel = new Label();
            hLabel = new Label();
            phoneDBLabel = new Label();
            fnLabel = new Label();
            exit = new Button();
            positionDB = new TextBox();
            hoursOfDutyTB = new TextBox();
            phoneDB = new TextBox();
            nameDB = new TextBox();
            submitButton = new Button();
            userDB = new Panel();
            addUsersDesc = new PictureBox();
            divider = new Panel();
            logoutBtn = new Button();
            userSearchBox = new TextBox();
            userSearchLabel = new Label();
            addUser = new Button();
            dashboardPanel.SuspendLayout();
            addUserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dbLogo).BeginInit();
            userDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addUsersDesc).BeginInit();
            SuspendLayout();
            // 
            // dashboardButton
            // 
            dashboardButton.BackgroundImage = (Image)resources.GetObject("dashboardButton.BackgroundImage");
            dashboardButton.Cursor = Cursors.Hand;
            dashboardButton.FlatAppearance.BorderSize = 0;
            dashboardButton.FlatStyle = FlatStyle.Flat;
            dashboardButton.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboardButton.ForeColor = Color.White;
            dashboardButton.Location = new Point(3, 46);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Size = new Size(230, 35);
            dashboardButton.TabIndex = 0;
            dashboardButton.TextAlign = ContentAlignment.MiddleLeft;
            dashboardButton.UseVisualStyleBackColor = true;
            // 
            // dashboardPanel
            // 
            dashboardPanel.Controls.Add(searchLabel);
            dashboardPanel.Controls.Add(activeIndicator);
            dashboardPanel.Controls.Add(dashboardButton);
            dashboardPanel.Controls.Add(usersButton);
            dashboardPanel.Controls.Add(salariesButton);
            dashboardPanel.Controls.Add(performanceButton);
            dashboardPanel.Controls.Add(calendarButton);
            dashboardPanel.Controls.Add(searchBar);
            dashboardPanel.Location = new Point(23, 89);
            dashboardPanel.Name = "dashboardPanel";
            dashboardPanel.Size = new Size(236, 239);
            dashboardPanel.TabIndex = 1;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.BackColor = Color.FromArgb(209, 250, 229);
            searchLabel.Cursor = Cursors.IBeam;
            searchLabel.Font = new Font("Inter Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchLabel.Image = (Image)resources.GetObject("searchLabel.Image");
            searchLabel.ImageAlign = ContentAlignment.MiddleLeft;
            searchLabel.Location = new Point(6, 8);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(194, 22);
            searchLabel.TabIndex = 7;
            searchLabel.Text = "                                              ";
            searchLabel.TextAlign = ContentAlignment.MiddleRight;
            searchLabel.Click += searchLabel_Click;
            // 
            // activeIndicator
            // 
            activeIndicator.BackColor = Color.FromArgb(62, 180, 137);
            activeIndicator.Location = new Point(13, 87);
            activeIndicator.Name = "activeIndicator";
            activeIndicator.Size = new Size(5, 34);
            activeIndicator.TabIndex = 2;
            activeIndicator.Visible = false;
            // 
            // usersButton
            // 
            usersButton.BackgroundImage = (Image)resources.GetObject("usersButton.BackgroundImage");
            usersButton.Cursor = Cursors.Hand;
            usersButton.FlatStyle = FlatStyle.Flat;
            usersButton.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usersButton.ForeColor = Color.White;
            usersButton.Location = new Point(13, 90);
            usersButton.Name = "usersButton";
            usersButton.Size = new Size(120, 31);
            usersButton.TabIndex = 1;
            usersButton.TextAlign = ContentAlignment.MiddleLeft;
            usersButton.UseVisualStyleBackColor = true;
            // 
            // salariesButton
            // 
            salariesButton.BackgroundImage = (Image)resources.GetObject("salariesButton.BackgroundImage");
            salariesButton.Cursor = Cursors.Hand;
            salariesButton.FlatStyle = FlatStyle.Flat;
            salariesButton.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            salariesButton.ForeColor = Color.Transparent;
            salariesButton.Location = new Point(13, 127);
            salariesButton.Name = "salariesButton";
            salariesButton.Size = new Size(120, 25);
            salariesButton.TabIndex = 2;
            salariesButton.TextAlign = ContentAlignment.MiddleLeft;
            salariesButton.UseVisualStyleBackColor = true;
            // 
            // performanceButton
            // 
            performanceButton.BackgroundImage = (Image)resources.GetObject("performanceButton.BackgroundImage");
            performanceButton.Cursor = Cursors.Hand;
            performanceButton.FlatStyle = FlatStyle.Flat;
            performanceButton.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            performanceButton.ForeColor = Color.White;
            performanceButton.Location = new Point(13, 158);
            performanceButton.Name = "performanceButton";
            performanceButton.Size = new Size(120, 34);
            performanceButton.TabIndex = 3;
            performanceButton.TextAlign = ContentAlignment.MiddleLeft;
            performanceButton.UseVisualStyleBackColor = true;
            // 
            // calendarButton
            // 
            calendarButton.BackgroundImage = (Image)resources.GetObject("calendarButton.BackgroundImage");
            calendarButton.Cursor = Cursors.Hand;
            calendarButton.FlatStyle = FlatStyle.Flat;
            calendarButton.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calendarButton.ForeColor = Color.White;
            calendarButton.Location = new Point(13, 198);
            calendarButton.Name = "calendarButton";
            calendarButton.Size = new Size(120, 21);
            calendarButton.TabIndex = 4;
            calendarButton.TextAlign = ContentAlignment.MiddleLeft;
            calendarButton.UseVisualStyleBackColor = true;
            // 
            // searchBar
            // 
            searchBar.BackColor = Color.FromArgb(6, 95, 70);
            searchBar.BorderStyle = BorderStyle.None;
            searchBar.Font = new Font("Inter SemiBold", 10.75F, FontStyle.Bold);
            searchBar.ForeColor = Color.White;
            searchBar.Location = new Point(8, 8);
            searchBar.Multiline = true;
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(230, 30);
            searchBar.TabIndex = 4;
            searchBar.TextChanged += searchBar_TextChanged;
            // 
            // addUserPanel
            // 
            addUserPanel.Controls.Add(dbLogo);
            addUserPanel.Controls.Add(posLabel);
            addUserPanel.Controls.Add(hLabel);
            addUserPanel.Controls.Add(phoneDBLabel);
            addUserPanel.Controls.Add(fnLabel);
            addUserPanel.Controls.Add(exit);
            addUserPanel.Controls.Add(positionDB);
            addUserPanel.Controls.Add(hoursOfDutyTB);
            addUserPanel.Controls.Add(phoneDB);
            addUserPanel.Controls.Add(nameDB);
            addUserPanel.Controls.Add(submitButton);
            addUserPanel.Location = new Point(145, 89);
            addUserPanel.Name = "addUserPanel";
            addUserPanel.Size = new Size(516, 360);
            addUserPanel.TabIndex = 11;
            addUserPanel.Visible = false;
            addUserPanel.Paint += addUserPanel_Paint;
            // 
            // dbLogo
            // 
            dbLogo.BackgroundImage = (Image)resources.GetObject("dbLogo.BackgroundImage");
            dbLogo.Location = new Point(36, 8);
            dbLogo.Name = "dbLogo";
            dbLogo.Size = new Size(171, 87);
            dbLogo.TabIndex = 21;
            dbLogo.TabStop = false;
            // 
            // posLabel
            // 
            posLabel.AutoSize = true;
            posLabel.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            posLabel.ForeColor = Color.White;
            posLabel.Image = (Image)resources.GetObject("posLabel.Image");
            posLabel.Location = new Point(49, 247);
            posLabel.Name = "posLabel";
            posLabel.Size = new Size(110, 23);
            posLabel.TabIndex = 20;
            posLabel.Text = "                         ";
            // 
            // hLabel
            // 
            hLabel.AutoSize = true;
            hLabel.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hLabel.ForeColor = Color.White;
            hLabel.Image = (Image)resources.GetObject("hLabel.Image");
            hLabel.Location = new Point(48, 198);
            hLabel.Name = "hLabel";
            hLabel.Size = new Size(106, 23);
            hLabel.TabIndex = 19;
            hLabel.Text = "                        ";
            // 
            // phoneDBLabel
            // 
            phoneDBLabel.AutoSize = true;
            phoneDBLabel.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phoneDBLabel.ForeColor = Color.White;
            phoneDBLabel.Image = (Image)resources.GetObject("phoneDBLabel.Image");
            phoneDBLabel.Location = new Point(47, 151);
            phoneDBLabel.Name = "phoneDBLabel";
            phoneDBLabel.Size = new Size(118, 23);
            phoneDBLabel.TabIndex = 18;
            phoneDBLabel.Text = "                           ";
            // 
            // fnLabel
            // 
            fnLabel.AutoSize = true;
            fnLabel.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fnLabel.ForeColor = Color.White;
            fnLabel.Image = (Image)resources.GetObject("fnLabel.Image");
            fnLabel.Location = new Point(49, 103);
            fnLabel.Name = "fnLabel";
            fnLabel.Size = new Size(106, 23);
            fnLabel.TabIndex = 17;
            fnLabel.Text = "                        ";
            // 
            // exit
            // 
            exit.BackColor = Color.FromArgb(62, 180, 137);
            exit.Cursor = Cursors.Hand;
            exit.FlatAppearance.BorderSize = 0;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Font = new Font("Inter ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.Location = new Point(477, 3);
            exit.Name = "exit";
            exit.Size = new Size(36, 30);
            exit.TabIndex = 16;
            exit.Text = "X";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // positionDB
            // 
            positionDB.BackColor = Color.FromArgb(6, 95, 70);
            positionDB.Font = new Font("Inter SemiBold", 10.75F, FontStyle.Bold);
            positionDB.ForeColor = Color.White;
            positionDB.Location = new Point(192, 244);
            positionDB.Multiline = true;
            positionDB.Name = "positionDB";
            positionDB.Size = new Size(260, 30);
            positionDB.TabIndex = 15;
            // 
            // hoursOfDutyTB
            // 
            hoursOfDutyTB.BackColor = Color.FromArgb(6, 95, 70);
            hoursOfDutyTB.Font = new Font("Inter SemiBold", 10.75F, FontStyle.Bold);
            hoursOfDutyTB.ForeColor = Color.White;
            hoursOfDutyTB.Location = new Point(192, 196);
            hoursOfDutyTB.Multiline = true;
            hoursOfDutyTB.Name = "hoursOfDutyTB";
            hoursOfDutyTB.Size = new Size(260, 30);
            hoursOfDutyTB.TabIndex = 14;
            // 
            // phoneDB
            // 
            phoneDB.BackColor = Color.FromArgb(6, 95, 70);
            phoneDB.Font = new Font("Inter SemiBold", 10.75F, FontStyle.Bold);
            phoneDB.ForeColor = Color.White;
            phoneDB.Location = new Point(192, 148);
            phoneDB.Multiline = true;
            phoneDB.Name = "phoneDB";
            phoneDB.Size = new Size(260, 30);
            phoneDB.TabIndex = 13;
            // 
            // nameDB
            // 
            nameDB.BackColor = Color.FromArgb(6, 95, 70);
            nameDB.Font = new Font("Inter SemiBold", 10.75F, FontStyle.Bold);
            nameDB.ForeColor = Color.White;
            nameDB.Location = new Point(192, 101);
            nameDB.Multiline = true;
            nameDB.Name = "nameDB";
            nameDB.Size = new Size(260, 30);
            nameDB.TabIndex = 12;
            // 
            // submitButton
            // 
            submitButton.Cursor = Cursors.Hand;
            submitButton.FlatAppearance.BorderSize = 0;
            submitButton.FlatStyle = FlatStyle.Flat;
            submitButton.Image = (Image)resources.GetObject("submitButton.Image");
            submitButton.Location = new Point(192, 296);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(122, 42);
            submitButton.TabIndex = 0;
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += submitButton_Click;
            // 
            // userDB
            // 
            userDB.AutoScroll = true;
            userDB.Controls.Add(addUsersDesc);
            userDB.Location = new Point(293, 124);
            userDB.Name = "userDB";
            userDB.Size = new Size(519, 360);
            userDB.TabIndex = 10;
            userDB.Paint += userDB_Paint;
            // 
            // addUsersDesc
            // 
            addUsersDesc.Image = (Image)resources.GetObject("addUsersDesc.Image");
            addUsersDesc.Location = new Point(0, 0);
            addUsersDesc.Name = "addUsersDesc";
            addUsersDesc.Size = new Size(519, 53);
            addUsersDesc.TabIndex = 12;
            addUsersDesc.TabStop = false;
            // 
            // divider
            // 
            divider.BackColor = Color.FromArgb(11, 23, 57);
            divider.Location = new Point(265, 2);
            divider.Name = "divider";
            divider.Size = new Size(2, 542);
            divider.TabIndex = 2;
            // 
            // logoutBtn
            // 
            logoutBtn.BackgroundImage = (Image)resources.GetObject("logoutBtn.BackgroundImage");
            logoutBtn.Cursor = Cursors.Hand;
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.ForeColor = Color.FromArgb(6, 95, 70);
            logoutBtn.Location = new Point(31, 430);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(222, 58);
            logoutBtn.TabIndex = 3;
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // userSearchBox
            // 
            userSearchBox.BackColor = Color.FromArgb(6, 95, 70);
            userSearchBox.BorderStyle = BorderStyle.None;
            userSearchBox.Font = new Font("Inter SemiBold", 10.75F, FontStyle.Bold);
            userSearchBox.ForeColor = Color.White;
            userSearchBox.Location = new Point(285, 12);
            userSearchBox.Multiline = true;
            userSearchBox.Name = "userSearchBox";
            userSearchBox.Size = new Size(230, 30);
            userSearchBox.TabIndex = 8;
            userSearchBox.TextChanged += userSearchBox_TextChanged;
            // 
            // userSearchLabel
            // 
            userSearchLabel.AutoSize = true;
            userSearchLabel.BackColor = Color.FromArgb(209, 250, 229);
            userSearchLabel.Cursor = Cursors.IBeam;
            userSearchLabel.Font = new Font("Inter Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userSearchLabel.Image = (Image)resources.GetObject("userSearchLabel.Image");
            userSearchLabel.ImageAlign = ContentAlignment.MiddleLeft;
            userSearchLabel.Location = new Point(288, 13);
            userSearchLabel.Name = "userSearchLabel";
            userSearchLabel.Size = new Size(194, 22);
            userSearchLabel.TabIndex = 8;
            userSearchLabel.Text = "                                              ";
            userSearchLabel.TextAlign = ContentAlignment.MiddleRight;
            userSearchLabel.Click += userSearchLabel_Click;
            // 
            // addUser
            // 
            addUser.BackgroundImage = (Image)resources.GetObject("addUser.BackgroundImage");
            addUser.Cursor = Cursors.Hand;
            addUser.FlatStyle = FlatStyle.Flat;
            addUser.ForeColor = Color.FromArgb(6, 95, 70);
            addUser.Location = new Point(660, 12);
            addUser.Name = "addUser";
            addUser.Size = new Size(149, 41);
            addUser.TabIndex = 9;
            addUser.UseVisualStyleBackColor = false;
            addUser.Click += addUser_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(6, 95, 70);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(821, 542);
            Controls.Add(addUser);
            Controls.Add(addUserPanel);
            Controls.Add(userSearchLabel);
            Controls.Add(userSearchBox);
            Controls.Add(logoutBtn);
            Controls.Add(divider);
            Controls.Add(dashboardPanel);
            Controls.Add(userDB);
            DoubleBuffered = true;
            MaximizeBox = false;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lifepoint - Admin";
            Load += Admin_Load;
            dashboardPanel.ResumeLayout(false);
            dashboardPanel.PerformLayout();
            addUserPanel.ResumeLayout(false);
            addUserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dbLogo).EndInit();
            userDB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)addUsersDesc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button dashboardButton;
        private Panel dashboardPanel;
        private Button calendarButton;
        private Button performanceButton;
        private Button salariesButton;
        private Button usersButton;
        private Panel activeIndicator;
        private Panel divider;
        private Button logoutBtn;
        private TextBox searchBar;
        private Label searchLabel;
        private TextBox userSearchBox;
        private Label userSearchLabel;
        private Button addUser;
        private Panel userDB;
        private Panel addUserPanel;
        private Button submitButton;
        private TextBox nameDB;
        private TextBox positionDB;
        private TextBox hoursOfDutyTB;
        private TextBox phoneDB;
        private Button exit;
        private ComboBox positionComboBox;
        private Label phoneLabel;
        private Label fnLabel;
        private Label hLabel;
        private Label posLabel;
        private PictureBox addUsersDesc;
        private PictureBox dbLogo;
    }
}