namespace BloomCity.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            buttonProfile = new Button();
            buttonCart = new Button();
            label2 = new Label();
            textBoxPhone = new TextBox();
            buttonSearch = new Button();
            flowLayoutPanelProducts = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // buttonProfile
            // 
            buttonProfile.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonProfile.ForeColor = SystemColors.ActiveCaption;
            buttonProfile.Location = new Point(975, 1);
            buttonProfile.Name = "buttonProfile";
            buttonProfile.Size = new Size(160, 37);
            buttonProfile.TabIndex = 5;
            buttonProfile.Text = "Личный кабинет";
            buttonProfile.UseVisualStyleBackColor = true;
            // 
            // buttonCart
            // 
            buttonCart.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCart.ForeColor = SystemColors.ActiveCaption;
            buttonCart.Location = new Point(975, 44);
            buttonCart.Name = "buttonCart";
            buttonCart.Size = new Size(160, 37);
            buttonCart.TabIndex = 6;
            buttonCart.Text = "Корзина";
            buttonCart.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(370, 8);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 8;
            label2.Text = "Поиск:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Font = new Font("Verdana", 7.8F);
            textBoxPhone.ForeColor = SystemColors.ActiveCaption;
            textBoxPhone.Location = new Point(460, 8);
            textBoxPhone.Multiline = true;
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(265, 26);
            textBoxPhone.TabIndex = 9;
            // 
            // buttonSearch
            // 
            buttonSearch.Image = Properties.Resources.SearchIcon1;
            buttonSearch.Location = new Point(731, 0);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(47, 44);
            buttonSearch.TabIndex = 10;
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelProducts
            // 
            flowLayoutPanelProducts.AutoScroll = true;
            flowLayoutPanelProducts.Location = new Point(424, 195);
            flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            flowLayoutPanelProducts.Size = new Size(250, 125);
            flowLayoutPanelProducts.TabIndex = 11;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background__freepik_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1136, 629);
            Controls.Add(flowLayoutPanelProducts);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxPhone);
            Controls.Add(label2);
            Controls.Add(buttonCart);
            Controls.Add(buttonProfile);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главная страница";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonProfile;
        private Button buttonCart;
        private Label label2;
        private TextBox textBoxPhone;
        private Button buttonSearch;
        private FlowLayoutPanel flowLayoutPanelProducts;
    }
}