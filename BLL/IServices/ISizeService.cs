using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IServices
{
    public interface ISizeService
    {
        IEnumerable<SizeDTO> GetAll();
        Task<SizeDTO> GetById(int id);
        Task Insert(SizeDTO obj);
        Task Update(SizeDTO obj);
        Task<bool> Delete(int id);
    }
}
