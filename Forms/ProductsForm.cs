using ToyShop.Entities;

namespace ToyShop.Forms
{
    public partial class ProductsForm : Form
    {
        private FlowLayoutPanel flowLayoutPanel;
        private readonly ShopService shopService;
        private Label label1;
        private TextBox filterTextBox;
        private Button filterButton;
        private Button manageButton;

        public ProductsForm(List<Product> products, ShopService shopService)
        {
            this.shopService = shopService;
            InitializeComponent();
            LoadProducts(products);
            HideButtonsIfNotAdmin();
        }

        private void LoadProducts(List<Product> products)
        {
            flowLayoutPanel.Controls.Clear();

            foreach (var product in products)
            {
                Panel productPanel = CreateProductCard(product);
                flowLayoutPanel.Controls.Add(productPanel);
            }
        }

        private void InitializeComponent()
        {
            flowLayoutPanel = new FlowLayoutPanel();
            manageButton = new Button();
            label1 = new Label();
            filterTextBox = new TextBox();
            filterButton = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Location = new Point(12, 78);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(884, 615);
            flowLayoutPanel.TabIndex = 0;
            // 
            // manageButton
            // 
            manageButton.Location = new Point(608, 24);
            manageButton.Name = "manageButton";
            manageButton.Size = new Size(175, 50);
            manageButton.TabIndex = 1;
            manageButton.Text = "Добави продукт";
            manageButton.UseVisualStyleBackColor = true;
            manageButton.Click += manageButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 28);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 2;
            label1.Text = "Търсене:";
            // 
            // filterTextBox
            // 
            filterTextBox.Location = new Point(118, 30);
            filterTextBox.Multiline = true;
            filterTextBox.Name = "filterTextBox";
            filterTextBox.Size = new Size(356, 33);
            filterTextBox.TabIndex = 3;
            // 
            // filterButton
            // 
            filterButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterButton.Location = new Point(482, 22);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(58, 50);
            filterButton.TabIndex = 4;
            filterButton.Text = "🔍";
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += filterButton_Click;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(878, 694);
            Controls.Add(filterButton);
            Controls.Add(filterTextBox);
            Controls.Add(label1);
            Controls.Add(manageButton);
            Controls.Add(flowLayoutPanel);
            Name = "ProductsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel CreateProductCard(Product product)
        {
            Panel panel = new Panel
            {
                Width = 120,
                Height = 160,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(5)
            };

            PictureBox pictureBox = new PictureBox
            {
                Size = new Size(100, 80),
                Location = new Point(10, 5),
                SizeMode = PictureBoxSizeMode.Zoom
            };

            if (product.Image != null)
            {
                using (MemoryStream ms = new MemoryStream(product.Image))
                {
                    pictureBox.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pictureBox.Image = Properties.Resources.placeholder;
            }

            Label nameLabel = new Label
            {
                Text = product.Name,
                Location = new Point(10, 90),
                Width = 100,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 10, FontStyle.Bold),
                AutoSize = false
            };

            Label priceLabel = new Label
            {
                Text = $"{product.Price:F2} лв.",
                Location = new Point(10, 110),
                Width = 100,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.Green,
                Font = new Font("Arial", 8, FontStyle.Bold),
                AutoSize = false
            };

            panel.Controls.Add(pictureBox);
            panel.Controls.Add(nameLabel);
            panel.Controls.Add(priceLabel);

            if (Session.UserRole == "Admin")
            {
                PictureBox editIcon = new PictureBox
                {
                    Size = new Size(24, 24),
                    Location = new Point(30, 130),
                    Cursor = Cursors.Hand,
                    Image = Properties.Resources.edit,
                    SizeMode = PictureBoxSizeMode.Zoom
                };
                editIcon.Click += (sender, e) => EditProduct(product);

                PictureBox deleteIcon = new PictureBox
                {
                    Size = new Size(24, 24),
                    Location = new Point(60, 130),
                    Cursor = Cursors.Hand,
                    Image = Properties.Resources.delete,
                    SizeMode = PictureBoxSizeMode.Zoom
                };
                deleteIcon.Click += (sender, e) => ConfirmAndDeleteProduct(product.Id);

                panel.Controls.Add(editIcon);
                panel.Controls.Add(deleteIcon);
            }
            else if (Session.UserRole == "Client")
            {         
                NumericUpDown quantityUpDown = new NumericUpDown
                {
                    Location = new Point(57, 130),
                    Width = 36,
                    Height = 24,
                    Minimum = 1,
                    Maximum = 100
                };

                PictureBox cartIcon = new PictureBox
                {
                    Size = new Size(24, 24),
                    Location = new Point(27, 130),
                    Cursor = Cursors.Hand,
                    Image = Properties.Resources.basket,
                    SizeMode = PictureBoxSizeMode.Zoom
                };
                cartIcon.Click += (sender, e) =>
                {
                    product.Quantity = (int)quantityUpDown.Value;
                    shopService.AddProductToCart(product);
                };
                panel.Controls.Add(cartIcon);
                panel.Controls.Add(quantityUpDown);
            }

            return panel;
        }

        private void manageButton_Click(object sender, EventArgs e)
        {
            ManageProductsForm manageProductsForm = new ManageProductsForm(shopService, null, false);
            manageProductsForm.Show();
            manageProductsForm.FormClosed += (s, args) => LoadProducts(shopService.GetAllProducts());
        }

        private void EditProduct(Product product)
        {
            ManageProductsForm manageForm = new ManageProductsForm(shopService, product, true);
            manageForm.FormClosed += (s, args) => LoadProducts(shopService.GetAllProducts());
            manageForm.ShowDialog();
        }

        private void ConfirmAndDeleteProduct(int productId)
        {
            DialogResult result =
                MessageBox.Show("Сигурни ли сте, че искате да изтриете този продукт?", "Потвърждение за изтриване",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                shopService.DeleteProduct(productId);
                LoadProducts(shopService.GetAllProducts());
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            string filter = filterTextBox.Text.ToLower();

            if (!string.IsNullOrEmpty(filter))
            {
                List<Product> filteredProducts = shopService.GetAllProducts()
                    .Where(p => p.Name.ToLower().Contains(filter)
                             || p.Price.ToString().Contains(filter)).ToList();

                LoadProducts(filteredProducts);
            }
            else
            {
                LoadProducts(shopService.GetAllProducts());
            }
        }

        private void HideButtonsIfNotAdmin()
        {
            if (Session.UserRole != "Admin")
            {
                manageButton.Visible = false;
            }
        }
    }
}