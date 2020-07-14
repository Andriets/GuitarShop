using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class SidePanel : BaseEntity
    {
        public string SidePanelMaterial { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
