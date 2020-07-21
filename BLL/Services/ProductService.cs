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
    public class ProductService : IProductService
    {
        IUnitOfWork UOW;
        IMapper _mapper;
        public ProductService(IUnitOfWork unitOfWotk, IMapper mapper)
        {
            UOW = unitOfWotk;
            _mapper = mapper;
        }

        public async Task Delete(int id)
        {
            await UOW.ProductRepository.Delete(id);
        }

        public IEnumerable<ProductDTO> GetAll()
        {
            var list = UOW.ProductRepository.GetAll().ToList();
            return _mapper.Map<List<Product>, List<ProductDTO>>(list);

        }

        public async Task<ProductDTO> GetById(int id)
        {
            var model = await UOW.ProductRepository.GetById(id);
            return _mapper.Map<Product, ProductDTO>(model);
        }

        public async Task Insert(ProductDTO obj)
        {
            var model = _mapper.Map<ProductDTO, Product>(obj);
            await UOW.ProductRepository.Insert(model);
        }

        public async Task Update(ProductDTO obj)
        {
            var model = _mapper.Map<ProductDTO, Product>(obj);
            await UOW.ProductRepository.Update(model);
        }
    }
}
