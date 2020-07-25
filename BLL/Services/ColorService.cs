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
    public class ColorService : IColorService
    {
        IUnitOfWork UOW;
        IMapper _mapper;
        public ColorService(IUnitOfWork unitOfWotk, IMapper mapper)
        {
            UOW = unitOfWotk;
            _mapper = mapper;
        }

        public async Task<bool> Delete(int id)
        {
            return await UOW.ColorRepository.Delete(id);
        }

        public IEnumerable<ColorDTO> GetAll()
        {
            var list = UOW.ColorRepository.GetAll().ToList();
            return _mapper.Map<List<Color>, List<ColorDTO>>(list);
        }

        public async Task<ColorDTO> GetById(int id)
        {
            var model = await UOW.ColorRepository.GetById(id);
            return _mapper.Map<Color, ColorDTO>(model);
        }

        public async Task Insert(ColorDTO obj)
        {
            var model = _mapper.Map<ColorDTO, Color>(obj);
            await UOW.ColorRepository.Insert(model);
        }

        public async Task Update(ColorDTO obj)
        {
            var model = _mapper.Map<ColorDTO, Color>(obj);
            await UOW.ColorRepository.Update(model);
        }
    }
}
