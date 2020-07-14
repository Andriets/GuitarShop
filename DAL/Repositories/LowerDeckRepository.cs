using DAL.Context;
using DAL.Entities;
using DAL.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class LowerDeckRepository : GenericRepository<LowerDeck>, ILowerDeckRepository
    {
        public LowerDeckRepository(ApplicationContext context) : base(context) { }
    }
}
