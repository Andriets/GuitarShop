using DAL.Context;
using DAL.Entities;
using DAL.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class GuitarTypeRepository : GenericRepository<GuitarType>, IGuitarTypeRepository
    {
        public GuitarTypeRepository(ApplicationContext context) : base(context) { }
    }
}
