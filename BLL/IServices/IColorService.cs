using BLL.DTO;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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
        Task<bool> Delete(int id);
    }
}
