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
    public class SizeService : ISizeService
    {
        IUnitOfWork UOW;
        IMapper _mapper;
        public SizeService(IUnitOfWork unitOfWotk, IMapper mapper)
        {
            UOW = unitOfWotk;
            _mapper = mapper;
        }

        public async Task Delete(int id)
        {
            await UOW.SizeRepository.Delete(id);
        }

        public IEnumerable<SizeDTO> GetAll()
        {
            var list = UOW.SizeRepository.GetAll().ToList();
            return _mapper.Map<List<Size>, List<SizeDTO>>(list);

        }

        public async Task<SizeDTO> GetById(int id)
        {
            var model = await UOW.SizeRepository.GetById(id);
            return _mapper.Map<Size, SizeDTO>(model);
        }

        public async Task Insert(SizeDTO obj)
        {
            var model = _mapper.Map<SizeDTO, Size>(obj);
            await UOW.SizeRepository.Insert(model);
        }

        public async Task Update(SizeDTO obj)
        {
            var model = _mapper.Map<SizeDTO, Size>(obj);
            await UOW.SizeRepository.Update(model);
        }
    }
}
