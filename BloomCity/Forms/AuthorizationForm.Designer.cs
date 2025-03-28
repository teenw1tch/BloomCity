namespace BloomCity.Forms
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            linkLabelRegistration = new LinkLabel();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(343, 9);
            label1.Name = "label1";
            label1.Size = new Size(479, 34);
            label1.TabIndex = 0;
            label1.Text = "Пожалуйста, авторизуйтесь!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(505, 152);
            label2.Name = "label2";
            label2.Size = new Size(155, 25);
            label2.TabIndex = 0;
            label2.Text = "Логин (Email)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(539, 286);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 0;
            label3.Text = "Пароль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(412, 565);
            label4.Name = "label4";
            label4.Size = new Size(340, 25);
            label4.TabIndex = 3;
            label4.Text = "У Вас еще нет учетной записи?";
            // 
            // linkLabelRegistration
            // 
            linkLabelRegistration.AutoSize = true;
            linkLabelRegistration.Font = new Font("Verdana", 12F);
            linkLabelRegistration.ForeColor = SystemColors.ActiveCaption;
            linkLabelRegistration.LinkColor = SystemColors.HotTrack;
            linkLabelRegistration.Location = new Point(468, 590);
            linkLabelRegistration.Name = "linkLabelRegistration";
            linkLabelRegistration.Size = new Size(228, 25);
            linkLabelRegistration.TabIndex = 4;
            linkLabelRegistration.TabStop = true;
            linkLabelRegistration.Text = "Зарегистрироваться!";
            linkLabelRegistration.LinkClicked += linkLabelRegistration_LinkClicked;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Verdana", 12F);
            textBoxLogin.ForeColor = SystemColors.ActiveCaption;
            textBoxLogin.Location = new Point(411, 180);
            textBoxLogin.Multiline = true;
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(343, 44);
            textBoxLogin.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Verdana", 12F);
            textBoxPassword.ForeColor = SystemColors.ActiveCaption;
            textBoxPassword.Location = new Point(411, 314);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(343, 44);
            textBoxPassword.TabIndex = 2;
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Verdana", 12F);
            buttonLogin.ForeColor = SystemColors.ActiveCaption;
            buttonLogin.Location = new Point(477, 441);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(210, 53);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "Войти";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.ClientSizeChanged += buttonLogin_Click;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background__freepik_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1136, 629);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(linkLabelRegistration);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveCaption;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AuthorizationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private LinkLabel linkLabelRegistration;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Button buttonLogin;
    }
}