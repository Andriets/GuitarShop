using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IServices
{
    public interface IUpperDeckService
    {
        IEnumerable<UpperDeckDTO> GetAll();
        Task<UpperDeckDTO> GetById(int id);
        Task Insert(UpperDeckDTO obj);
        Task Update(UpperDeckDTO obj);
        Task<bool> Delete(int id);
    }
}
