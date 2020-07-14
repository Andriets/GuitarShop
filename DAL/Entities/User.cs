using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System.Text;

namespace DAL.Entities
{
    public class User : IdentityUser
    {
        public byte[] Photo { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
