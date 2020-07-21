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
    public class NumberOFStringsService : INumberOfStringsService
    {
        IUnitOfWork UOW;
        IMapper _mapper;
        public NumberOFStringsService(IUnitOfWork unitOfWotk, IMapper mapper)
        {
            UOW = unitOfWotk;
            _mapper = mapper;
        }

        public async Task Delete(int id)
        {
            await UOW.NumberOfStringsRepository.Delete(id);
        }

        public IEnumerable<NumberOfStringsDTO> GetAll()
        {
            var list = UOW.NumberOfStringsRepository.GetAll().ToList();
            return _mapper.Map<List<NumberOfStrings>, List<NumberOfStringsDTO>>(list);

        }

        public async Task<NumberOfStringsDTO> GetById(int id)
        {
            var model = await UOW.NumberOfStringsRepository.GetById(id);
            return _mapper.Map<NumberOfStrings, NumberOfStringsDTO>(model);
        }

        public async Task Insert(NumberOfStringsDTO obj)
        {
            var model = _mapper.Map<NumberOfStringsDTO, NumberOfStrings>(obj);
            await UOW.NumberOfStringsRepository.Insert(model);
        }

        public async Task Update(NumberOfStringsDTO obj)
        {
            var model = _mapper.Map<NumberOfStringsDTO, NumberOfStrings>(obj);
            await UOW.NumberOfStringsRepository.Update(model);
        }
    }
}
