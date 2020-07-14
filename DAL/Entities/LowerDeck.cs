using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class LowerDeck : BaseEntity
    {
        public string LoweDeckMaterial { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
