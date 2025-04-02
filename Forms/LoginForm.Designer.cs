namespace ToyShop.Forms
{
    partial class LoginForm
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
            btnLogin = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            lblError = new Label();
            btnRegister = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(146, 294);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(164, 56);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Вход";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(28, 98);
            txtUsername.Margin = new Padding(2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(374, 31);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(28, 192);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(374, 31);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 62);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(263, 25);
            label1.TabIndex = 3;
            label1.Text = "Имейл или потребителско име";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 156);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 4;
            label2.Text = "Парола";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.profile;
            pictureBox1.InitialImage = Properties.Resources.profile;
            pictureBox1.Location = new Point(432, 37);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(32, 249);
            lblError.Margin = new Padding(2, 0, 2, 0);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 25);
            lblError.TabIndex = 6;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(326, 294);
            btnRegister.Margin = new Padding(2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(164, 56);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Регистрация";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(657, 368);
            Controls.Add(btnRegister);
            Controls.Add(lblError);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnLogin);
            Margin = new Padding(2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label lblError;
        private Button btnRegister;
    }
}