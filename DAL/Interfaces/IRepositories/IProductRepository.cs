﻿using DAL.Entities;
using DAL.PagedList;
using DAL.QueryParameters;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces.IRepositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        IEnumerable<Product> GetProducts(ProductParameters productParameters);
    }
}
