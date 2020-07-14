using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class ProducingCountry : BaseEntity
    {
        public string Country { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
