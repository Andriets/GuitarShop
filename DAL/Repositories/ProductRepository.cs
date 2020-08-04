using DAL.Context;
using DAL.Entities;
using DAL.Interfaces.IRepositories;
using DAL.PagedList;
using DAL.QueryParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationContext context) : base(context) { }
        public PagedList<Product> GetProducts(ProductParameters productParameters)
        {
            return PagedList<Product>.ToPagedList(GetAll().OrderBy(p => p.ProductName),
                productParameters.PageNumber,
                productParameters.PageSize);
        }
    }
}
