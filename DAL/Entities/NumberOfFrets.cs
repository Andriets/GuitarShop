using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class NumberOfFrets : BaseEntity
    {
        public int FretsNumber { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
