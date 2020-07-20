using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IServices
{
    public interface ILowerDeckService
    {
        IEnumerable<LowerDeckDTO> GetAll();
        Task<LowerDeckDTO> GetById(int id);
        Task Insert(LowerDeckDTO obj);
        Task Update(LowerDeckDTO obj);
        Task Delete(int id);
    }
}
