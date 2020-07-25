using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IServices
{
    public interface ITypeOfCorpsService
    {
        IEnumerable<TypeOfCorpsDTO> GetAll();
        Task<TypeOfCorpsDTO> GetById(int id);
        Task Insert(TypeOfCorpsDTO obj);
        Task Update(TypeOfCorpsDTO obj);
        Task<bool> Delete(int id);
    }
}
