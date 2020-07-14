using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Features : BaseEntity
    {
        public string FeaturesName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
