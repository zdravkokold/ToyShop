using ToyShop.Entities;

namespace ToyShop
{
    public class ShopService
    {
        private readonly ToyShopDbContext context;
        private List<Product> cart;

        public ShopService(ToyShopDbContext context)
        {
            this.context = context;
            cart = new List<Product>();
        }

        public bool AddProduct(Product product) 
        {
            if (Session.UserRole != "Admin")
            { 
                throw new UnauthorizedAccessException("Only admins can add products.");
            }

            context.Products.Add(product);
            context.SaveChanges();
            return true;
        }

        public bool UpdateProduct(Product product)
        {
            if (Session.UserRole != "Admin")
            {
                throw new UnauthorizedAccessException("Only admins can update products.");
            }

            context.Products.Update(product);
            context.SaveChanges();
            return true;
        }

        public bool DeleteProduct(int productId)
        {
            if (Session.UserRole != "Admin")
            {
                throw new UnauthorizedAccessException("Only admins can delete products.");
            }

            var product = context.Products.Find(productId);
            if (product == null) return false;

            context.Products.Remove(product);
            context.SaveChanges();
            return true;
        }

        public bool PlaceOrder(List<Product> cartItems)
        {
            User user = Session.CurrentUser;

            if (user == null) return false;

            var order = new Order
            {
                UserId = user.Id,                          
                CreatedOn = DateTime.Now,
                OrderDetails = new List<OrderDetail>()
            };

            foreach (var item in cartItems)
            {
                Product? product = context.Products.Find(item.Id);
                if (product == null) continue;

                order.OrderDetails.Add(new OrderDetail
                {
                    ProductId = item.Id,
                    Quantity = item.Quantity,
                    TotalPrice = product.Price * item.Quantity
                });
            }

            context.Orders.Add(order);
            context.SaveChanges();
            return true;
        }

        public List<User> GetUsers()
        {
            return context.Users.ToList();
        }

        public User GetUserById(string id)
        {
            return context.Users.First(e => e.Id == id);
        }

        public void UpdateUser(User user)
        {            
            context.Users.Update(user);
            context.SaveChanges();
        }

        public void DeleteUser(string id)
        {
            User user = context.Users.Find(id);

            if (user != null)
            {
                context.Users.Remove(user);
                context.SaveChanges();
            }
        }

        public decimal GetTotalSales() => context.OrderDetails.Sum(od => od.TotalPrice);

        public List<Product> GetAllProducts()
        {
            return context.Products.ToList();
        }

        public void AddProductToCart(Product product)
        {
            cart.Add(product);

            if (product.Quantity == 1)
            {
                MessageBox.Show("Успешно добавихте продукт във вашата количка!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (product.Quantity > 1)
            {
                MessageBox.Show($"Успешно добавихте {product.Quantity} продукта във вашата количка!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public List<Product> GetCartProducts() => cart;

        public void ClearCart() => cart.Clear();
    }
}