using System.Data;

namespace Lifepoint
{
    public partial class Admin : Form
    {
        private Panel salariesPanel, performancePanel, calendarPanel;
        int currentMonth = DateTime.Now.Month;
        int currentYear = DateTime.Now.Year;

        private Label phoneDBLabel;

        private void Admin_Load(object sender, EventArgs e)
        {
            searchLabel.Visible = string.IsNullOrWhiteSpace(searchBar.Text);
            searchLabel.BringToFront();
            userSearchLabel.Visible = string.IsNullOrWhiteSpace(userSearchBox.Text);
            userSearchLabel.BringToFront();
        }

        public Admin()
        {
            InitializeComponent();
            LoadUserData();

            //dashboard show-and-hide
            dashboardPanel.BackColor = Color.FromArgb(6, 95, 70);

            Color panelBack = dashboardPanel.BackColor;

            usersButton.BackColor = panelBack;
            salariesButton.BackColor = panelBack;
            performanceButton.BackColor = panelBack;
            calendarButton.BackColor = panelBack;

            Font regularFont = new Font("Inter", 11F, FontStyle.Regular);
            usersButton.Font = regularFont;
            salariesButton.Font = regularFont;
            performanceButton.Font = regularFont;
            calendarButton.Font = regularFont;

            usersButton.FlatAppearance.BorderSize = 0;
            salariesButton.FlatAppearance.BorderSize = 0;
            performanceButton.FlatAppearance.BorderSize = 0;
            calendarButton.FlatAppearance.BorderSize = 0;

            usersButton.MouseEnter += Button_MouseEnter;
            usersButton.MouseLeave += Button_MouseLeave;
            salariesButton.MouseEnter += Button_MouseEnter;
            salariesButton.MouseLeave += Button_MouseLeave;
            performanceButton.MouseEnter += Button_MouseEnter;
            performanceButton.MouseLeave += Button_MouseLeave;
            calendarButton.MouseEnter += Button_MouseEnter;
            calendarButton.MouseLeave += Button_MouseLeave;

            usersButton.Click += (s, e) => ActivateButton(usersButton);
            salariesButton.Click += (s, e) => ActivateButton(salariesButton);
            performanceButton.Click += (s, e) => ActivateButton(performanceButton);
            calendarButton.Click += (s, e) => ActivateButton(calendarButton);

            dashboardButton.Click += (s, e) =>
            {
                bool toggle = !usersButton.Visible;

                usersButton.Visible = toggle;
                salariesButton.Visible = toggle;
                performanceButton.Visible = toggle;
                calendarButton.Visible = toggle;
                activeIndicator.Visible = toggle;
            };

            //CARD LAYOUT
            salariesPanel = new Panel
            {
                Location = new Point(293, 124),
                Size = new Size(519, 360),
                BackColor = Color.FromArgb(6, 95, 70)
            };

            performancePanel = new Panel
            {
                Location = new Point(293, 124),
                Size = new Size(519, 360),
                BackColor = Color.FromArgb(6, 95, 70)
            };

            PictureBox salariesBox = new PictureBox
            {
                Image = addUsersDesc.Image,
                SizeMode = addUsersDesc.SizeMode,
                Location = addUsersDesc.Location,
                Size = addUsersDesc.Size
            };

            PictureBox performanceBox = new PictureBox
            {
                Image = addUsersDesc.Image,
                SizeMode = addUsersDesc.SizeMode,
                Location = addUsersDesc.Location,
                Size = addUsersDesc.Size
            };

            salariesPanel.Controls.Add(salariesBox);
            performancePanel.Controls.Add(performanceBox);


            calendarPanel = new Panel
            {
                Location = new Point(293, 124),
                Size = new Size(519, 360),
                BackColor = Color.FromArgb(6, 95, 70)
            };
            DrawCalendar();

            //CARD LAYOUT - CALENDAR
            Label calendarTitle = new Label
            {
                Font = new Font("Inter", 14, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(20, 20),
                AutoSize = true
            };
            calendarPanel.Controls.Add(calendarTitle);

            string[] weekdays = {
                "Sun",
                "Mon",
                "Tue",
                "Wed",
                "Thu",
                "Fri",
                "Sat"
            };

            for (int i = 0; i < 7; i++)
            {
                Label dayLabel = new Label
                {
                    Text = weekdays[i],
                    Font = new Font("Inter", 11, FontStyle.Bold),
                    ForeColor = Color.White,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Size = new Size(60, 30),
                    Location = new Point(20 + i * 65, 60)
                };
                calendarPanel.Controls.Add(dayLabel);
            }

            usersButton.Click += (s, e) =>
            {
                ActivateButton(usersButton);
                ShowPanel(userDB);
            };

            salariesButton.Click += (s, e) =>
            {
                ActivateButton(salariesButton);
                ShowPanel(salariesPanel);
            };

            performanceButton.Click += (s, e) =>
            {
                ActivateButton(performanceButton);
                ShowPanel(performancePanel);
            };

            calendarButton.Click += (s, e) =>
            {
                ActivateButton(calendarButton);
                ShowPanel(calendarPanel);
            };

            Controls.Add(salariesPanel);
            Controls.Add(performancePanel);
            Controls.Add(calendarPanel);

            this.FormClosed += (s, e) => Application.Exit();

            ActivateButton(usersButton);
            ShowPanel(userDB);
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            dashboardPanel.Visible = !dashboardPanel.Visible;

        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(4, 78, 58);
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = dashboardPanel.BackColor;
        }

        private void ActivateButton(Button button)
        {
            activeIndicator.Visible = true;
            activeIndicator.Height = button.Height;
            activeIndicator.Top = button.Top;
            activeIndicator.Left = button.Left - activeIndicator.Width;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm lf = new LoginForm();
                lf.Show();
                this.Hide();
            }
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            searchLabel.Visible = string.IsNullOrWhiteSpace(searchBar.Text);
        }

