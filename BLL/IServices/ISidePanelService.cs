using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IServices
{
    public interface ISidePanelService
    {
        IEnumerable<SidePanelDTO> GetAll();
        Task<SidePanelDTO> GetById(int id);
        Task Insert(SidePanelDTO obj);
        Task Update(SidePanelDTO obj);
        Task<bool> Delete(int id);
    }
}
