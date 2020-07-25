using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IServices
{
    public interface INumberOfFretsService
    {
        IEnumerable<NumberOfFretsDTO> GetAll();
        Task<NumberOfFretsDTO> GetById(int id);
        Task Insert(NumberOfFretsDTO obj);
        Task Update(NumberOfFretsDTO obj);
        Task<bool> Delete(int id);
    }
}
