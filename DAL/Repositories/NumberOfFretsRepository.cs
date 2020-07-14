using DAL.Context;
using DAL.Entities;
using DAL.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class NumberOfFretsRepository : GenericRepository<NumberOfFrets>, INumberOfFretsRepository
    {
        public NumberOfFretsRepository(ApplicationContext context) : base(context) { }
    }
}
