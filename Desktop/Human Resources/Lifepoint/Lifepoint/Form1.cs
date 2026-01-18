using System.Drawing.Drawing2D;

namespace Lifepoint
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            tb_password.PasswordChar = '●';
            loginBtn.Region = new Region(GetRoundedRect(loginBtn.ClientRectangle, 4));

            loginBtn.MouseEnter += (s, e) =>
            {
                loginBtn.BackColor = Color.FromArgb(28, 164, 172);
                loginBtn.ForeColor = Color.White;
            };

            loginBtn.MouseLeave += (s, e) =>
            {
                loginBtn.BackColor = Color.White;
                loginBtn.ForeColor = Color.FromArgb(28, 164, 172);
            };

            loginBtn.MouseDown += (s, e) =>
            {
                loginBtn.BackColor = Color.FromArgb(16, 185, 129);
                loginBtn.ForeColor = Color.White;
            };

            loginBtn.MouseUp += (s, e) =>
            {
                loginBtn.BackColor = Color.FromArgb(28, 164, 172);
                loginBtn.ForeColor = Color.White;
            };

            this.FormClosed += (s, e) => Application.Exit();
        }

        private void loginBG_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (usernameLabel.Image != null)
            {
                using (var bmp = new Bitmap(usernameLabel.Image))
                {
                    usernameLabel.Image = new Bitmap(bmp, new Size(16, 16));
                }
            }

            if (passwordLabel.Image != null)
            {
                using (var bmp = new Bitmap(passwordLabel.Image))
                {
                    passwordLabel.Image = new Bitmap(bmp, new Size(16, 16));
                }
            }
        }

        private GraphicsPath GetRoundedRect(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_username.Text))
            {
                usernameLabel.Visible = false;
            }
            else
            {
                usernameLabel.Visible = true;
            }
        }
        private void passwordLabel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_password.Text))
            {
                passwordLabel.Visible = false;
            }
            else
            {
                passwordLabel.Visible = true;
            }
        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {
            usernameLabel.Visible = string.IsNullOrWhiteSpace(tb_username.Text);
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            passwordLabel.Visible = string.IsNullOrWhiteSpace(tb_password.Text);
        }

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register r = new Register();
            r.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (tb_username.Text == "admin" && tb_password.Text == "admin")
            {
                Admin a = new Admin();
                this.Hide();
                a.Show();
                
            }

            else if (tb_password.Text != "admin") {
                MessageBox.Show("Password incorrect, try again.");
            }
        }
    }
}
