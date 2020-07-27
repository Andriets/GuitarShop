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
        public int ProducerId { get; set; }
        public NumberOfStrings NumberOfStrings { get; set; }
        public int NumberOfStringsId { get; set; }
        public NumberOfFrets NumberOfFrets { get; set; }
        public int NumbetOfFretsId { get; set; }
        public TypeOfCorps TypeOfCorps { get; set; }
        public int TypeOfCorpsId { get; set; }
        public Pegs Pegs { get; set; }
        public int PegsId { get; set; }
        public UpperDeck UpperDeck { get; set; }
        public int UpperDeckId { get; set; }
        public LowerDeck LowerDeck { get; set; }
        public int LowerDeckId { get; set; }
        public SidePanel SidePanel { get; set; }
        public int SidePanelId { get; set; }
        public Features Features { get; set; }
        public int FeaturesId { get; set; }
        public Color Color { get; set; }
        public int ColorId { get; set; }
        public OverlayFingerboard OverlayFingerboard { get; set; }
        public int OverlayFingerboardId { get; set; }
        public Size Size { get; set; }
        public int SizeId { get; set; }
        public ProducingCountry ProducingCountry { get; set; }
        public int ProducingCountryId { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
