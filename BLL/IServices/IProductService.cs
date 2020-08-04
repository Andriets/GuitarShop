using BLL.DTO;
using DAL.PagedList;
using DAL.QueryParameters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IServices
{
    public interface IProductService
    {
        PagedList<ProductDTO> GetAll(ProductParameters productParameters);
        Task<ProductDTO> GetById(int id);
        Task Insert(ProductDTO obj);
        Task Update(ProductDTO obj);
        Task<bool> Delete(int id);
    }
}
