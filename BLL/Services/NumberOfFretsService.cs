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
    public class NumberOfFretsService : INumberOfFretsService
    {
        IUnitOfWork UOW;
        IMapper _mapper;
        public NumberOfFretsService(IUnitOfWork unitOfWotk, IMapper mapper)
        {
            UOW = unitOfWotk;
            _mapper = mapper;
        }

        public async Task<bool> Delete(int id)
        {
            return await UOW. NumberOfFretsRepository.Delete(id);
        }

        public IEnumerable<NumberOfFretsDTO> GetAll()
        {
            var list = UOW.NumberOfFretsRepository.GetAll().ToList();
            return _mapper.Map<List<NumberOfFrets>, List<NumberOfFretsDTO>>(list);

        }

        public async Task<NumberOfFretsDTO> GetById(int id)
        {
            var model = await UOW.NumberOfFretsRepository.GetById(id);
            return _mapper.Map<NumberOfFrets, NumberOfFretsDTO>(model);
        }

        public async Task Insert(NumberOfFretsDTO obj)
        {
            var model = _mapper.Map<NumberOfFretsDTO, NumberOfFrets>(obj);
            await UOW.NumberOfFretsRepository.Insert(model);
        }

        public async Task Update(NumberOfFretsDTO obj)
        {
            var model = _mapper.Map<NumberOfFretsDTO, NumberOfFrets>(obj);
            await UOW.NumberOfFretsRepository.Update(model);
        }
    }
}
