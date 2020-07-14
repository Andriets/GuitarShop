using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class NumberOfStrings : BaseEntity
    {
        public int StringsNumber { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
