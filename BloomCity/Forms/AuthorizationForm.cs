using System;
using System.Linq;
using System.Text.RegularExpressions;
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
            checkBoxShowPassword.BackColor = Color.Transparent;

            textBoxPassword.PasswordChar = '*';
        }

        private void CheckBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.PasswordChar = '\0'; 
            }
            else
            {
                textBoxPassword.PasswordChar = '*'; 
            }
        }

        private void TextBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789@._-";
            if (!validChars.Contains(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void TextBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(e.KeyChar.ToString(), "[а-яА-Я]"))
            {
                e.Handled = true;
            }
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
