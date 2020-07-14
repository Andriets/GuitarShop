using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Color : BaseEntity
    {
        public string ColorName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
