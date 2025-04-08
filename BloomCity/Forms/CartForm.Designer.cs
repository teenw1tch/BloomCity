namespace BloomCity.Forms
{
    partial class CartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartForm));
            label1 = new Label();
            dataGridViewCart = new DataGridView();
            buttonBack = new Button();
            buttonBuy = new Button();
            buttonPlus = new Button();
            buttonMinus = new Button();
            buttonDelete = new Button();
            buttonDeleteAll = new Button();
            label2 = new Label();
            labelSum = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            labelPhone = new Label();
            maskedTextBoxPhone = new MaskedTextBox();
            textBoxFullName = new TextBox();
            labelFullName = new Label();
            labelAddress = new Label();
            textBoxStreet = new TextBox();
            labelPickAddress = new Label();
            comboBoxAddress = new ComboBox();
            dateTimePicker = new DateTimePicker();
            labelDate = new Label();
            comboBoxCity = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            textBoxPostCode = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(352, -1);
            label1.Name = "label1";
            label1.Size = new Size(426, 34);
            label1.TabIndex = 1;
            label1.Text = "Товары в Вашей корзине";
            // 
            // dataGridViewCart
            // 
            dataGridViewCart.BackgroundColor = Color.LavenderBlush;
            dataGridViewCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCart.Location = new Point(83, 36);
            dataGridViewCart.Name = "dataGridViewCart";
            dataGridViewCart.RowHeadersWidth = 51;
            dataGridViewCart.Size = new Size(964, 173);
            dataGridViewCart.TabIndex = 2;
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Verdana", 12F);
            buttonBack.ForeColor = SystemColors.ActiveCaption;
            buttonBack.Location = new Point(793, 558);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(242, 68);
            buttonBack.TabIndex = 11;
            buttonBack.Text = "Вернуться на главную страницу";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonBuy
            // 
            buttonBuy.Font = new Font("Verdana", 12F);
            buttonBuy.ForeColor = SystemColors.ActiveCaption;
            buttonBuy.Location = new Point(241, 558);
            buttonBuy.Name = "buttonBuy";
            buttonBuy.Size = new Size(242, 68);
            buttonBuy.TabIndex = 12;
            buttonBuy.Text = "Оформить заказ!";
            buttonBuy.UseVisualStyleBackColor = true;
            buttonBuy.Click += buttonBuy_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.Font = new Font("Verdana", 12F);
            buttonPlus.ForeColor = SystemColors.ActiveCaption;
            buttonPlus.Location = new Point(82, 210);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(90, 68);
            buttonPlus.TabIndex = 13;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.Font = new Font("Verdana", 12F);
            buttonMinus.ForeColor = SystemColors.ActiveCaption;
            buttonMinus.Location = new Point(175, 210);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(90, 68);
            buttonMinus.TabIndex = 14;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Verdana", 12F);
            buttonDelete.ForeColor = SystemColors.ActiveCaption;
            buttonDelete.Location = new Point(271, 210);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(198, 68);
            buttonDelete.TabIndex = 15;
            buttonDelete.Text = "Удалить из корзины";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonDeleteAll
            // 
            buttonDeleteAll.Font = new Font("Verdana", 12F);
            buttonDeleteAll.ForeColor = SystemColors.ActiveCaption;
            buttonDeleteAll.Location = new Point(475, 210);
            buttonDeleteAll.Name = "buttonDeleteAll";
            buttonDeleteAll.Size = new Size(198, 68);
            buttonDeleteAll.TabIndex = 16;
            buttonDeleteAll.Text = "Удалить из корзины все";
            buttonDeleteAll.UseVisualStyleBackColor = true;
            buttonDeleteAll.Click += buttonDeleteAll_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(726, 212);
            label2.Name = "label2";
            label2.Size = new Size(309, 34);
            label2.TabIndex = 17;
            label2.Text = "Общая стоимость:";
            // 
            // labelSum
            // 
            labelSum.AutoSize = true;
            labelSum.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelSum.ForeColor = SystemColors.ActiveCaption;
            labelSum.Location = new Point(674, 244);
            labelSum.Name = "labelSum";
            labelSum.Size = new Size(181, 34);
            labelSum.TabIndex = 18;
            labelSum.Text = "Стоимость";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Verdana", 12F);
            textBoxEmail.ForeColor = SystemColors.ActiveCaption;
            textBoxEmail.Location = new Point(13, 440);
            textBoxEmail.Multiline = true;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(343, 44);
            textBoxEmail.TabIndex = 27;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Verdana", 12F);
            labelEmail.ForeColor = SystemColors.ActiveCaption;
            labelEmail.Location = new Point(126, 413);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(118, 25);
            labelEmail.TabIndex = 29;
            labelEmail.Text = "Ваш email";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Verdana", 12F);
            labelPhone.ForeColor = SystemColors.ActiveCaption;
            labelPhone.Location = new Point(67, 352);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(233, 25);
            labelPhone.TabIndex = 28;
            labelPhone.Text = "Ваш номер телефона";
            // 
            // maskedTextBoxPhone
            // 
            maskedTextBoxPhone.Font = new Font("Verdana", 12F);
            maskedTextBoxPhone.ForeColor = SystemColors.ActiveCaption;
            maskedTextBoxPhone.Location = new Point(19, 379);
            maskedTextBoxPhone.Mask = "+7 (000) 000-00-00";
            maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            maskedTextBoxPhone.Size = new Size(343, 32);
            maskedTextBoxPhone.TabIndex = 25;
            // 
            // textBoxFullName
            // 
            textBoxFullName.Font = new Font("Verdana", 12F);
            textBoxFullName.ForeColor = SystemColors.ActiveCaption;
            textBoxFullName.Location = new Point(13, 306);
            textBoxFullName.Multiline = true;
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(343, 44);
            textBoxFullName.TabIndex = 24;
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Font = new Font("Verdana", 12F);
            labelFullName.ForeColor = SystemColors.ActiveCaption;
            labelFullName.Location = new Point(111, 281);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(122, 25);
            labelFullName.TabIndex = 26;
            labelFullName.Text = "Ваше ФИО";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Verdana", 12F);
            labelAddress.ForeColor = SystemColors.ActiveCaption;
            labelAddress.Location = new Point(19, 485);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(329, 25);
            labelAddress.TabIndex = 30;
            labelAddress.Text = "Укажите улицу, дом, квартиру";
            // 
            // textBoxStreet
            // 
            textBoxStreet.Font = new Font("Verdana", 12F);
            textBoxStreet.ForeColor = SystemColors.ActiveCaption;
            textBoxStreet.Location = new Point(13, 513);
            textBoxStreet.Multiline = true;
            textBoxStreet.Name = "textBoxStreet";
            textBoxStreet.Size = new Size(343, 44);
            textBoxStreet.TabIndex = 31;
            // 
            // labelPickAddress
            // 
            labelPickAddress.AutoSize = true;
            labelPickAddress.Font = new Font("Verdana", 12F);
            labelPickAddress.ForeColor = SystemColors.ActiveCaption;
            labelPickAddress.Location = new Point(382, 472);
            labelPickAddress.Name = "labelPickAddress";
            labelPickAddress.Size = new Size(302, 50);
            labelPickAddress.TabIndex = 32;
            labelPickAddress.Text = "Или выберите адрес из тех,\r\n что указывали раннее";
            labelPickAddress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxAddress
            // 
            comboBoxAddress.Font = new Font("Verdana", 12F);
            comboBoxAddress.ForeColor = SystemColors.ActiveCaption;
            comboBoxAddress.FormattingEnabled = true;
            comboBoxAddress.Location = new Point(361, 524);
            comboBoxAddress.Name = "comboBoxAddress";
            comboBoxAddress.Size = new Size(344, 33);
            comboBoxAddress.TabIndex = 33;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CalendarForeColor = SystemColors.ActiveCaption;
            dateTimePicker.CalendarTitleForeColor = SystemColors.ActiveCaption;
            dateTimePicker.Font = new Font("Verdana", 12F);
            dateTimePicker.Location = new Point(362, 440);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(344, 32);
            dateTimePicker.TabIndex = 34;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Verdana", 12F);
            labelDate.ForeColor = SystemColors.ActiveCaption;
            labelDate.Location = new Point(406, 413);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(267, 25);
            labelDate.TabIndex = 35;
            labelDate.Text = "Выберите дату доставки";
            // 
            // comboBoxCity
            // 
            comboBoxCity.Font = new Font("Verdana", 12F);
            comboBoxCity.ForeColor = SystemColors.ActiveCaption;
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.Location = new Point(362, 379);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(344, 33);
            comboBoxCity.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(439, 353);
            label3.Name = "label3";
            label3.Size = new Size(177, 25);
            label3.TabIndex = 37;
            label3.Text = "Выберите город";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(415, 281);
            label4.Name = "label4";
            label4.Size = new Size(243, 25);
            label4.TabIndex = 39;
            label4.Text = "Ваш почтовый индекс";
            // 
            // textBoxPostCode
            // 
            textBoxPostCode.Font = new Font("Verdana", 12F);
            textBoxPostCode.ForeColor = SystemColors.ActiveCaption;
            textBoxPostCode.Location = new Point(361, 306);
            textBoxPostCode.Multiline = true;
            textBoxPostCode.Name = "textBoxPostCode";
            textBoxPostCode.Size = new Size(343, 44);
            textBoxPostCode.TabIndex = 40;
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background__freepik_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1136, 629);
            Controls.Add(textBoxPostCode);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBoxCity);
            Controls.Add(labelDate);
            Controls.Add(dateTimePicker);
            Controls.Add(comboBoxAddress);
            Controls.Add(labelPickAddress);
            Controls.Add(textBoxStreet);
            Controls.Add(labelAddress);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(labelPhone);
            Controls.Add(maskedTextBoxPhone);
            Controls.Add(textBoxFullName);
            Controls.Add(labelFullName);
            Controls.Add(labelSum);
            Controls.Add(label2);
            Controls.Add(buttonDeleteAll);
            Controls.Add(buttonDelete);
            Controls.Add(buttonMinus);
            Controls.Add(buttonPlus);
            Controls.Add(buttonBuy);
            Controls.Add(buttonBack);
            Controls.Add(dataGridViewCart);
            Controls.Add(label1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveCaption;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ваша корзина";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dataGridViewCart;
        private Button buttonBack;
        private Button buttonBuy;
        private Button buttonPlus;
        private Button buttonMinus;
        private Button buttonDelete;
        private Button buttonDeleteAll;
        private Label label2;
        private Label labelSum;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private Label labelPhone;
        private MaskedTextBox maskedTextBoxPhone;
        private TextBox textBoxFullName;
        private Label labelFullName;
        private Label labelAddress;
        private TextBox textBoxStreet;
        private Label labelPickAddress;
        private ComboBox comboBoxAddress;
        private DateTimePicker dateTimePicker;
        private Label labelDate;
        private ComboBox comboBoxCity;
        private Label label3;
        private Label label4;
        private TextBox textBoxPostCode;
    }
}