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
    public class OverlayFingerboardService : IOverlayFingerboardService
    {
        IUnitOfWork UOW;
        IMapper _mapper;
        public OverlayFingerboardService(IUnitOfWork unitOfWotk, IMapper mapper)
        {
            UOW = unitOfWotk;
            _mapper = mapper;
        }

        public async Task<bool> Delete(int id)
        {
            return await UOW.OverlayFingerboardRepository.Delete(id);
        }

        public IEnumerable<OverlayFingerboardDTO> GetAll()
        {
            var list = UOW.OverlayFingerboardRepository.GetAll().ToList();
            return _mapper.Map<List<OverlayFingerboard>, List<OverlayFingerboardDTO>>(list);

        }

        public async Task<OverlayFingerboardDTO> GetById(int id)
        {
            var model = await UOW.OverlayFingerboardRepository.GetById(id);
            return _mapper.Map<OverlayFingerboard, OverlayFingerboardDTO>(model);
        }

        public async Task Insert(OverlayFingerboardDTO obj)
        {
            var model = _mapper.Map<OverlayFingerboardDTO, OverlayFingerboard>(obj);
            await UOW.OverlayFingerboardRepository.Insert(model);
        }

        public async Task Update(OverlayFingerboardDTO obj)
        {
            var model = _mapper.Map<OverlayFingerboardDTO, OverlayFingerboard>(obj);
            await UOW.OverlayFingerboardRepository.Update(model);
        }
    }
}
