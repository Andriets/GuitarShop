using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IServices
{
    public interface IOrderProductService
    {
        IEnumerable<OrderProductDTO> GetAll();
        Task<OrderProductDTO> GetById(int id);
        Task Insert(OrderProductDTO obj);
        Task Update(OrderProductDTO obj);
        Task<bool> Delete(int id);
    }
}
