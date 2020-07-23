using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public Producer Producer { get; set; }
        public NumberOfStrings NumberOfStrings { get; set; }
        public NumberOfFrets NumberOfFrets { get; set; }
        public TypeOfCorps TypeOfCorps { get; set; }
        public Pegs Pegs { get; set; }
        public UpperDeck UpperDeck { get; set; }
        public LowerDeck LowerDeck { get; set; }
        public SidePanel SidePanel { get; set; }
        public Features Features { get; set; }
        public Color Color { get; set; }
        public OverlayFingerboard OverlayFingerboard { get; set; }
        public Size Size { get; set; }
        public ProducingCountry ProducingCountry { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
