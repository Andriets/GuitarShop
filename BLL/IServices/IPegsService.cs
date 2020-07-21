using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IServices
{
    public interface IPegsService
    {
        IEnumerable<PegsDTO> GetAll();
        Task<PegsDTO> GetById(int id);
        Task Insert(PegsDTO obj);
        Task Update(PegsDTO obj);
        Task Delete(int id);
    }
}
