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
    }
}
