using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class GuitarType : BaseEntity
    {
        public string TypeName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
