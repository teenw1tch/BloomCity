namespace BloomCity.Forms
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            label1 = new Label();
            textBoxFullName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBoxPassword = new TextBox();
            textBoxEmail = new TextBox();
            label5 = new Label();
            label4 = new Label();
            textBoxRepeatPassword = new TextBox();
            label6 = new Label();
            buttonRegistration = new Button();
            maskedTextBoxPhone = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(327, 9);
            label1.Name = "label1";
            label1.Size = new Size(552, 34);
            label1.TabIndex = 1;
            label1.Text = "Пожалуйста, зарегистрируйтесь!";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Font = new Font("Verdana", 12F);
            textBoxFullName.ForeColor = SystemColors.ActiveCaption;
            textBoxFullName.Location = new Point(432, 96);
            textBoxFullName.Multiline = true;
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(343, 44);
            textBoxFullName.TabIndex = 1;
            textBoxFullName.KeyPress += textBoxFullName_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(466, 154);
            label3.Name = "label3";
            label3.Size = new Size(274, 25);
            label3.TabIndex = 8;
            label3.Text = "Введите номер телефона";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(528, 57);
            label2.Name = "label2";
            label2.Size = new Size(151, 25);
            label2.TabIndex = 7;
            label2.Text = "Введите ФИО";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Verdana", 12F);
            textBoxPassword.ForeColor = SystemColors.ActiveCaption;
            textBoxPassword.Location = new Point(432, 387);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(343, 44);
            textBoxPassword.TabIndex = 4;
            textBoxPassword.KeyPress += textBoxPassword_KeyPress;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Verdana", 12F);
            textBoxEmail.ForeColor = SystemColors.ActiveCaption;
            textBoxEmail.Location = new Point(432, 290);
            textBoxEmail.Multiline = true;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(343, 44);
            textBoxEmail.TabIndex = 3;
            textBoxEmail.KeyPress += textBoxEmail_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(515, 348);
            label5.Name = "label5";
            label5.Size = new Size(176, 25);
            label5.TabIndex = 12;
            label5.Text = "Введите пароль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(524, 251);
            label4.Name = "label4";
            label4.Size = new Size(159, 25);
            label4.TabIndex = 11;
            label4.Text = "Введите email";
            // 
            // textBoxRepeatPassword
            // 
            textBoxRepeatPassword.Font = new Font("Verdana", 12F);
            textBoxRepeatPassword.ForeColor = SystemColors.ActiveCaption;
            textBoxRepeatPassword.Location = new Point(432, 484);
            textBoxRepeatPassword.Multiline = true;
            textBoxRepeatPassword.Name = "textBoxRepeatPassword";
            textBoxRepeatPassword.Size = new Size(343, 44);
            textBoxRepeatPassword.TabIndex = 5;
            textBoxRepeatPassword.KeyPress += textBoxRepeatPassword_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F);
            label6.ForeColor = SystemColors.ActiveCaption;
            label6.Location = new Point(504, 445);
            label6.Name = "label6";
            label6.Size = new Size(199, 25);
            label6.TabIndex = 16;
            label6.Text = "Повторите пароль";
            // 
            // buttonRegistration
            // 
            buttonRegistration.Font = new Font("Verdana", 12F);
            buttonRegistration.ForeColor = SystemColors.ActiveCaption;
            buttonRegistration.Location = new Point(482, 542);
            buttonRegistration.Name = "buttonRegistration";
            buttonRegistration.Size = new Size(242, 53);
            buttonRegistration.TabIndex = 6;
            buttonRegistration.Text = "Зарегистрироваться";
            buttonRegistration.UseVisualStyleBackColor = true;
            buttonRegistration.Click += buttonRegistration_Click;
            // 
            // maskedTextBoxPhone
            // 
            maskedTextBoxPhone.Font = new Font("Verdana", 12F);
            maskedTextBoxPhone.ForeColor = SystemColors.ActiveCaption;
            maskedTextBoxPhone.Location = new Point(432, 204);
            maskedTextBoxPhone.Mask = "+7 (000) 000-00-00";
            maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            maskedTextBoxPhone.Size = new Size(343, 32);
            maskedTextBoxPhone.TabIndex = 17;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background__freepik_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1136, 629);
            Controls.Add(maskedTextBoxPhone);
            Controls.Add(buttonRegistration);
            Controls.Add(label6);
            Controls.Add(textBoxRepeatPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxFullName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxFullName;
        private Label label3;
        private Label label2;
        private TextBox textBoxPassword;
        private TextBox textBoxEmail;
        private Label label5;
        private Label label4;
        private TextBox textBoxRepeatPassword;
        private Label label6;
        private Button buttonRegistration;
        private MaskedTextBox maskedTextBoxPhone;
    }
}