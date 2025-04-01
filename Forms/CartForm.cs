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
            cartListView.Columns.Add("Продукт", 200);
            cartListView.Columns.Add("Цена", 200);
            cartListView.Columns.Add("Количество", 200);
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

            if (shopService.PlaceOrder(cartProducts))
            {
                User user = Session.CurrentUser;

                MessageBox.Show(
                                $"Вашата поръчка е приета!\n\n" +
                                $"Вашите данни за доставка:\n" +
                                $"👤 {user.FullName}\n" +
                                $"🏠 {user.Address}\n" +
                                $"📞 {user.PhoneNumber}\n" +
                                $"📧 {user.Email}",
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
    }
}