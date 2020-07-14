using DAL.Context;
using DAL.Entities;
using DAL.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class FeaturesRepository : GenericRepository<Features>, IFeaturesRepository
    {
        public FeaturesRepository(ApplicationContext context) : base(context) { }
    }
}
