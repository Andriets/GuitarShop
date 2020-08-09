using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IServices
{
    public interface IGuitarTypeService
    {
        IEnumerable<GuitarTypeDTO> GetAll();
        Task<GuitarTypeDTO> GetById(int id);
        Task Insert(GuitarTypeDTO obj);
        Task Update(GuitarTypeDTO obj);
        Task<bool> Delete(int id);
    }
}
