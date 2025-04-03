namespace ToyShop
{
    partial class HomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainPanel = new Panel();
            usersButton = new Button();
            productsButton = new Button();
            logoPictureBox = new PictureBox();
            logOutBbutton = new Button();
            cartButton = new Button();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(176, 10);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(900, 750);
            mainPanel.TabIndex = 1;
            // 
            // usersButton
            // 
            usersButton.Location = new Point(12, 316);
            usersButton.Name = "usersButton";
            usersButton.Size = new Size(154, 63);
            usersButton.TabIndex = 2;
            usersButton.Text = "Потребители";
            usersButton.UseVisualStyleBackColor = true;
            usersButton.Click += usersButton_Click;
            // 
            // productsButton
            // 
            productsButton.Location = new Point(11, 174);
            productsButton.Name = "productsButton";
            productsButton.Size = new Size(155, 63);
            productsButton.TabIndex = 3;
            productsButton.Text = "Продукти";
            productsButton.UseVisualStyleBackColor = true;
            productsButton.Click += productsButton_Click;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Image = Properties.Resources.logo;
            logoPictureBox.InitialImage = Properties.Resources.logo;
            logoPictureBox.Location = new Point(11, 8);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(155, 155);
            logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoPictureBox.TabIndex = 4;
            logoPictureBox.TabStop = false;
            // 
            // logOutBbutton
            // 
            logOutBbutton.Location = new Point(11, 717);
            logOutBbutton.Name = "logOutBbutton";
            logOutBbutton.Size = new Size(155, 42);
            logOutBbutton.TabIndex = 5;
            logOutBbutton.Text = "Изход ";
            logOutBbutton.UseVisualStyleBackColor = true;
            logOutBbutton.Click += logOutBbutton_Click;
            // 
            // cartButton
            // 
            cartButton.Location = new Point(12, 244);
            cartButton.Name = "cartButton";
            cartButton.Size = new Size(154, 63);
            cartButton.TabIndex = 6;
            cartButton.Text = "Количка";
            cartButton.UseVisualStyleBackColor = true;
            cartButton.Click += cartButton_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1080, 768);
            Controls.Add(cartButton);
            Controls.Add(logOutBbutton);
            Controls.Add(logoPictureBox);
            Controls.Add(usersButton);
            Controls.Add(productsButton);
            Controls.Add(mainPanel);
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Магазин за детски играчки \"Детски свят\"";
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel mainPanel;
        private Button usersButton;
        private Button productsButton;
        private PictureBox logoPictureBox;
        private Button logOutBbutton;
        private Button cartButton;
    }
}
