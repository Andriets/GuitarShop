using DAL.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces.IRepositories
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        Task<T> GetById(int id);
        Task Insert(T obj);
        Task Update(T obj);
        Task<bool> Delete(int id);
    }
}
