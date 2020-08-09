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
    public class GuitarTypeService : IGuitarTypeService
    {
        IUnitOfWork UOW;
        IMapper _mapper;
        public GuitarTypeService(IUnitOfWork unitOfWotk, IMapper mapper)
        {
            UOW = unitOfWotk;
            _mapper = mapper;
        }

        public async Task<bool> Delete(int id)
        {
            return await UOW.GuitarTypeRepository.Delete(id);
        }

        public IEnumerable<GuitarTypeDTO> GetAll()
        {
            var list = UOW.GuitarTypeRepository.GetAll().ToList();
            return _mapper.Map<List<GuitarType>, List<GuitarTypeDTO>>(list);

        }

        public async Task<GuitarTypeDTO> GetById(int id)
        {
            var model = await UOW.GuitarTypeRepository.GetById(id);
            return _mapper.Map<GuitarType, GuitarTypeDTO>(model);
        }

        public async Task Insert(GuitarTypeDTO obj)
        {
            var model = _mapper.Map<GuitarTypeDTO, GuitarType>(obj);
            await UOW.GuitarTypeRepository.Insert(model);
        }

        public async Task Update(GuitarTypeDTO obj)
        {
            var model = _mapper.Map<GuitarTypeDTO, GuitarType>(obj);
            await UOW.GuitarTypeRepository.Update(model);
        }
    }
}
