using ToyShop.Entities;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;

namespace ToyShop.Forms
{
    public partial class LoginForm : Form
    {
        private readonly ToyShopDbContext context;
        private readonly ShopService shopService;

        public LoginForm(ToyShopDbContext context)
        {
            InitializeComponent();
            this.context = context;
            this.shopService = new ShopService(context);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usernameOrEmail = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(usernameOrEmail) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "Моля, въведете потребителско име и парола.";
                lblError.Visible = true;
                return;
            }

            User? user = context.Users.FirstOrDefault(u => (u.UserName == usernameOrEmail || u.Email == usernameOrEmail));

            if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
            {
                lblError.Text = "Грешно потребителско име или парола.";
                lblError.Visible = true;
                return;
            }

            string adminRoleId = context.Roles.FirstOrDefault(r => r.Name == "Admin")?.Id;

            Session.CurrentUser = user;
            Session.UserName = user.UserName;
            Session.UserRole = context.UserRoles.FirstOrDefault(ur => ur.UserId == user.Id && ur.RoleId == adminRoleId) != null ? "Admin" : "Client";

            this.Hide();
            HomeForm homeForm = new HomeForm(context, shopService);
            homeForm.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm(context, shopService);
            registerForm.Show();
        }
    }
}