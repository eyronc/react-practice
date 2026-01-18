using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lifepoint
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();
        }
        private void Register_Load(object sender, EventArgs e)
        {
            tb_password.UseSystemPasswordChar = true;
            tb_confirmPassword.UseSystemPasswordChar = true;
        }
        private void loginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void tb_fullname_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_fullname.Text))
            {
                fullNameLabel.Visible = false;
            }
            else
            {
                fullNameLabel.Visible = true;
            }
        }

        private void tb_username_TextChanged(object sender, EventArgs e)
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

        private void tb_password_TextChanged(object sender, EventArgs e)
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

        private void tb_confirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_confirmPassword.Text))
            {
                confirmPasswordLabel.Visible = false;
            }
            else
            {
                confirmPasswordLabel.Visible = true;
            }
        }

        private void fullNameLabel_Click(object sender, EventArgs e)
        {
            fullNameLabel.Visible = string.IsNullOrWhiteSpace(tb_fullname.Text);
        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {
            usernameLabel.Visible = string.IsNullOrWhiteSpace(tb_username.Text);
        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {
            passwordLabel.Visible = string.IsNullOrWhiteSpace(tb_password.Text);
        }

        private void confirmPasswordLabel_Click(object sender, EventArgs e)
        {
            confirmPasswordLabel.Visible = string.IsNullOrWhiteSpace(tb_confirmPassword.Text);
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_fullname.Text) ||
            string.IsNullOrWhiteSpace(tb_username.Text) ||
            string.IsNullOrWhiteSpace(tb_password.Text) ||
            string.IsNullOrWhiteSpace(tb_confirmPassword.Text) ||
            !cb_TermsOfService.Checked)
            {
                MessageBox.Show("Please complete all fields and agree to the Terms of Service.", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tb_password.Text != tb_confirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
