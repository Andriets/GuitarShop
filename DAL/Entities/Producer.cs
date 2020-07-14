using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Producer : BaseEntity
    {
        public string ProducerName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
