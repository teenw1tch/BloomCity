using System;
using System.Linq;
using System.Windows.Forms;
using BloomCity.Models;

namespace BloomCity.Forms
{
    public partial class AuthorizationForm : Form
    {
        private DataContext db = new DataContext();

        public AuthorizationForm()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            linkLabelRegistration.BackColor = Color.Transparent;
        }

        private void linkLabelRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string email = textBoxLogin.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = db.Users.FirstOrDefault(u => u.Email == email && u.Password == password);

            if (user != null)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();

                if (user.Email == "admin@example.com")
                {
                    MessageBox.Show("Добро пожаловать, Администратор!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Неверный email или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
