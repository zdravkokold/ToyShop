using ToyShop.Entities;

namespace ToyShop.Forms
{
    public partial class RegisterForm : Form
    {
        private readonly ToyShopDbContext context;
        private readonly ShopService shopService;

        public RegisterForm(ToyShopDbContext context, ShopService shopService)
        {
            InitializeComponent();
            this.context = context;
            this.shopService = shopService;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string fullName = nameTextBox.Text.Trim();
            string phone = phoneTextBox.Text.Trim();
            string email = txtEmail.Text.Trim();
            string address = txtAddress.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(address) ||
                string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                lblError.Text = "Всички полета са задължителни!";
                lblError.Visible = true;
                return;
            }

            if (password != confirmPassword)
            {
                lblError.Text = "Паролите не съвпадат!";
                lblError.Visible = true;
                return;
            }

            if (context.Users.Any(u => u.UserName == username || u.Email == email))
            {
                lblError.Text = "Този потребител вече съществува!";
                lblError.Visible = true;
                return;
            }

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            User newUser = new User
            {
                UserName = username,
                FullName = fullName,
                PhoneNumber = phone,
                Address = address,
                Email = email,
                PasswordHash = hashedPassword
            };

            context.Users.Add(newUser);
            context.SaveChanges();

            MessageBox.Show("Регистрацията е успешна!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            HomeForm homeForm = new HomeForm(context, shopService);
            homeForm.Show();
        }
    }
}
