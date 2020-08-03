using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public string Producer { get; set; }
        public int? NumberOfStrings { get; set; }
        public int? NumberOfFrets { get; set; }
        public string TypeOfCorps { get; set; }
        public string Pegs { get; set; }
        public string UpperDeck { get; set; }
        public string LowerDeck { get; set; }
        public string SidePanel { get; set; }
        public string Color { get; set; }
        public string OverlayFingerboard { get; set; }
        public string Size { get; set; }
        public string ProducingCountry { get; set; }
        public string Features { get; set; }
    }
}
