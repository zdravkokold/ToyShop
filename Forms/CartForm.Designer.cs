namespace ToyShop.Forms
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
            placeOrderButton = new Button();
            totalSumLabel = new Label();
            cartListView = new ListView();
            clearCartButton = new Button();
            SuspendLayout();
            // 
            // placeOrderButton
            // 
            placeOrderButton.Location = new Point(682, 643);
            placeOrderButton.Name = "placeOrderButton";
            placeOrderButton.Size = new Size(176, 58);
            placeOrderButton.TabIndex = 0;
            placeOrderButton.Text = "Поръчай 📦";
            placeOrderButton.UseVisualStyleBackColor = true;
            placeOrderButton.Click += placeOrderButton_Click;
            // 
            // totalSumLabel
            // 
            totalSumLabel.AutoSize = true;
            totalSumLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalSumLabel.ForeColor = Color.Green;
            totalSumLabel.Location = new Point(15, 654);
            totalSumLabel.Name = "totalSumLabel";
            totalSumLabel.Size = new Size(189, 32);
            totalSumLabel.TabIndex = 1;
            totalSumLabel.Text = "Общо: 0.00 лв.";
            // 
            // cartListView
            // 
            cartListView.BackColor = SystemColors.InactiveCaption;
            cartListView.Location = new Point(13, 12);
            cartListView.Name = "cartListView";
            cartListView.Size = new Size(850, 620);
            cartListView.TabIndex = 2;
            cartListView.UseCompatibleStateImageBehavior = false;
            cartListView.View = View.Details;
            // 
            // clearCartButton
            // 
            clearCartButton.Location = new Point(448, 643);
            clearCartButton.Name = "clearCartButton";
            clearCartButton.Size = new Size(215, 58);
            clearCartButton.TabIndex = 3;
            clearCartButton.Text = "Изпразни количка ❌";
            clearCartButton.UseVisualStyleBackColor = true;
            clearCartButton.Click += clearCartButton_Click;
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(878, 714);
            Controls.Add(clearCartButton);
            Controls.Add(cartListView);
            Controls.Add(totalSumLabel);
            Controls.Add(placeOrderButton);
            Name = "CartForm";
            Text = "Количка";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button orderButton;
        private Button placeOrderButton;
        private Label totalSumLabel;
        private ListView cartListView;
        private Button clearCartButton;
    }
}