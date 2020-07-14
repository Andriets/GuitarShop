using DAL.Context;
using DAL.Entities;
using DAL.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class OverlayFingerboardRepository : GenericRepository<OverlayFingerboard>, IOverlayFingerboardRepository
    {
        public OverlayFingerboardRepository(ApplicationContext context) : base(context) { }
    }
}
