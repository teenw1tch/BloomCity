using BloomCity.Models;
using Microsoft.EntityFrameworkCore;

namespace BloomCity.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            Load += MainForm_Load;
            comboBoxSort.SelectedIndexChanged += ComboBoxSort_SelectedIndexChanged;
            comboBoxCategories.SelectedIndexChanged += ComboBoxCategories_SelectedIndexChanged;
            buttonProfile.Click += buttonProfile_Click;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBoxSort.Items.AddRange(new string[]
            {
                "Цена: по возрастанию",
                "Цена: по убыванию",
                "Название: А-Я",
                "Название: Я-А"
            });
            comboBoxSort.SelectedIndex = 0;

            LoadCategories();
            DisplayProducts();
        }

        private void LoadCategories()
        {
            using (var context = new DataContext())
            {
                var categories = context.Categories
                                        .Select(c => c.Name)
                                        .ToList();

                comboBoxCategories.Items.Add("Все категории");
                comboBoxCategories.Items.AddRange(categories.ToArray());
                comboBoxCategories.SelectedIndex = 0;
            }
        }

        private List<Product> GetProducts()
        {
            using (var context = new DataContext())
            {
                return context.Products
                              .Include(p => p.Category)
                              .ToList();
            }
        }

        private void DisplayProducts(string sortBy = "", string category = "Все категории")
        {
            flowLayoutPanelProducts.Controls.Clear();
            flowLayoutPanelProducts.BackColor = Color.LavenderBlush;

            var products = GetProducts();

            if (category != "Все категории")
            {
                products = products
                    .Where(p => p.Category != null && p.Category.Name == category)
                    .ToList();
            }

            switch (sortBy)
            {
                case "Цена: по возрастанию":
                    products = products.OrderBy(p => p.Price).ToList();
                    break;
                case "Цена: по убыванию":
                    products = products.OrderByDescending(p => p.Price).ToList();
                    break;
                case "Название: А-Я":
                    products = products.OrderBy(p => p.Name).ToList();
                    break;
                case "Название: Я-А":
                    products = products.OrderByDescending(p => p.Name).ToList();
                    break;
            }

            foreach (var product in products)
            {
                var panel = new Panel
                {
                    Width = 246,
                    Height = 300,
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.LavenderBlush
                };

                var pictureBox = new PictureBox
                {
                    Width = 246,
                    Height = 186,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    ImageLocation = product.ImagePath,
                    BackColor = Color.LavenderBlush
                };

                var labelProductName = new Label
                {
                    Text = product.Name,
                    AutoSize = true,
                    Font = new Font("Verdana", 7.8f, FontStyle.Bold),
                    ForeColor = SystemColors.ActiveCaption
                };

                var labelProductPrice = new Label
                {
                    Text = string.Format("{0:C}", product.Price),
                    AutoSize = true,
                    Font = new Font("Verdana", 7.8f, FontStyle.Regular),
                    ForeColor = SystemColors.ActiveCaption
                };

                var buttonAddToCart = new Button
                {
                    Text = "В корзину!",
                    Size = new Size(160, 37),
                    BackColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Verdana", 7.8f, FontStyle.Bold),
                    ForeColor = SystemColors.ActiveCaption
                };

                buttonAddToCart.Click += (sender, e) => AddToCart(product);

                panel.Controls.Add(pictureBox);
                panel.Controls.Add(labelProductName);
                panel.Controls.Add(labelProductPrice);
                panel.Controls.Add(buttonAddToCart);

                labelProductName.Location = new Point((panel.Width - labelProductName.Width) / 2, pictureBox.Bottom + 5);
                labelProductPrice.Location = new Point((panel.Width - labelProductPrice.Width) / 2, labelProductName.Bottom + 5);
                buttonAddToCart.Location = new Point((panel.Width - buttonAddToCart.Width) / 2, labelProductPrice.Bottom + 10);

                flowLayoutPanelProducts.Controls.Add(panel);
            }
        }

        private void ComboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCategory = comboBoxCategories.SelectedItem != null
                ? comboBoxCategories.SelectedItem.ToString()
                : "Все категории";

            DisplayProducts(comboBoxSort.SelectedItem.ToString(), selectedCategory);
        }

        private void ComboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedSort = comboBoxSort.SelectedItem != null
                ? comboBoxSort.SelectedItem.ToString()
                : "";

            var selectedCategory = comboBoxCategories.SelectedItem != null
                ? comboBoxCategories.SelectedItem.ToString()
                : "Все категории";

            DisplayProducts(selectedSort, selectedCategory);
        }

        private void AddToCart(Product product)
        {
            MessageBox.Show($"Товар '{product.Name}' добавлен в корзину.", "Корзина", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            int userId = GetCurrentUserId();

            var personalAccForm = new PersonalAccForm(userId);
            personalAccForm.Show();

            this.Close();
        }

        private int GetCurrentUserId()
        {

            return 1;
        }

        private void buttonCart_Click(object sender, EventArgs e)
        {
            var cartForm = new CartForm();
            cartForm.Show();
            this.Close();
        }
    }
}
