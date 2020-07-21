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
    public class OrderProductService : IOrderProductService
    {
        IUnitOfWork UOW;
        IMapper _mapper;
        public OrderProductService(IUnitOfWork unitOfWotk, IMapper mapper)
        {
            UOW = unitOfWotk;
            _mapper = mapper;
        }

        public async Task Delete(int id)
        {
            await UOW.OrderProductRepository.Delete(id);
        }

        public IEnumerable<OrderProductDTO> GetAll()
        {
            var list = UOW.OrderProductRepository.GetAll().ToList();
            return _mapper.Map<List<OrderProduct>, List<OrderProductDTO>>(list);

        }

        public async Task<OrderProductDTO> GetById(int id)
        {
            var model = await UOW.OrderProductRepository.GetById(id);
            return _mapper.Map<OrderProduct, OrderProductDTO>(model);
        }

        public async Task Insert(OrderProductDTO obj)
        {
            var model = _mapper.Map<OrderProductDTO, OrderProduct>(obj);
            await UOW.OrderProductRepository.Insert(model);
        }

        public async Task Update(OrderProductDTO obj)
        {
            var model = _mapper.Map<OrderProductDTO, OrderProduct>(obj);
            await UOW.OrderProductRepository.Update(model);
        }
    }
}
