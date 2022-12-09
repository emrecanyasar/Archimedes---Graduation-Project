using Archimedes.Entity.Abstract;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Entity
{
    public class AppUser : IdentityUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Mail { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<UserShopList> UserShopLists { get; set; }
    }
}
