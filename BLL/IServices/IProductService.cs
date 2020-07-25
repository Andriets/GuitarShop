using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IServices
{
    public interface IProductService
    {
        IEnumerable<ProductDTO> GetAll();
        Task<ProductDTO> GetById(int id);
        Task Insert(ProductDTO obj);
        Task Update(ProductDTO obj);
        Task<bool> Delete(int id);
    }
}
