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
    public class UpperDeckService : IUpperDeckService
    {
        IUnitOfWork UOW;
        IMapper _mapper;
        public ColorService(IUnitOfWork unitOfWotk, IMapper mapper)
        {
            UOW = unitOfWotk;
            _mapper = mapper;
        }

        public async Task Delete(int id)
        {
            await UOW.UpperDeckRepository.Delete(id);
        }

        public IEnumerable<UpperDeckDTO> GetAll()
        {
            var list = UOW.UpperDeckRepository.GetAll().ToList();
            return _mapper.Map<List<UpperDeck>, List<UpperDeckDTO>>(list);

        }

        public async Task<UpperDeckDTO> GetById(int id)
        {
            var model = await UOW.UpperDeckRepository.GetById(id);
            return _mapper.Map<UpperDeck, UpperDeckDTO>(model);
        }

        public async Task Insert(UpperDeckDTO obj)
        {
            var model = _mapper.Map<UpperDeckDTO, UpperDeck>(obj);
            await UOW.UpperDeckRepository.Insert(model);
        }

        public async Task Update(UpperDeckDTO obj)
        {
            var model = _mapper.Map<UpperDeckDTO, UpperDeck>(obj);
            await UOW.UpperDeckRepository.Update(model);
        }
    }
}
