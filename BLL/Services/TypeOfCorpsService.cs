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
    public class TypeOfCorpsService : ITypeOfCorpsService
    {
        IUnitOfWork UOW;
        IMapper _mapper;
        public TypeOfCorpsService(IUnitOfWork unitOfWotk, IMapper mapper)
        {
            UOW = unitOfWotk;
            _mapper = mapper;
        }

        public async Task Delete(int id)
        {
            await UOW.TypeOfCorpsRepository.Delete(id);
        }

        public IEnumerable<TypeOfCorpsDTO> GetAll()
        {
            var list = UOW.TypeOfCorpsRepository.GetAll().ToList();
            return _mapper.Map<List<TypeOfCorps>, List<TypeOfCorpsDTO>>(list);

        }

        public async Task<TypeOfCorpsDTO> GetById(int id)
        {
            var model = await UOW.TypeOfCorpsRepository.GetById(id);
            return _mapper.Map<TypeOfCorps, TypeOfCorpsDTO>(model);
        }

        public async Task Insert(TypeOfCorpsDTO obj)
        {
            var model = _mapper.Map<TypeOfCorpsDTO, TypeOfCorps>(obj);
            await UOW.TypeOfCorpsRepository.Insert(model);
        }

        public async Task Update(TypeOfCorpsDTO obj)
        {
            var model = _mapper.Map<TypeOfCorpsDTO, TypeOfCorps>(obj);
            await UOW.TypeOfCorpsRepository.Update(model);
        }
    }
}
