using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IServices
{
    public interface IColorService
    {
        IEnumerable<ColorDTO> GetAll();
        Task<ColorDTO> GetById(int id);
        Task Insert(ColorDTO obj);
        Task Update(ColorDTO obj);
        Task Delete(int id);
    }
}
