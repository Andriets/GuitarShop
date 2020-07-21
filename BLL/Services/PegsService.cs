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
    public class PegsService : IPegsService
    {
        IUnitOfWork UOW;
        IMapper _mapper;
        public PegsService(IUnitOfWork unitOfWotk, IMapper mapper)
        {
            UOW = unitOfWotk;
            _mapper = mapper;
        }

        public async Task Delete(int id)
        {
            await UOW.PegsRepository.Delete(id);
        }

        public IEnumerable<PegsDTO> GetAll()
        {
            var list = UOW.PegsRepository.GetAll().ToList();
            return _mapper.Map<List<Pegs>, List<PegsDTO>>(list);

        }

        public async Task<PegsDTO> GetById(int id)
        {
            var model = await UOW.PegsRepository.GetById(id);
            return _mapper.Map<Pegs, PegsDTO>(model);
        }

        public async Task Insert(PegsDTO obj)
        {
            var model = _mapper.Map<PegsDTO, Pegs>(obj);
            await UOW.PegsRepository.Insert(model);
        }

        public async Task Update(PegsDTO obj)
        {
            var model = _mapper.Map<PegsDTO, Pegs>(obj);
            await UOW.PegsRepository.Update(model);
        }
    }
}
