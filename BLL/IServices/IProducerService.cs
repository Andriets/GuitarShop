using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface IProducerService
    {
        IEnumerable<ProducerDTO> GetAll();
        Task<ProducerDTO> GetById(int id);
        Task Insert(ProducerDTO obj);
        Task Update(ProducerDTO obj);
        Task Delete(int id);
    }
}
