using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BloomCity.Models;

namespace BloomCity.Forms
{
    public partial class RegistrationForm : Form
    {
        private DataContext db = new DataContext();

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            string fullName = textBoxFullName.Text.Trim();
            string phone = maskedTextBoxPhone.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string password = textBoxPassword.Text;
            string repeatPassword = textBoxRepeatPassword.Text;

            if (string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(repeatPassword))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != repeatPassword)
            {
                MessageBox.Show("Пароли не совпадают!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Введите корректный email!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (db.Users.Any(u => u.Email == email))
            {
                MessageBox.Show("Пользователь с таким Email уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User newUser = new User
            {
                FullName = fullName,
                Phone = phone,
                Email = email,
                Password = password,
                TotalSpent = 0
            };

            db.Users.Add(newUser);
            db.SaveChanges();

            MessageBox.Show("Регистрация успешна!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }


        private void textBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;

            if (!char.IsControl(key) &&
                !(char.IsLetterOrDigit(key) || key == '@' || key == '.' || key == '-' || key == '_'))
            {
                e.Handled = true;
            }

            // Блокируем ввод русских символов
            if (key >= 'а' && key <= 'я' || key >= 'А' && key <= 'Я')
            {
                e.Handled = true;
            }
        }

        private void textBoxFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;

            // Разрешаем только русские буквы, пробелы и дефис
            if (!char.IsControl(key) && !((key >= 'А' && key <= 'Я') || (key >= 'а' && key <= 'я') || key == ' ' || key == '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Блокируем русские буквы
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'А' && e.KeyChar <= 'Я'))
            {
                e.Handled = true;
            }
        }

        private void textBoxRepeatPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Блокируем русские буквы
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'А' && e.KeyChar <= 'Я'))
            {
                e.Handled = true;
            }
        }
    }
}
