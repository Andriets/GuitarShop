using DAL.Context;
using DAL.Entities;
using DAL.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class SidePanelRepository : GenericRepository<SidePanel>, ISidePanelRepository
    {
        public SidePanelRepository(ApplicationContext context) : base(context) { }
    }
}
