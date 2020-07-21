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
    public class ProducingCountryService : IProducingCountryService
    {
        IUnitOfWork UOW;
        IMapper _mapper;
        public ProducingCountryService(IUnitOfWork unitOfWotk, IMapper mapper)
        {
            UOW = unitOfWotk;
            _mapper = mapper;
        }

        public async Task Delete(int id)
        {
            await UOW.ProducingCountryRepository.Delete(id);
        }

        public IEnumerable<ProducingCountryDTO> GetAll()
        {
            var list = UOW.ProducingCountryRepository.GetAll().ToList();
            return _mapper.Map<List<ProducingCountry>, List<ProducingCountryDTO>>(list);

        }

        public async Task<ProducingCountryDTO> GetById(int id)
        {
            var model = await UOW.ProducingCountryRepository.GetById(id);
            return _mapper.Map<ProducingCountry, ProducingCountryDTO>(model);
        }

        public async Task Insert(ProducingCountryDTO obj)
        {
            var model = _mapper.Map<ProducingCountryDTO, ProducingCountry>(obj);
            await UOW.ProducingCountryRepository.Insert(model);
        }

        public async Task Update(ProducingCountryDTO obj)
        {
            var model = _mapper.Map<ProducingCountryDTO, ProducingCountry>(obj);
            await UOW.ProducingCountryRepository.Update(model);
        }
    }
}
