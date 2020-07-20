using AutoMapper;
using BLL.DTO;
using BLL.IServices;
using DAL.Entities;
using DAL.Interfaces.IUnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class FeatureService : IFeatureService
    {
        IUnitOfWork UOW;
        IMapper _mapper;
        public FeatureService(IUnitOfWork unitOfWotk, IMapper mapper)
        {
            UOW = unitOfWotk;
        }

        public async Task Delete(int id)
        {
            await UOW.FeaturesRepository.Delete(id);
        }

        public IEnumerable<FeaturesDTO> GetAll()
        {
            var list = UOW.FeaturesRepository.GetAll().ToList();
            return _mapper.Map<List<Features>, List<FeaturesDTO>>(list);
        }

        public async Task<FeaturesDTO> GetById(int id)
        {
            var model = await UOW.FeaturesRepository.GetById(id);
            return _mapper.Map<Features, FeaturesDTO>(model);
        }

        public async Task Insert(FeaturesDTO obj)
        {
            var model = _mapper.Map<FeaturesDTO, Features>(obj);
            await UOW.FeaturesRepository.Insert(model);
        }

        public async Task Update(FeaturesDTO obj)
        {
            var model = _mapper.Map<FeaturesDTO, Features>(obj);
            await UOW.FeaturesRepository.Update(model);
        }
    }
}
