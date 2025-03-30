using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BloomCity.Models;
using System.Drawing;

namespace BloomCity.Forms
{
    public partial class PersonalAccForm : Form
    {
        private int currentUserId;

        public PersonalAccForm(int userId)
        {
            InitializeComponent();
            labelWelcome.BackColor = Color.Transparent;
            labelFullName.BackColor = Color.Transparent;
            labelPhone.BackColor = Color.Transparent;
            labelEmail.BackColor = Color.Transparent;
            labelChangePsswd.BackColor = Color.Transparent;
            labelNewPsswd.BackColor = Color.Transparent;
            labelRepeatNewPsswd.BackColor = Color.Transparent;
            labelHistory.BackColor = Color.Transparent;
            currentUserId = userId;
            LoadUserData();
            LoadOrderHistory();
        }

        private void LoadUserData()
        {
            using (var context = new DataContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Id == currentUserId);
                if (user != null)
                {
                    textBoxFullName.Text = user.FullName;
                    maskedTextBoxPhone.Text = user.Phone;
                    textBoxEmail.Text = user.Email;
                }
                else
                {
                    MessageBox.Show("Пользователь не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadOrderHistory()
        {
            using (var context = new DataContext())
            {
                var orders = context.Orders
                    .Where(o => o.UserId == currentUserId)
                    .Select(o => new
                    {
                        OrderDetails = string.Join(", ", o.OrderDetails.Select(od => od.Product.Name + " (" + od.Quantity + " шт.)")),
                        o.TotalAmount,
                        o.OrderDate,
                        DeliveryAddress = o.Address.Street + ", " + o.Address.City + ", " + o.Address.PostalCode,
                        o.Delivery.Status
                    })
                    .ToList();

                dataGridViewHistory.DataSource = orders;

                dataGridViewHistory.DefaultCellStyle.Font = new Font("Verdana", 7.8f);
                dataGridViewHistory.DefaultCellStyle.ForeColor = Color.FromArgb(0, 120, 215);  // Цвет активного окна

                dataGridViewHistory.Columns["OrderDetails"].DisplayIndex = 0;
                dataGridViewHistory.Columns["TotalAmount"].DisplayIndex = 1;
                dataGridViewHistory.Columns["OrderDate"].DisplayIndex = 2;
                dataGridViewHistory.Columns["DeliveryAddress"].DisplayIndex = 3;
                dataGridViewHistory.Columns["Status"].DisplayIndex = 4;

                dataGridViewHistory.Columns["OrderDetails"].HeaderText = "Состав заказа";
                dataGridViewHistory.Columns["TotalAmount"].HeaderText = "Сумма заказа";
                dataGridViewHistory.Columns["OrderDate"].HeaderText = "Дата заказа";
                dataGridViewHistory.Columns["DeliveryAddress"].HeaderText = "Адрес доставки";
                dataGridViewHistory.Columns["Status"].HeaderText = "Статус заказа";
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFullName.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBoxPhone.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(textBoxEmail.Text))
            {
                MessageBox.Show("Введите корректный email!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new DataContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Id == currentUserId);
                if (user != null)
                {
                    user.FullName = textBoxFullName.Text;
                    user.Phone = maskedTextBoxPhone.Text;
                    user.Email = textBoxEmail.Text;
                    context.SaveChanges();
                    MessageBox.Show("Изменения сохранены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Пользователь не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonChangePsswd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxOldPsswd.Text) ||
                string.IsNullOrWhiteSpace(textBoxNewPsswd.Text) ||
                string.IsNullOrWhiteSpace(textBoxRepeatNewPsswd.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля для изменения пароля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new DataContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Id == currentUserId);
                if (user != null)
                {
                    if (user.Password != textBoxOldPsswd.Text)
                    {
                        MessageBox.Show("Неверный старый пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (textBoxNewPsswd.Text != textBoxRepeatNewPsswd.Text)
                    {
                        MessageBox.Show("Пароли не совпадают! Попробуйте еще раз.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    user.Password = textBoxNewPsswd.Text;
                    context.SaveChanges();
                    MessageBox.Show("Ваш пароль успешно изменен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Пользователь не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxOldPsswd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsRussianLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxNewPsswd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsRussianLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxRepeatNewPsswd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsRussianLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;

            if (!char.IsControl(key) && !(char.IsLetterOrDigit(key) || key == '@' || key == '.' || key == '-' || key == '_'))
            {
                e.Handled = true;
            }

            if (key >= 'а' && key <= 'я' || key >= 'А' && key <= 'Я')
            {
                e.Handled = true;
            }
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool IsRussianLetter(char c)
        {
            return (c >= 'А' && c <= 'Я') || (c >= 'а' && c <= 'я');
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите выйти из аккаунта?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                AuthorizationForm authForm = new AuthorizationForm();
                authForm.Show();
                this.Close();
            }
        }
    }
}
