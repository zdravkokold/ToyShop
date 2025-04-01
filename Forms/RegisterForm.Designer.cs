namespace ToyShop.Forms
{
    partial class RegisterForm
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
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblError = new Label();
            btnRegister = new Button();
            label5 = new Label();
            txtAddress = new TextBox();
            label6 = new Label();
            nameTextBox = new TextBox();
            phoneTextBox = new TextBox();
            Телефон = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(75, 62);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(347, 31);
            txtUsername.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(75, 317);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(347, 31);
            txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(75, 482);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(347, 31);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(75, 571);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(347, 31);
            txtConfirmPassword.TabIndex = 3;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 28);
            label1.Name = "label1";
            label1.Size = new Size(173, 25);
            label1.TabIndex = 4;
            label1.Text = "Потребителско име";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 284);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 5;
            label2.Text = "Имейл";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(210, 447);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 6;
            label3.Text = "Парола";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(167, 536);
            label4.Name = "label4";
            label4.Size = new Size(175, 25);
            label4.TabIndex = 7;
            label4.Text = "Потвърди паролата";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(75, 378);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 25);
            lblError.TabIndex = 8;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(165, 630);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(175, 48);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Регистрация";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(218, 362);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 11;
            label5.Text = "Адрес";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(75, 395);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(347, 31);
            txtAddress.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(185, 115);
            label6.Name = "label6";
            label6.Size = new Size(139, 25);
            label6.TabIndex = 13;
            label6.Text = "Име и фамилия";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(75, 152);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(347, 31);
            nameTextBox.TabIndex = 12;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(75, 233);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(347, 31);
            phoneTextBox.TabIndex = 14;
            // 
            // Телефон
            // 
            Телефон.AutoSize = true;
            Телефон.Location = new Point(212, 201);
            Телефон.Name = "Телефон";
            Телефон.Size = new Size(81, 25);
            Телефон.TabIndex = 15;
            Телефон.Text = "Телефон";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(491, 695);
            Controls.Add(Телефон);
            Controls.Add(phoneTextBox);
            Controls.Add(label6);
            Controls.Add(nameTextBox);
            Controls.Add(label5);
            Controls.Add(txtAddress);
            Controls.Add(btnRegister);
            Controls.Add(lblError);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblError;
        private Button btnRegister;
        private Label label5;
        private TextBox txtAddress;
        private Label label6;
        private TextBox textBox1;
        private TextBox nameTextBox;
        private TextBox phoneTextBox;
        private Label Телефон;
    }
}