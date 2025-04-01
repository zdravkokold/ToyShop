using ToyShop.Forms;
using ToyShop.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ToyShop
{
    internal static class Program
    {
        public static UserManager<User> UserManager;
        public static SignInManager<User> SignInManager;
        public static RoleManager<IdentityRole> RoleManager;

        [STAThread]
        static void Main() // The starting point of the application
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ServiceCollection services = new ServiceCollection();
            services.AddDbContext<ToyShopDbContext>(options =>
                options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ToyShop;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;")); // Change conection string here during SetUp

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<ToyShopDbContext>()
                .AddDefaultTokenProviders();

            services.AddLogging();
            ServiceProvider serviceProvider = services.BuildServiceProvider();
            ToyShopDbContext dbContext = serviceProvider.GetRequiredService<ToyShopDbContext>();

            UserManager = serviceProvider.GetRequiredService<UserManager<User>>();
            SignInManager = serviceProvider.GetRequiredService<SignInManager<User>>();
            RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            EnsureRolesExistAsync().GetAwaiter().GetResult();
            SeedAdminUser(dbContext).GetAwaiter().GetResult();

            Application.Run(new LoginForm(dbContext));
        }

        private static async Task EnsureRolesExistAsync() // Creating Roles
        {
            if (!await RoleManager.RoleExistsAsync("Admin"))
            {
                await RoleManager.CreateAsync(new IdentityRole("Admin"));
            }

            if (!await RoleManager.RoleExistsAsync("Client"))
            {
                await RoleManager.CreateAsync(new IdentityRole("Client"));
            }
        }

        private static async Task SeedAdminUser(ToyShopDbContext context) // Creating Admin User
        {
            string adminUserName = "admin";
            string adminEmail = "admin@gmail.com";
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword("123456");

            User? adminUser = context.Users.FirstOrDefault(u => (u.UserName == adminUserName && u.Email == adminEmail));

            if (adminUser == null)
            {
                User user = new User
                {
                    UserName = adminUserName,
                    Email = adminEmail,
                    FullName = "Admin Adminov",
                    PhoneNumber = "0878980999",
                    Address = "ul. Pirotska 22, Sofia",
                    PasswordHash = hashedPassword
                };

                context.Users.Add(user);
                context.SaveChanges();

                await UserManager.AddToRoleAsync(user, "Admin");
            }
        }
    }
}