using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IServices
{
    public interface IOverlayFingerboardService
    {
        IEnumerable<OverlayFingerboardDTO> GetAll();
        Task<OverlayFingerboardDTO> GetById(int id);
        Task Insert(OverlayFingerboardDTO obj);
        Task Update(OverlayFingerboardDTO obj);
        Task<bool> Delete(int id);
    }
}
