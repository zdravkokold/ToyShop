using System.ComponentModel;
using Microsoft.AspNetCore.Identity;

namespace ToyShop.Entities
{
    public class User : IdentityUser
    {
        [DisplayName("Име")]
        public string FullName { get; set; }

        [DisplayName("Адрес")]
        public string Address { get; set; }
    }
}