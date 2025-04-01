using ToyShop.Entities;

namespace ToyShop
{
    public static class Session
    {
        public static User CurrentUser { get; set; }
        public static string UserName { get; set; }
        public static string UserRole { get; set; }
    }
}