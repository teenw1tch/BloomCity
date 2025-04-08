using BloomCity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
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
            SetTransparentLabels();
        }

        public CartForm(int currentUserId)
        {
            InitializeComponent();
            CurrentUserId = currentUserId;
            this.CartItems = new List<OrderDetail>();
            Load += CartForm_Load;
            SetTransparentLabels();
        }

        private void SetTransparentLabels()
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            labelSum.BackColor = Color.Transparent;
            labelAddress.BackColor = Color.Transparent;
            labelDate.BackColor = Color.Transparent;
            labelEmail.BackColor = Color.Transparent;
            labelFullName.BackColor = Color.Transparent;
            labelPhone.BackColor = Color.Transparent;
            labelPickAddress.BackColor = Color.Transparent;
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            dataGridViewCart.AutoGenerateColumns = false;
            dataGridViewCart.Columns.Clear();

            dataGridViewCart.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductName",
                HeaderText = "Название",
                ReadOnly = true
            });

            dataGridViewCart.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Quantity",
                HeaderText = "Количество"
            });

            dataGridViewCart.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UnitPrice",
                HeaderText = "Цена единицы",
                ReadOnly = true
            });

            dataGridViewCart.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalPrice",
                HeaderText = "Общая стоимость",
                ReadOnly = true
            });

            comboBoxAddress.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCity.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCity.Items.Clear();
            comboBoxCity.Items.Add("Воронеж");
            comboBoxCity.SelectedIndex = 0;

            LoadUserData();
            LoadAddresses();
            LoadCart();
        }

        private void LoadCart()
        {
            dataGridViewCart.DataSource = null;
            dataGridViewCart.DataSource = new BindingSource(new BindingList<CartDisplayItem>(GetDisplayItems()), null);
            UpdateTotalSum();
        }

        private List<CartDisplayItem> GetDisplayItems()
        {
            return CartItems.Select(i => new CartDisplayItem
            {
                ProductName = i.Product?.Name ?? "—",
                Quantity = i.Quantity,
                UnitPrice = i.Product?.Price ?? 0
            }).ToList();
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

            var firstAddress = db.Addresses.FirstOrDefault(a => a.UserId == CurrentUserId);
            if (firstAddress != null)
            {
                textBoxPostCode.Text = firstAddress.PostalCode;
            }
        }

        private void LoadAddresses()
        {
            var addresses = db.Addresses.Where(a => a.UserId == CurrentUserId).ToList();
            comboBoxAddress.DataSource = addresses;
            comboBoxAddress.DisplayMember = "Street";
            comboBoxAddress.ValueMember = "Id";

            comboBoxAddress.SelectedIndexChanged += (s, e) =>
            {
                if (comboBoxAddress.SelectedItem is Address selectedAddress)
                {
                    textBoxPostCode.Text = selectedAddress.PostalCode;
                }
            };
        }

        private void UpdateTotalSum()
        {
            labelSum.Text = $"Общая сумма: {CartItems.Sum(i => (i.Product?.Price ?? 0) * i.Quantity):0.00} руб.";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (dataGridViewCart.SelectedRows.Count == 0) return;

            string productName = dataGridViewCart.SelectedRows[0].Cells[0].Value.ToString();
            var item = CartItems.FirstOrDefault(i => i.Product?.Name == productName);
            if (item != null)
            {
                item.Quantity++;
                LoadCart();
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (dataGridViewCart.SelectedRows.Count == 0) return;

            string productName = dataGridViewCart.SelectedRows[0].Cells[0].Value.ToString();
            var item = CartItems.FirstOrDefault(i => i.Product?.Name == productName);
            if (item != null)
            {
                if (item.Quantity > 1)
                {
                    item.Quantity--;
                }
                else
                {
                    CartItems.Remove(item);
                }
                LoadCart();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewCart.SelectedRows.Count == 0) return;

            string productName = dataGridViewCart.SelectedRows[0].Cells[0].Value.ToString();
            var item = CartItems.FirstOrDefault(i => i.Product?.Name == productName);
            if (item != null)
            {
                CartItems.Remove(item);
                LoadCart();
            }
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Удалить все товары из корзины?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                CartItems.Clear();
                LoadCart();
            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFullName.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBoxPhone.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                (string.IsNullOrWhiteSpace(textBoxStreet.Text) && comboBoxAddress.SelectedItem == null) ||
                string.IsNullOrWhiteSpace(textBoxPostCode.Text) ||
                CartItems.Count == 0)
            {
                MessageBox.Show("Заполните все поля и добавьте товары в корзину!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dateTimePicker.Value.Date <= DateTime.Now.Date)
            {
                MessageBox.Show("Дата доставки должна быть не раньше завтрашнего дня!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedAddress = !string.IsNullOrWhiteSpace(textBoxStreet.Text)
                ? textBoxStreet.Text
                : comboBoxAddress.Text;

            var address = db.Addresses.FirstOrDefault(a => a.Street == selectedAddress);

            if (address == null && !string.IsNullOrWhiteSpace(textBoxStreet.Text))
            {
                address = new Address
                {
                    Street = textBoxStreet.Text,
                    City = comboBoxCity.SelectedItem?.ToString() ?? "Воронеж",
                    PostalCode = textBoxPostCode.Text,
                    UserId = CurrentUserId
                };
                db.Addresses.Add(address);
                db.SaveChanges();
            }

            if (address == null)
            {
                MessageBox.Show("Выбранный адрес не найден и не был создан!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                TotalAmount = CartItems.Sum(i => (i.Product?.Price ?? 0) * i.Quantity),
                AddressId = address.Id
            };

            db.Orders.Add(newOrder);
            db.SaveChanges();

            foreach (var cartItem in CartItems)
            {
                var orderDetail = new OrderDetail
                {
                    OrderId = newOrder.Id,
                    ProductId = cartItem.Product?.Id ?? 0,
                    Quantity = cartItem.Quantity,
                    SubTotal = (cartItem.Product?.Price ?? 0) * cartItem.Quantity,
                    DeliveryId = delivery.Id
                };

                db.OrderDetails.Add(orderDetail);
            }

            db.SaveChanges();

            MessageBox.Show("Ваш заказ принят!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CartItems.Clear();
            LoadCart();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm(CurrentUserId, CartItems);
            mainForm.Show();
            this.Close();
        }

        private class CartDisplayItem
        {
            public string ProductName { get; set; }
            public int Quantity { get; set; }
            public decimal UnitPrice { get; set; }
            public decimal TotalPrice => Quantity * UnitPrice;
        }
    }
}
