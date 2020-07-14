using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class OverlayFingerboard : BaseEntity
    {
        public string OverlayFingerboardName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
