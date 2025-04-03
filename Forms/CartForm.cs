using ToyShop.Entities;

namespace ToyShop.Forms
{
    public partial class CartForm : Form
    {
        private readonly ShopService shopService;

        public CartForm(ShopService shopService)
        {
            this.shopService = shopService;
            InitializeComponent();
            ConfigureListView();
            LoadCartProducts();
        }

        private void ConfigureListView()
        {
            cartListView.View = View.Details;
            cartListView.Columns.Add("Продукт", 194);
            cartListView.Columns.Add("Цена", 194);
            cartListView.Columns.Add("Количество", 194);
            cartListView.FullRowSelect = true;
            cartListView.GridLines = true;
        }

        private void LoadCartProducts()
        {
            List<Product> cartProducts = shopService.GetCartProducts();
            cartListView.Items.Clear();

            foreach (var product in cartProducts)
            {
                var listViewItem = new ListViewItem(product.Name);
                listViewItem.SubItems.Add($"{product.Price:F2} лв.");
                listViewItem.SubItems.Add(product.Quantity.ToString());
                cartListView.Items.Add(listViewItem);
            }
            UpdateTotalSum();
        }

        private void UpdateTotalSum()
        {
            decimal totalSum = shopService.GetCartProducts().Sum(p => (p.Price * p.Quantity));
            totalSumLabel.Text = $"Общо: {totalSum:F2} лв.";
        }

        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            List<Product> cartProducts = shopService.GetCartProducts();

            if (cartProducts.Count == 0)
            {
                MessageBox.Show("Количката ви е празна!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (shopService.PlaceOrder(cartProducts))
            {
                User user = Session.CurrentUser;

                string fullName = user.FullName;
                string address = user.Address;
                string phoneNumber = user.PhoneNumber;
                string email = user.Email;

                DialogResult result = MessageBox.Show(
                    $"Искате ли да използвате текущите си данни за доставка?\n" +
                    $"Вашите данни за доставка:\n" +
                    $"👤 {fullName}\n" +
                    $"🏠 {address}\n" +
                    $"📞 {phoneNumber}\n" +
                    $"📧 {email}\n" +
                    $"(Изберете 'Не', ако искате да въведете нов адрес)",
                    "Потвърждение на адреса",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Cancel)
                {
                    return;
                }

                if (result == DialogResult.No)
                {
                    using (ShippingForm shippingForm = new ShippingForm())
                    {
                        if (shippingForm.ShowDialog() == DialogResult.OK)
                        {
                            fullName = shippingForm.FullName;
                            address = shippingForm.Address;
                            phoneNumber = shippingForm.PhoneNumber;
                            email = shippingForm.Email;
                        }
                        else
                        {
                            return;
                        }
                    }
                }

                MessageBox.Show(
                                $"Поръчката ви е приета!\n" +
                                $"Вашите данни за доставка:\n" +
                                $"👤 {fullName}\n" +
                                $"🏠 {address}\n" +
                                $"📞 {phoneNumber}\n" +
                                $"📧 {email}",
                                "Успех",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                                );

                shopService.ClearCart();
                LoadCartProducts();
            }
            else
            {
                MessageBox.Show("Неуспешна поръчка!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearCartButton_Click(object sender, EventArgs e)
        {
            shopService.ClearCart();
            LoadCartProducts();
        } 
    }
}