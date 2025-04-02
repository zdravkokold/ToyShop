
namespace ToyShop.Forms
{
    partial class ShippingForm
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
            nameLabel = new Label();
            nameTextBox = new TextBox();
            addressLabel = new Label();
            addressTextBox = new TextBox();
            phoneLabel = new Label();
            phoneTextBox = new TextBox();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            confirmButton = new Button();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.Font = new Font("Segoe UI", 11F);
            nameLabel.Location = new Point(38, 37);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(69, 29);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Име";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(38, 69);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(362, 31);
            nameTextBox.TabIndex = 1;
            // 
            // addressLabel
            // 
            addressLabel.Font = new Font("Segoe UI", 11F);
            addressLabel.Location = new Point(38, 201);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(82, 32);
            addressLabel.TabIndex = 2;
            addressLabel.Text = "Адрес";
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(38, 236);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(362, 31);
            addressTextBox.TabIndex = 3;
            // 
            // phoneLabel
            // 
            phoneLabel.Font = new Font("Segoe UI", 11F);
            phoneLabel.Location = new Point(38, 286);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(119, 33);
            phoneLabel.TabIndex = 4;
            phoneLabel.Text = "Телефон";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(38, 322);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(362, 31);
            phoneTextBox.TabIndex = 5;
            // 
            // emailLabel
            // 
            emailLabel.Font = new Font("Segoe UI", 11F);
            emailLabel.Location = new Point(38, 118);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(82, 29);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Имейл";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(38, 150);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(362, 31);
            emailTextBox.TabIndex = 7;
            // 
            // confirmButton
            // 
            confirmButton.BackColor = Color.LightGray;
            confirmButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmButton.Location = new Point(128, 392);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(171, 61);
            confirmButton.TabIndex = 8;
            confirmButton.Text = "Потвърди";
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += confirmButton_Click;
            // 
            // ShippingForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(437, 470);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(addressLabel);
            Controls.Add(addressTextBox);
            Controls.Add(phoneLabel);
            Controls.Add(phoneTextBox);
            Controls.Add(emailLabel);
            Controls.Add(emailTextBox);
            Controls.Add(confirmButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ShippingForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Въведете адрес за доставка";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label nameLabel;
        private TextBox nameTextBox;
        private Label addressLabel;
        private TextBox addressTextBox;
        private Label phoneLabel;
        private TextBox phoneTextBox;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Button confirmButton;
    }
}