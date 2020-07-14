using DAL.Context;
using DAL.Entities;
using DAL.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class TypeOfCorpsRepository : GenericRepository<TypeOfCorps>, ITypeOfCorpsRepository
    {
        public TypeOfCorpsRepository(ApplicationContext context) : base(context) { }
    }
}
