using BloomCity.Models;

namespace BloomCity.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            flowLayoutPanelProducts.BackColor = Color.LavenderBlush;
            DisplayProducts();
        }

        private List<Product> GetProducts()
        {
            using (var context = new DataContext())
            {
                return context.Products.ToList();
            }
        }

        private void DisplayProducts()
        {
            flowLayoutPanelProducts.Controls.Clear();

            var products = GetProducts();

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
                    AutoSize = false,
                    Width = 236,
                    Height = 30,
                    Font = new Font("Verdana", 7.8F, FontStyle.Bold),
                    ForeColor = SystemColors.ActiveCaption,
                    Location = new Point(5, pictureBox.Bottom + 5),
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.LavenderBlush 
                };

                var labelProductPrice = new Label
                {
                    Text = $"{product.Price:C}",
                    AutoSize = false,
                    Width = 236,
                    Height = 25,
                    Font = new Font("Verdana", 7.8F, FontStyle.Regular),
                    ForeColor = SystemColors.ActiveCaption,
                    Location = new Point(5, labelProductName.Bottom + 5),
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.LavenderBlush 
                };

                var buttonAddToCart = new Button
                {
                    Text = "В корзину!",
                    Size = new Size(160, 37),
                    Location = new Point((panel.Width - 160) / 2, labelProductPrice.Bottom + 10), 
                    BackColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Verdana", 7.8F, FontStyle.Bold),
                    ForeColor = SystemColors.ActiveCaption
                };
                buttonAddToCart.FlatAppearance.BorderSize = 1;

                buttonAddToCart.Click += (sender, e) => AddToCart(product);

                panel.Controls.Add(pictureBox);
                panel.Controls.Add(labelProductName);
                panel.Controls.Add(labelProductPrice);
                panel.Controls.Add(buttonAddToCart);

                flowLayoutPanelProducts.Controls.Add(panel);
            }
        }

        private void AddToCart(Product product)
        {
            MessageBox.Show($"Товар '{product.Name}' добавлен в корзину.", "Корзина", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
