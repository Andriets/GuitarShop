using DAL.Context;
using DAL.Entities;
using DAL.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class ProducerRepository : GenericRepository<Producer>, IProducerRepository
    {
        public ProducerRepository(ApplicationContext context) : base(context) { }
    }
}
