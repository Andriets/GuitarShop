using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Pegs : BaseEntity
    {
        public string TypePegs { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
