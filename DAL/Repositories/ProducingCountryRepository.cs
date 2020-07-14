using DAL.Context;
using DAL.Entities;
using DAL.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class ProducingCountryRepository : GenericRepository<ProducingCountry>, IProducingCountryRepository
    {
        public ProducingCountryRepository(ApplicationContext context) : base(context) { }
    }
}
