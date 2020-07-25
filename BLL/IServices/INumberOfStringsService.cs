using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IServices
{
    public interface INumberOfStringsService
    {
        IEnumerable<NumberOfStringsDTO> GetAll();
        Task<NumberOfStringsDTO> GetById(int id);
        Task Insert(NumberOfStringsDTO obj);
        Task Update(NumberOfStringsDTO obj);
        Task<bool> Delete(int id);
    }
}
