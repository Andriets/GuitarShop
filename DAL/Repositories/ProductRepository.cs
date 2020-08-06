using DAL.Context;
using DAL.Entities;
using DAL.Interfaces.IRepositories;
using DAL.Interfaces.ISortHelper;
using DAL.PagedList;
using DAL.QueryParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DAL.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private ISortHelper<Product> _sortHelper;

        public ProductRepository(ApplicationContext context, ISortHelper<Product> sortHelper) : base(context) 
        {
            _sortHelper = sortHelper;
        }
        public PagedList<Product> GetProducts(ProductParameters productParameters)
        {
            var products = GetAll();

            var sorterProducts = _sortHelper.ApplySort(products, productParameters.OrderBy);

            return PagedList<Product>.ToPagedList(sorterProducts,
                productParameters.PageNumber,
                productParameters.PageSize);
        }
    }
}
