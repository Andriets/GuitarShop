using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IServices
{
    public interface IFeatureService
    {
        IEnumerable<FeaturesDTO> GetAll();
        Task<FeaturesDTO> GetById(int id);
        Task Insert(FeaturesDTO obj);
        Task Update(FeaturesDTO obj);
        Task Delete(int id);
    }
}
