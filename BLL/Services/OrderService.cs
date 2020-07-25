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
    public class OrderService : IOrderService
    {
        IUnitOfWork UOW;
        IMapper _mapper;
        public OrderService(IUnitOfWork unitOfWotk, IMapper mapper)
        {
            UOW = unitOfWotk;
            _mapper = mapper;
        }

        public async Task<bool> Delete(int id)
        {
            return await UOW.OrderRepository.Delete(id);
        }

        public IEnumerable<OrderDTO> GetAll()
        {
            var list = UOW.OrderRepository.GetAll().ToList();
            return _mapper.Map<List<Order>, List<OrderDTO>>(list);

        }

        public async Task<OrderDTO> GetById(int id)
        {
            var model = await UOW.OrderRepository.GetById(id);
            return _mapper.Map<Order, OrderDTO>(model);
        }

        public async Task Insert(OrderDTO obj)
        {
            var model = _mapper.Map<OrderDTO, Order>(obj);
            await UOW.OrderRepository.Insert(model);
        }

        public async Task Update(OrderDTO obj)
        {
            var model = _mapper.Map<OrderDTO, Order>(obj);
            await UOW.OrderRepository.Update(model);
        }
    }
}