        private void searchLabel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(searchBar.Text))
            {
                searchLabel.Visible = false;
            }
            else
            {
                searchLabel.Visible = true;
            }

            searchBar.Focus();
        }

        private void userSearchBox_TextChanged(object sender, EventArgs e)
        {
            userSearchLabel.Visible = string.IsNullOrWhiteSpace(userSearchBox.Text);
        }

        private void userSearchLabel_Click(object sender, EventArgs e)
        {
            userSearchBox.Focus();
        }

        private void ShowPanel(Panel target)
        {
            userDB.Visible = false;
            salariesPanel.Visible = false;
            performancePanel.Visible = false;
            calendarPanel.Visible = false;

            target.Visible = true;
        }
        public void DrawCalendar()
        {
            calendarPanel.Controls.Clear();

            Label title = new Label
            {
                Text = $"{new DateTime(currentYear, currentMonth, 1):MMMM yyyy}",
                Font = new Font("Inter", 14, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(180, 15),
                AutoSize = true
            };
            calendarPanel.Controls.Add(title);

            Button prevBtn = new Button
            {
                Text = "←",
                Font = new Font("Inter", 12, FontStyle.Bold),
                Size = new Size(40, 30),
                Location = new Point(20, 15),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                ForeColor = Color.FromArgb(6, 95, 70),
                Cursor = Cursors.Hand
            };

            prevBtn.Click += (s, e) =>
            {
                if (currentMonth == 1)
                {
                    currentMonth = 12;
                    currentYear--;
                }
                else currentMonth--;
                DrawCalendar();
            };
            calendarPanel.Controls.Add(prevBtn);

            Button nextBtn = new Button
            {
                Text = "→",
                Font = new Font("Inter", 12, FontStyle.Bold),
                Size = new Size(40, 30),
                Location = new Point(430, 15),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                ForeColor = Color.FromArgb(6, 95, 70),
                Cursor = Cursors.Hand
            };
            nextBtn.Click += (s, e) =>
            {
                if (currentMonth == 12)
                {
                    currentMonth = 1;
                    currentYear++;
                }
                else currentMonth++;
                DrawCalendar();
            };
            calendarPanel.Controls.Add(nextBtn);

            string[] weekdays = {
                "Sun",
                "Mon",
                "Tue",
                "Wed",
                "Thu",
                "Fri",
                "Sat"
            };
            for (int i = 0; i < 7; i++)
            {
                Label dayLabel = new Label
                {
                    Text = weekdays[i],
                    Font = new Font("Inter", 11, FontStyle.Bold),
                    ForeColor = Color.White,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Size = new Size(60, 30),
                    Location = new Point(20 + i * 65, 60)
                };
                calendarPanel.Controls.Add(dayLabel);
            }

            DateTime firstDay = new DateTime(currentYear, currentMonth, 1);
            int startDay = (int)firstDay.DayOfWeek;
            int daysInMonth = DateTime.DaysInMonth(currentYear, currentMonth);
            int dayCounter = 1;
            DateTime today = DateTime.Now;

            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    int cellIndex = row * 7 + col;
                    if (cellIndex < startDay || dayCounter > daysInMonth)
                        continue;

                    Label dayCell = new Label
                    {
                        Text = dayCounter.ToString(),
                        Font = new Font("Inter", 11),
                        TextAlign = ContentAlignment.MiddleCenter,
                        BackColor = Color.FromArgb(62, 180, 137),
                        ForeColor = Color.White,
                        Size = new Size(60, 40),
                        Location = new Point(20 + col * 65, 100 + row * 45)
                    };

                    if (dayCounter == today.Day && currentMonth == today.Month && currentYear == today.Year)
                    {
                        dayCell.Font = new Font("Inter", 11, FontStyle.Bold);
                        dayCell.BackColor = Color.White;
                        dayCell.ForeColor = Color.FromArgb(6, 95, 70);
                    }

                    calendarPanel.Controls.Add(dayCell);
                    dayCounter++;
                }
            }
        }
        private void addUser_Click(object sender, EventArgs e)
        {
            addUserPanel.Visible = true;
            addUserPanel.BringToFront();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HRAdminDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;Application Intent=ReadWrite;MultiSubnetFailover=False";

            string name = nameDB.Text.Trim();
            string phone = phoneDB.Text.Trim();
            byte hours = byte.Parse(hoursOfDutyTB.Text.Trim());
            string position = positionDB.Text.Trim();
            string status = "Online";

            string insertQuery = "INSERT INTO [dbo].[Table] ([Name], [Phone Number], [Hours of Duty], [Position], [Status]) " +
                                 "VALUES (@Name, @Phone, @Hours, @Position, @Status)";

            using (Microsoft.Data.SqlClient.SqlConnection conn = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            {
                using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Hours", hours);
                    cmd.Parameters.AddWithValue("@Position", position);
                    cmd.Parameters.AddWithValue("@Status", status);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }

            addUserPanel.Visible = false;
            LoadUserData(); 
        }


        private void addUserPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userDB_Paint(object sender, PaintEventArgs e)
        {

        }
        private Panel CreateCell(string text, int width)
        {
            Label label = new Label()
            {
                Text = text,
                Width = width,
                Height = 30,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(5, 5, 0, 0),
                Font = new Font("Inter", 8, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.Transparent
            };

            ContextMenuStrip contextMenu = new ContextMenuStrip();
            ToolStripMenuItem updateItem = new ToolStripMenuItem("Update");
            ToolStripMenuItem deleteItem = new ToolStripMenuItem("Delete");

            updateItem.Click += (s, e) =>
            {
                MessageBox.Show("Update option clicked for: " + text);
            };

            deleteItem.Click += (s, e) =>
            {
                MessageBox.Show("Delete option clicked for: " + text);
            };

            contextMenu.Items.Add(updateItem);
            contextMenu.Items.Add(deleteItem);

            label.ContextMenuStrip = contextMenu;

            Panel panel = new Panel()
            {
                Width = width,
                Height = 30,
                BackColor = Color.Transparent
            };

            panel.Controls.Add(label);

            return panel;
        }
        private Panel CreateStatusLabel(string status, Color color)
        {
            Label statusLabel = new Label()
            {
                Text = $"• {status}",
                AutoSize = false,
                Width = 40,
                Height = 20,
                Font = new Font("Inter", 6, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(10, 0),
                ForeColor = color,
                BackColor = Color.Transparent,
                Margin = new Padding(0)
            };

            ContextMenuStrip contextMenu = new ContextMenuStrip();
            ToolStripMenuItem updateItem = new ToolStripMenuItem("Update");
            ToolStripMenuItem deleteItem = new ToolStripMenuItem("Delete");

            updateItem.Click += (s, e) =>
            {
                MessageBox.Show("Update option clicked for status: " + status);
            };

            deleteItem.Click += (s, e) =>
            {
                MessageBox.Show("Delete option clicked for status: " + status);
            };

            contextMenu.Items.Add(updateItem);
            contextMenu.Items.Add(deleteItem);

            statusLabel.ContextMenuStrip = contextMenu;

            Panel wrapper = new Panel()
            {
                Width = 60,
                Height = 20,
                BackColor = Color.Transparent,
                Padding = new Padding(1)
            };

            wrapper.Controls.Add(statusLabel);

            wrapper.Paint += (s, e) =>
            {
                using (Pen pen = new Pen(color, 1.2f))
                {
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    e.Graphics.DrawRectangle(pen, 0, 0, wrapper.Width - 1, wrapper.Height - 1);
                }
            };

            return wrapper;
        }


        private void LoadUserData()
        {
            for (int i = userDB.Controls.Count - 1; i >= 0; i--)
            {
                if (userDB.Controls[i] != addUsersDesc)
                    userDB.Controls.RemoveAt(i);
            }

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HRAdminDB;Integrated Security=True";

            using (var conn = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            {
                string query = "SELECT * FROM [dbo].[Table]";
                using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn))
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        int rowIndex = 0;
                        int startY = addUsersDesc.Bottom;

                        while (reader.Read())
                        {
                            Panel userRowPanel = new Panel()
                            {
                                Height = 50,
                                Width = userDB.Width,
                                Location = new Point(0, startY + (rowIndex * 60)),
                                BackColor = (rowIndex % 2 == 0)
                                    ? ColorTranslator.FromHtml("#065F46")
                                    : ColorTranslator.FromHtml("#3EB489")
                            };

                            ContextMenuStrip contextMenu = new ContextMenuStrip();
                            ToolStripMenuItem updateItem = new ToolStripMenuItem("Update");
                            ToolStripMenuItem deleteItem = new ToolStripMenuItem("Delete");

                            updateItem.Click += (s, e) =>
                            {
                                MessageBox.Show("Update option clicked for user: " + reader["Name"]);
                            };

                            string name = reader["Name"].ToString();
                            string phone = reader["Phone Number"].ToString();
                            string hours = reader["Hours of Duty"].ToString();
                            string position = reader["Position"].ToString();

                            deleteItem.Click += (s, e) =>
                            {
                                DeleteUser(name, phone, hours, position);
                            };

                            contextMenu.Items.Add(updateItem);
                            contextMenu.Items.Add(deleteItem);

                            userRowPanel.ContextMenuStrip = contextMenu;

                            int yOffset = 10;

                            var nameCell = CreateCell(reader["Name"].ToString(), 120);
                            nameCell.Location = new Point(10, yOffset);
                            userRowPanel.Controls.Add(nameCell);

                            var phoneCell = CreateCell(reader["Phone Number"].ToString(), 120);
                            phoneCell.Location = new Point(125, yOffset);
                            userRowPanel.Controls.Add(phoneCell);

                            var hoursCell = CreateCell(reader["Hours of Duty"].ToString(), 60);
                            hoursCell.Location = new Point(250, yOffset);
                            userRowPanel.Controls.Add(hoursCell);

                            var positionCell = CreateCell(reader["Position"].ToString(), 60);
                            positionCell.Location = new Point(340, yOffset);
                            userRowPanel.Controls.Add(positionCell);

                            string status = reader["Status"].ToString();

                            Color rowBg = (rowIndex % 2 == 0)
                                ? ColorTranslator.FromHtml("#065F46")
                                : ColorTranslator.FromHtml("#3EB489");

                            Color contrastColor = rowIndex % 2 == 0
                                ? ColorTranslator.FromHtml("#22C55E")
                                : ColorTranslator.FromHtml("#065F46");

                            var statusWrapper = CreateStatusLabel(status, contrastColor);
                            statusWrapper.Location = new Point(445, yOffset + 8);
                            userRowPanel.Controls.Add(statusWrapper);

                            userDB.Controls.Add(userRowPanel);
                            userRowPanel.BringToFront();

                            rowIndex++;
                        }

                        userDB.AutoScrollMinSize = new Size(0, startY + (rowIndex * 60));
                    }
                }
            }
        }

        private void nameDBLabel_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            addUserPanel.Visible = false;
        }

        private void DeleteUser(string name, string phone, string hours, string position)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HRAdminDB;Integrated Security=True";

            string deleteQuery = "DELETE FROM [dbo].[Table] WHERE [Name] = @Name AND [Phone Number] = @Phone AND [Hours of Duty] = @Hours AND [Position] = @Position";

            using (var conn = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            {
                using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(deleteQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Hours", byte.Parse(hours));
                    cmd.Parameters.AddWithValue("@Position", position);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }

            LoadUserData();
        }

    }
}