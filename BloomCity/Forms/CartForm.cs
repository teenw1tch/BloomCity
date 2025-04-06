using BloomCity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BloomCity.Forms
{
    public partial class CartForm : Form
    {
        private readonly DataContext db = new DataContext();
        private List<OrderDetail> CartItems;
        private int CurrentUserId;

        public List<OrderDetail> UpdatedCartItems => CartItems;

        public CartForm(int userId, List<OrderDetail> cartItems)
        {
            InitializeComponent();
            this.CurrentUserId = userId;
            this.CartItems = cartItems ?? new List<OrderDetail>();
            Load += CartForm_Load;
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            dataGridViewCart.DataSource = null;
            dataGridViewCart.AutoGenerateColumns = false;

            dataGridViewCart.Columns.Clear();

            dataGridViewCart.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductName",
                HeaderText = "Название"
            });

            dataGridViewCart.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Quantity",
                HeaderText = "Количество"
            });

            dataGridViewCart.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SubTotal",
                HeaderText = "Сумма"
            });

            var displayItems = CartItems.Select(i => new
            {
                ProductName = i.Product?.Name ?? "—",
                Quantity = i.Quantity,
                SubTotal = i.SubTotal
            }).ToList();

            dataGridViewCart.DataSource = displayItems;
        }

        private void InitializeDataGridView()
        {
            dataGridViewCart.ColumnCount = 4;
            dataGridViewCart.Columns[0].Name = "Название";
            dataGridViewCart.Columns[1].Name = "Наличие";
            dataGridViewCart.Columns[2].Name = "Количество";
            dataGridViewCart.Columns[3].Name = "Общая стоимость";

            dataGridViewCart.Columns[1].Width = 80;
            dataGridViewCart.Columns[2].Width = 80;
            dataGridViewCart.Columns[3].Width = 120;

            dataGridViewCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCart.MultiSelect = false;
        }

        private void LoadCart()
        {
            dataGridViewCart.Rows.Clear();
            decimal totalSum = 0;

            foreach (var item in CartItems)
            {
                decimal itemTotal = item.Quantity * item.Product.Price;
                totalSum += itemTotal;

                dataGridViewCart.Rows.Add(item.Product.Name,
                                          item.Product.InStock ? "Да" : "Нет",
                                          item.Quantity,
                                          itemTotal);
            }

            labelSum.Text = $"Общая сумма: {totalSum} руб.";
        }

        private void LoadUserData()
        {
            var user = db.Users.FirstOrDefault(u => u.Id == CurrentUserId);
            if (user != null)
            {
                textBoxFullName.Text = user.FullName;
                maskedTextBoxPhone.Text = user.Phone;
                textBoxEmail.Text = user.Email;
            }
        }

        private void LoadAddresses()
        {
            var addresses = db.Addresses.Where(a => a.UserId == CurrentUserId).ToList();
            comboBoxAddress.DataSource = addresses;
            comboBoxAddress.DisplayMember = "Street";
            comboBoxAddress.ValueMember = "Id";
        }

        private void UpdateTotalSum()
        {
            decimal totalSum = dataGridViewCart.Rows.Cast<DataGridViewRow>()
                .Where(row => row.Cells[3].Value != null)
                .Sum(row => Convert.ToDecimal(row.Cells[3].Value));

            labelSum.Text = $"Общая сумма: {totalSum} руб.";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (dataGridViewCart.SelectedRows.Count == 0) return;
            var row = dataGridViewCart.SelectedRows[0];
            string productName = row.Cells[0].Value.ToString();

            int quantity = Convert.ToInt32(row.Cells[2].Value) + 1;
            row.Cells[2].Value = quantity;
            row.Cells[3].Value = quantity * GetPrice(productName);

            var item = CartItems.FirstOrDefault(i => i.Product.Name == productName);
            if (item != null) item.Quantity = quantity;

            UpdateTotalSum();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (dataGridViewCart.SelectedRows.Count == 0) return;
            var row = dataGridViewCart.SelectedRows[0];
            string productName = row.Cells[0].Value.ToString();
            int quantity = Convert.ToInt32(row.Cells[2].Value);

            var item = CartItems.FirstOrDefault(i => i.Product.Name == productName);

            if (quantity > 1)
            {
                row.Cells[2].Value = --quantity;
                row.Cells[3].Value = quantity * GetPrice(productName);
                if (item != null) item.Quantity = quantity;
            }
            else
            {
                dataGridViewCart.Rows.Remove(row);
                if (item != null) CartItems.Remove(item);
            }

            UpdateTotalSum();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewCart.SelectedRows.Count > 0)
            {
                string productName = dataGridViewCart.SelectedRows[0].Cells[0].Value.ToString();
                dataGridViewCart.Rows.Remove(dataGridViewCart.SelectedRows[0]);

                var item = CartItems.FirstOrDefault(i => i.Product.Name == productName);
                if (item != null) CartItems.Remove(item);

                UpdateTotalSum();
            }
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            dataGridViewCart.Rows.Clear();
            CartItems.Clear();
            labelSum.Text = "Общая сумма: 0 руб.";
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFullName.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBoxPhone.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                (string.IsNullOrWhiteSpace(textBoxAddress.Text) && comboBoxAddress.SelectedItem == null) ||
                dataGridViewCart.Rows.Count == 0)
            {
                MessageBox.Show("Заполните все поля и добавьте товары в корзину!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dateTimePicker.Value.Date <= DateTime.Now.Date)
            {
                MessageBox.Show("Дата доставки должна быть не раньше завтрашнего дня!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedAddress = !string.IsNullOrWhiteSpace(textBoxAddress.Text)
                ? textBoxAddress.Text
                : comboBoxAddress.Text;

            var address = db.Addresses.FirstOrDefault(a => a.Street == selectedAddress);
            if (address == null)
            {
                MessageBox.Show("Выбранный адрес не найден в базе данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var delivery = new Delivery
            {
                CourierName = "Курьер службы",
                Status = "Ожидает отправки",
                EstimatedDeliveryDate = dateTimePicker.Value.Date
            };

            db.Deliveries.Add(delivery);
            db.SaveChanges();

            var newOrder = new Order
            {
                UserId = CurrentUserId,
                OrderDate = DateTime.Now,
                TotalAmount = GetTotalSum(),
                AddressId = address.Id,
                DeliveryId = delivery.Id
            };

            db.Orders.Add(newOrder);
            db.SaveChanges();

            MessageBox.Show("Ваш заказ принят!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridViewCart.Rows.Clear();
            CartItems.Clear();
            labelSum.Text = "Общая сумма: 0 руб.";
        }

        private decimal GetPrice(string productName)
        {
            return db.Products.FirstOrDefault(p => p.Name == productName)?.Price ?? 0;
        }

        private decimal GetTotalSum()
        {
            return dataGridViewCart.Rows.Cast<DataGridViewRow>()
                .Where(row => row.Cells[3].Value != null)
                .Sum(row => Convert.ToDecimal(row.Cells[3].Value));
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm(CurrentUserId, CartItems);
            mainForm.Show();
            this.Close();
        }
    }
}
