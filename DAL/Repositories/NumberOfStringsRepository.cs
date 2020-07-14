using DAL.Context;
using DAL.Entities;
using DAL.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class NumberOfStringsRepository : GenericRepository<NumberOfStrings>, INumberOfStringsRepository
    {
        public NumberOfStringsRepository(ApplicationContext context) : base(context) { }
    }
}
