using ToyShop.Entities;

namespace ToyShop.Forms
{
    public partial class ManageProductsForm : Form
    {
        private byte[] productImageData;
        private readonly ShopService shopService;
        private readonly Product product;
        private bool isImageEdited;
        private bool mustBeEdited;

        public ManageProductsForm(ShopService shopService, Product product, bool mustBeEdited)
        {
            InitializeComponent();
            this.shopService = shopService;
            this.product = product;
            isImageEdited = false;
            this.mustBeEdited = mustBeEdited;
            LoadData(product);
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    productImageData = File.ReadAllBytes(openFileDialog.FileName);
                    pictureBox.Image = Image.FromFile(openFileDialog.FileName);

                    isImageEdited = true;
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string priceTxt = priceTextBox.Text;

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(priceTxt) && isImageEdited)
            {
                shopService.AddProduct(new Product
                {
                    Name = name,
                    Price = decimal.Parse(priceTxt),
                    Image = productImageData
                });

                MessageBox.Show("Продуктът е добавен успешно.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Моля, въведете име и цена на продукта и прикачете снимка.");
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            string updatedName = nameTextBox.Text;
            decimal updatedPrice = decimal.Parse(priceTextBox.Text);
            byte[]? image = product.Image;

            if (updatedName != product.Name || updatedPrice != product.Price || isImageEdited)
            {
                if (updatedName != product.Name)
                {
                    product.Name = updatedName;
                }
                if (updatedPrice != product.Price)
                {
                    product.Price = updatedPrice;
                }
                if (isImageEdited)
                {
                    product.Image = productImageData;
                }
                else product.Image = image;

                shopService.UpdateProduct(product);

                MessageBox.Show("Продуктът е редактиран успешно.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Няма направени промени.");
            }
        }

        private void LoadData(Product product)
        {
            if (product != null)
            {
                nameTextBox.Text = product.Name;
                priceTextBox.Text = product.Price.ToString();
                pictureBox.Image = Image.FromStream(new MemoryStream(product.Image));
            }

            if (mustBeEdited)
            {
                addButton.Visible = false;
            }
            else
            {
                editButton.Visible = false;
            }
        }
    }
}