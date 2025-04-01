using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ToyShop
{
    public class ToyShopDbContextFactory : IDesignTimeDbContextFactory<ToyShopDbContext>
    {
        public ToyShopDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ToyShopDbContext>();
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ToyShop;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;"); // Change conection string here during SetUp
                            // Change only here {----------------------};

            return new ToyShopDbContext(optionsBuilder.Options);
        }
    }
}
