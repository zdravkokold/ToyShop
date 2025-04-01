namespace ToyShop.Forms
{
    partial class ManageProductsForm
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
            addButton = new Button();
            editButton = new Button();
            priceTextBox = new TextBox();
            nameTextBox = new TextBox();
            pictureBox = new PictureBox();
            uploadButton = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(366, 251);
            addButton.Name = "addButton";
            addButton.Size = new Size(139, 56);
            addButton.TabIndex = 0;
            addButton.Text = "Добави";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(366, 251);
            editButton.Name = "editButton";
            editButton.Size = new Size(139, 56);
            editButton.TabIndex = 1;
            editButton.Text = "Редактирай";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(366, 158);
            priceTextBox.Multiline = true;
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(257, 44);
            priceTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(366, 62);
            nameTextBox.Multiline = true;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(257, 44);
            nameTextBox.TabIndex = 4;
            // 
            // pictureBox
            // 
            pictureBox.Image = Properties.Resources.placeholder;
            pictureBox.Location = new Point(24, 24);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(220, 220);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 5;
            pictureBox.TabStop = false;
            // 
            // uploadButton
            // 
            uploadButton.Location = new Point(53, 260);
            uploadButton.Name = "uploadButton";
            uploadButton.Size = new Size(155, 47);
            uploadButton.TabIndex = 6;
            uploadButton.Text = "Качи снимка";
            uploadButton.UseVisualStyleBackColor = true;
            uploadButton.Click += uploadButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(284, 62);
            label1.Name = "label1";
            label1.Size = new Size(67, 32);
            label1.TabIndex = 7;
            label1.Text = "Име:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(284, 158);
            label2.Name = "label2";
            label2.Size = new Size(76, 32);
            label2.TabIndex = 8;
            label2.Text = "Цена:";
            // 
            // ManageProductsForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(651, 331);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(uploadButton);
            Controls.Add(pictureBox);
            Controls.Add(nameTextBox);
            Controls.Add(priceTextBox);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Name = "ManageProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Управление на продукти";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addButton;
        private Button editButton;
        private TextBox priceTextBox;
        private TextBox nameTextBox;
        private PictureBox pictureBox;
        private Button uploadButton;
        private Label label1;
        private Label label2;
    }
}