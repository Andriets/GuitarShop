using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class UpperDeck : BaseEntity
    {
        public string UpperDeckMaterial { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
