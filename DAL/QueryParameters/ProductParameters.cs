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
    }
}
