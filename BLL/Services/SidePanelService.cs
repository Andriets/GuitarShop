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
    public class SidePanelService : ISidePanelService
    {
        IUnitOfWork UOW;
        IMapper _mapper;
        public SidePanelService(IUnitOfWork unitOfWotk, IMapper mapper)
        {
            UOW = unitOfWotk;
            _mapper = mapper;
        }

        public async Task Delete(int id)
        {
            await UOW.SidePanelRepository.Delete(id);
        }

        public IEnumerable<SidePanelDTO> GetAll()
        {
            var list = UOW.SidePanelRepository.GetAll().ToList();
            return _mapper.Map<List<SidePanel>, List<SidePanelDTO>>(list);

        }

        public async Task<SidePanelDTO> GetById(int id)
        {
            var model = await UOW.SidePanelRepository.GetById(id);
            return _mapper.Map<SidePanel, SidePanelDTO>(model);
        }

        public async Task Insert(SidePanelDTO obj)
        {
            var model = _mapper.Map<SidePanelDTO, SidePanel>(obj);
            await UOW.SidePanelRepository.Insert(model);
        }

        public async Task Update(SidePanelDTO obj)
        {
            var model = _mapper.Map<SidePanelDTO, SidePanel>(obj);
            await UOW.SidePanelRepository.Update(model);
        }
    }
}
