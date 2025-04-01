namespace ToyShop.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedOn { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}