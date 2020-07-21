using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IServices
{
    public interface IProducingCountryService
    {
        IEnumerable<ProducingCountryDTO> GetAll();
        Task<ProducingCountryDTO> GetById(int id);
        Task Insert(ProducingCountryDTO obj);
        Task Update(ProducingCountryDTO obj);
        Task Delete(int id);
    }
}
