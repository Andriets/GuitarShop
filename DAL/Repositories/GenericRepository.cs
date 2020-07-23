using DAL.Context;
using DAL.Entities;
using DAL.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private ApplicationContext context = null;
        private DbSet<T> table = null;

        public GenericRepository(ApplicationContext context)
        {
            this.context = context;
            table = context.Set<T>();
        }

        public async Task Delete(int id)
        {
            var entity = table.SingleOrDefault(s => s.Id == id);
            var e = table.Remove(entity);
            await context.SaveChangesAsync();
        }

        public IEnumerable<T> GetAll()
        {
            var res = this.context.Set<T>();
            return res;
        }

        public async Task<T> GetById(int id)
        {
            return await table.SingleOrDefaultAsync(s => s.Id == id);
        }

        public async Task Insert(T obj)
        {
            table.Add(obj);
            await context.SaveChangesAsync();
        }

        public async Task Update(T obj)
        {
            var entity = await table.SingleOrDefaultAsync(s => s.Id == obj.Id);
            table.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
