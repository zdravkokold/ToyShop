using ToyShop.Forms;

namespace ToyShop
{
    public partial class HomeForm : Form
    {
        private readonly ToyShopDbContext context;
        private readonly ShopService shopService;

        public HomeForm(ToyShopDbContext context, ShopService shopService)
        {
            InitializeComponent();
            this.context = context;
            this.shopService = shopService;
            ShowFormInPanel(new ProductsForm(shopService.GetAllProducts(), shopService));
            HideButtonsIfNotAdmin();
        }

        private void ShowFormInPanel(Form form)
        {
            mainPanel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(form);
            form.Show();
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new UsersForm(shopService));
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new ProductsForm(shopService.GetAllProducts(), shopService));
        }

        private void HideButtonsIfNotAdmin()
        {
            if (Session.UserRole != "Admin")
            {
                usersButton.Visible = false;
            }
        }

        private void logOutBbutton_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm(context);
            loginForm.Show();

            this.Close();
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new CartForm(shopService));
        }
    }
}