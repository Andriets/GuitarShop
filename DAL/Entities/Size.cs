using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Size : BaseEntity
    {
        public string SizeName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
