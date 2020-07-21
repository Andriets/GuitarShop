using AutoMapper;
using BLL.DTO;
using DAL.Entities;
using DAL.Interfaces.IUnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ProducerService : IProducerService
    {
        IUnitOfWork UOW;
        IMapper _mapper;
        public ProducerService(IUnitOfWork unitOfWotk, IMapper mapper)
        {
            UOW = unitOfWotk;
            _mapper = mapper;
        }

        public async Task Delete(int id)
        {
            await UOW.ProducerRepository.Delete(id);
        }

        public IEnumerable<ProducerDTO> GetAll()
        {
            var list = UOW.ProducerRepository.GetAll().ToList();
            return _mapper.Map<List<Producer>, List<ProducerDTO>>(list);

        }

        public async Task<ProducerDTO> GetById(int id)
        {
            var model = await UOW.ProducerRepository.GetById(id);
            return _mapper.Map<Producer, ProducerDTO>(model);
        }

        public async Task Insert(ProducerDTO obj)
        {
            var model = _mapper.Map<ProducerDTO, Producer>(obj);
            await UOW.ProducerRepository.Insert(model);
        }

        public async Task Update(ProducerDTO obj)
        {
            var model = _mapper.Map<ProducerDTO, Producer>(obj);
            await UOW.ProducerRepository.Update(model);
        }
    }
}
