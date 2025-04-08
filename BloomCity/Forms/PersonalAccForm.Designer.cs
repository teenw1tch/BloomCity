namespace BloomCity.Forms
{
    partial class PersonalAccForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalAccForm));
            labelWelcome = new Label();
            labelFullName = new Label();
            textBoxFullName = new TextBox();
            maskedTextBoxPhone = new MaskedTextBox();
            labelPhone = new Label();
            labelNewPsswd = new Label();
            textBoxNewPsswd = new TextBox();
            textBoxOldPsswd = new TextBox();
            textBoxEmail = new TextBox();
            labelChangePsswd = new Label();
            labelEmail = new Label();
            textBoxRepeatNewPsswd = new TextBox();
            labelRepeatNewPsswd = new Label();
            buttonSave = new Button();
            buttonChangePsswd = new Button();
            dataGridViewHistory = new DataGridView();
            labelHistory = new Label();
            buttonBack = new Button();
            buttonToCart = new Button();
            buttonExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).BeginInit();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelWelcome.ForeColor = SystemColors.ActiveCaption;
            labelWelcome.Location = new Point(257, 9);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(640, 34);
            labelWelcome.TabIndex = 1;
            labelWelcome.Text = "Добро пожаловать в личный кабинет!";
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Font = new Font("Verdana", 12F);
            labelFullName.ForeColor = SystemColors.ActiveCaption;
            labelFullName.Location = new Point(97, 83);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(122, 25);
            labelFullName.TabIndex = 2;
            labelFullName.Text = "Ваше ФИО";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Font = new Font("Verdana", 12F);
            textBoxFullName.ForeColor = SystemColors.ActiveCaption;
            textBoxFullName.Location = new Point(0, 122);
            textBoxFullName.Multiline = true;
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(343, 44);
            textBoxFullName.TabIndex = 1;
            // 
            // maskedTextBoxPhone
            // 
            maskedTextBoxPhone.Font = new Font("Verdana", 12F);
            maskedTextBoxPhone.ForeColor = SystemColors.ActiveCaption;
            maskedTextBoxPhone.Location = new Point(0, 219);
            maskedTextBoxPhone.Mask = "+7 (000) 000-00-00";
            maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            maskedTextBoxPhone.Size = new Size(343, 32);
            maskedTextBoxPhone.TabIndex = 2;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Verdana", 12F);
            labelPhone.ForeColor = SystemColors.ActiveCaption;
            labelPhone.Location = new Point(52, 180);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(233, 25);
            labelPhone.TabIndex = 19;
            labelPhone.Text = "Ваш номер телефона";
            // 
            // labelNewPsswd
            // 
            labelNewPsswd.AutoSize = true;
            labelNewPsswd.Font = new Font("Verdana", 12F);
            labelNewPsswd.ForeColor = SystemColors.ActiveCaption;
            labelNewPsswd.Location = new Point(401, 176);
            labelNewPsswd.Name = "labelNewPsswd";
            labelNewPsswd.Size = new Size(249, 25);
            labelNewPsswd.TabIndex = 25;
            labelNewPsswd.Text = "Введите новый пароль";
            // 
            // textBoxNewPsswd
            // 
            textBoxNewPsswd.Font = new Font("Verdana", 12F);
            textBoxNewPsswd.ForeColor = SystemColors.ActiveCaption;
            textBoxNewPsswd.Location = new Point(357, 213);
            textBoxNewPsswd.Multiline = true;
            textBoxNewPsswd.Name = "textBoxNewPsswd";
            textBoxNewPsswd.Size = new Size(343, 44);
            textBoxNewPsswd.TabIndex = 6;
            textBoxNewPsswd.KeyPress += textBoxNewPsswd_KeyPress;
            // 
            // textBoxOldPsswd
            // 
            textBoxOldPsswd.Font = new Font("Verdana", 12F);
            textBoxOldPsswd.ForeColor = SystemColors.ActiveCaption;
            textBoxOldPsswd.Location = new Point(357, 120);
            textBoxOldPsswd.Multiline = true;
            textBoxOldPsswd.Name = "textBoxOldPsswd";
            textBoxOldPsswd.Size = new Size(343, 44);
            textBoxOldPsswd.TabIndex = 5;
            textBoxOldPsswd.KeyPress += textBoxOldPsswd_KeyPress;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Verdana", 12F);
            textBoxEmail.ForeColor = SystemColors.ActiveCaption;
            textBoxEmail.Location = new Point(0, 304);
            textBoxEmail.Multiline = true;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(343, 44);
            textBoxEmail.TabIndex = 3;
            textBoxEmail.KeyPress += textBoxEmail_KeyPress;
            // 
            // labelChangePsswd
            // 
            labelChangePsswd.AutoSize = true;
            labelChangePsswd.Font = new Font("Verdana", 12F);
            labelChangePsswd.ForeColor = SystemColors.ActiveCaption;
            labelChangePsswd.Location = new Point(379, 58);
            labelChangePsswd.Name = "labelChangePsswd";
            labelChangePsswd.Size = new Size(306, 50);
            labelChangePsswd.TabIndex = 24;
            labelChangePsswd.Text = "Чтобы изменить пароль,\r\nвведите Ваш старый пароль";
            labelChangePsswd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Verdana", 12F);
            labelEmail.ForeColor = SystemColors.ActiveCaption;
            labelEmail.Location = new Point(83, 265);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(118, 25);
            labelEmail.TabIndex = 23;
            labelEmail.Text = "Ваш email";
            // 
            // textBoxRepeatNewPsswd
            // 
            textBoxRepeatNewPsswd.Font = new Font("Verdana", 12F);
            textBoxRepeatNewPsswd.ForeColor = SystemColors.ActiveCaption;
            textBoxRepeatNewPsswd.Location = new Point(357, 306);
            textBoxRepeatNewPsswd.Multiline = true;
            textBoxRepeatNewPsswd.Name = "textBoxRepeatNewPsswd";
            textBoxRepeatNewPsswd.Size = new Size(343, 44);
            textBoxRepeatNewPsswd.TabIndex = 7;
            textBoxRepeatNewPsswd.KeyPress += textBoxRepeatNewPsswd_KeyPress;
            // 
            // labelRepeatNewPsswd
            // 
            labelRepeatNewPsswd.AutoSize = true;
            labelRepeatNewPsswd.Font = new Font("Verdana", 12F);
            labelRepeatNewPsswd.ForeColor = SystemColors.ActiveCaption;
            labelRepeatNewPsswd.Location = new Point(391, 269);
            labelRepeatNewPsswd.Name = "labelRepeatNewPsswd";
            labelRepeatNewPsswd.Size = new Size(272, 25);
            labelRepeatNewPsswd.TabIndex = 27;
            labelRepeatNewPsswd.Text = "Повторите новый пароль";
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Verdana", 12F);
            buttonSave.ForeColor = SystemColors.ActiveCaption;
            buttonSave.Location = new Point(43, 362);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(242, 68);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Сохранить изменения!";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonChangePsswd
            // 
            buttonChangePsswd.Font = new Font("Verdana", 12F);
            buttonChangePsswd.ForeColor = SystemColors.ActiveCaption;
            buttonChangePsswd.Location = new Point(421, 362);
            buttonChangePsswd.Name = "buttonChangePsswd";
            buttonChangePsswd.Size = new Size(242, 68);
            buttonChangePsswd.TabIndex = 8;
            buttonChangePsswd.Text = "Изменить пароль!";
            buttonChangePsswd.UseVisualStyleBackColor = true;
            buttonChangePsswd.Click += buttonChangePsswd_Click;
            // 
            // dataGridViewHistory
            // 
            dataGridViewHistory.BackgroundColor = Color.LavenderBlush;
            dataGridViewHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistory.GridColor = Color.Plum;
            dataGridViewHistory.Location = new Point(706, 120);
            dataGridViewHistory.Name = "dataGridViewHistory";
            dataGridViewHistory.RowHeadersWidth = 51;
            dataGridViewHistory.Size = new Size(426, 310);
            dataGridViewHistory.TabIndex = 9;
            // 
            // labelHistory
            // 
            labelHistory.AutoSize = true;
            labelHistory.Font = new Font("Verdana", 12F);
            labelHistory.ForeColor = SystemColors.ActiveCaption;
            labelHistory.Location = new Point(789, 83);
            labelHistory.Name = "labelHistory";
            labelHistory.Size = new Size(269, 25);
            labelHistory.TabIndex = 31;
            labelHistory.Text = "История Ваших заказов:";
            labelHistory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Verdana", 12F);
            buttonBack.ForeColor = SystemColors.ActiveCaption;
            buttonBack.Location = new Point(128, 549);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(242, 68);
            buttonBack.TabIndex = 10;
            buttonBack.Text = "Вернуться на главную страницу";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonToCart
            // 
            buttonToCart.Font = new Font("Verdana", 12F);
            buttonToCart.ForeColor = SystemColors.ActiveCaption;
            buttonToCart.Location = new Point(478, 549);
            buttonToCart.Name = "buttonToCart";
            buttonToCart.Size = new Size(242, 68);
            buttonToCart.TabIndex = 11;
            buttonToCart.Text = "Перейти в корзину";
            buttonToCart.UseVisualStyleBackColor = true;
            buttonToCart.Click += buttonToCart_Click;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Verdana", 12F);
            buttonExit.ForeColor = Color.DarkMagenta;
            buttonExit.Location = new Point(828, 549);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(242, 68);
            buttonExit.TabIndex = 12;
            buttonExit.Text = "Выйти из аккаунта";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // PersonalAccForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background__freepik_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1136, 629);
            Controls.Add(buttonExit);
            Controls.Add(buttonToCart);
            Controls.Add(buttonBack);
            Controls.Add(labelHistory);
            Controls.Add(dataGridViewHistory);
            Controls.Add(buttonChangePsswd);
            Controls.Add(buttonSave);
            Controls.Add(labelRepeatNewPsswd);
            Controls.Add(textBoxRepeatNewPsswd);
            Controls.Add(labelNewPsswd);
            Controls.Add(textBoxNewPsswd);
            Controls.Add(textBoxOldPsswd);
            Controls.Add(textBoxEmail);
            Controls.Add(labelChangePsswd);
            Controls.Add(labelEmail);
            Controls.Add(labelPhone);
            Controls.Add(maskedTextBoxPhone);
            Controls.Add(textBoxFullName);
            Controls.Add(labelFullName);
            Controls.Add(labelWelcome);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveCaption;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PersonalAccForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Личный кабинет";
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWelcome;
        private Label labelFullName;
        private TextBox textBoxFullName;
        private MaskedTextBox maskedTextBoxPhone;
        private Label labelPhone;
        private Label labelNewPsswd;
        private TextBox textBoxNewPsswd;
        private TextBox textBoxOldPsswd;
        private TextBox textBoxEmail;
        private Label labelChangePsswd;
        private Label labelEmail;
        private TextBox textBoxRepeatNewPsswd;
        private Label labelRepeatNewPsswd;
        private Button buttonSave;
        private Button buttonChangePsswd;
        private DataGridView dataGridViewHistory;
        private Label labelHistory;
        private Button buttonBack;
        private Button buttonToCart;
        private Button buttonExit;
    }
}