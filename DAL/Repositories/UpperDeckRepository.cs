using DAL.Context;
using DAL.Entities;
using DAL.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class UpperDeckRepository : GenericRepository<UpperDeck>, IUpperDeckRepository
    {
        public UpperDeckRepository(ApplicationContext context) : base(context) { }
    }
}
