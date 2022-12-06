using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archimedes.Entity.Identity
{
    public class Roles
    {
        public static readonly string Admin = "ADMIN";
        public static readonly string Customer = "CUSTOMER";

        public static readonly List<string> RoleList = new()
        {
            Admin,
            Customer
        };
    }
}
