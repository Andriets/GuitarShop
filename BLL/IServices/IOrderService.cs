using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IServices
{
    public interface IOrderService
    {
        IEnumerable<OrderDTO> GetAll();
        Task<OrderDTO> GetById(int id);
        Task Insert(OrderDTO obj);
        Task Update(OrderDTO obj);
        Task<bool> Delete(int id);
    }
}
