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
    public class LowerDeckService : ILowerDeckService
    {
        IUnitOfWork UOW;
        IMapper _mapper;
        public LowerDeckService(IUnitOfWork unitOfWotk, IMapper mapper)
        {
            UOW = unitOfWotk;
            _mapper = mapper;
        }

        public async Task<bool> Delete(int id)
        {
           return await UOW.LowerDeckRepository.Delete(id);
        }

        public IEnumerable<LowerDeckDTO> GetAll()
        {
            var list = UOW.LowerDeckRepository.GetAll().ToList();
            return _mapper.Map<List<LowerDeck>, List<LowerDeckDTO>>(list);

        }

        public async Task<LowerDeckDTO> GetById(int id)
        {
            var model = await UOW.LowerDeckRepository.GetById(id);
            return _mapper.Map<LowerDeck, LowerDeckDTO>(model);
        }

        public async Task Insert(LowerDeckDTO obj)
        {
            var model = _mapper.Map<LowerDeckDTO, LowerDeck>(obj);
            await UOW.LowerDeckRepository.Insert(model);
        }

        public async Task Update(LowerDeckDTO obj)
        {
            var model = _mapper.Map<LowerDeckDTO, LowerDeck>(obj);
            await UOW.LowerDeckRepository.Update(model);
        }
    }
}
