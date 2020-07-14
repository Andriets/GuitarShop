using DAL.Context;
using DAL.Entities;
using DAL.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class PegsRepository : GenericRepository<Pegs>, IPegsRepository
    {
        public PegsRepository(ApplicationContext context) : base(context) { }
    }
}
