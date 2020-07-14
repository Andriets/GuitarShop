using DAL.Context;
using DAL.Entities;
using DAL.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class OrderProductRepository : GenericRepository<OrderProduct>, IOrderProductRepository
    {
        public OrderProductRepository(ApplicationContext context) : base(context) { }
    }
}
