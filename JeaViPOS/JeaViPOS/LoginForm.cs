using System;
using System.Linq;
using System.Windows.Forms;

namespace JeaViPOS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Theme.StyleInputs(this);
            Theme.StylePrimary(btnLogin);
            Theme.SetPlaceholder(txtUsername, "Enter your username");
            Theme.SetPlaceholder(txtPassword, "Enter your password");
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShow.Checked;
        }

        private void LoginClicked(object sender, EventArgs e)
        {
            var username = txtUsername.Text.Trim();
            if (username.Length == 0 || txtPassword.Text.Length == 0)
            {
                lblStatus.Text = "Enter your username and password.";
                return;
            }

            try
            {
                using (var db = new VillacortaDataContext())
                {
                    var user = db.Users.SingleOrDefault(u => u.Username == username);

                    if (user == null || !user.IsActive ||
                        !string.Equals(Security.Hash(user.Salt, txtPassword.Text), user.PasswordHash,
                                       StringComparison.OrdinalIgnoreCase))
                    {
                        lblStatus.Text = "Invalid credentials or inactive user.";
                        return;
                    }

                    user.LastLoginAt = DateTime.Now;
                    db.SubmitChanges();

                    Session.UserId = user.UserId;
                    Session.FullName = user.FullName;
                    Session.RoleName = user.Role.RoleName;
                }

                lblStatus.Text = "";
                Hide();
                using (var main = new MainForm()) main.ShowDialog(this);
                Session.Clear();
                txtPassword.Clear();
                chkShow.Checked = false;
                Show();
                txtUsername.Focus();
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Unable to connect to the database.";
                MessageBox.Show(ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}