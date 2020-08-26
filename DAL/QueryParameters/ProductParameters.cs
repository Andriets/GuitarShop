using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities;

namespace DAL.QueryParameters
{
    public class ProductParameters : QueryStringParameters
    {
        public ProductParameters()
        {
            OrderBy = "price";
        }
        public double MinPrice { get; set; } = 0;
        public double MaxPrice { get; set; } = 1000000;
        public bool ValidPriceRange => MaxPrice > MinPrice && MinPrice >= 0;
        public string ProductName { get; set; }
        public string ColorNames { get; set; }
        public string Features { get; set; }
        public string GuitarTypes { get; set; }
        public string LowerDecks { get; set; }
        public string NumbersOfFrets { get; set; }
        public string NumbersOfStrings { get; set; }
        public string OverlayFingerboars { get; set; }
        public string Pegs { get; set; }
        public string Producers { get; set; }
        public string ProducingCounties { get; set; }
        public string SidePanels { get; set; }
        public string Sizes { get; set; }
        public string UpperDecks { get; set; }
    }
}
