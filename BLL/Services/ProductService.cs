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

        public async Task<bool> Delete(int id)
        {
            return await UOW.ProductRepository.Delete(id);
        }

        public IEnumerable<ProductDTO> GetAll()
        {
            var productList = UOW.ProductRepository.GetAll().ToList();
            var colorList = UOW.ColorRepository.GetAll().ToList();
            var lowerDeckList = UOW.LowerDeckRepository.GetAll().ToList();
            var numberOfFretsList = UOW.NumberOfFretsRepository.GetAll().ToList();
            var numberOfStrings = UOW.NumberOfStringsRepository.GetAll().ToList();
            var overlayFingerboardList = UOW.OverlayFingerboardRepository.GetAll().ToList();
            var pegsList = UOW.PegsRepository.GetAll().ToList();
            var producerList = UOW.ProducerRepository.GetAll().ToList();
            var producingCountryList = UOW.ProducingCountryRepository.GetAll().ToList();
            var sidePanelList = UOW.SidePanelRepository.GetAll().ToList();
            var sizeList = UOW.SizeRepository.GetAll().ToList();
            var typeOfCorpsList = UOW.TypeOfCorpsRepository.GetAll().ToList();
            var upperDeckList = UOW.UpperDeckRepository.GetAll().ToList();

            var list = from prodl in productList
                      join cl in colorList on prodl.ColorId equals cl.Id
                      join ldl in lowerDeckList on prodl.LowerDeckId equals ldl.Id
                      join nofl in numberOfFretsList on prodl.NumbetOfFretsId equals nofl.Id
                      join nosl in numberOfStrings on prodl.NumberOfStringsId equals nosl.Id
                      join ofl in overlayFingerboardList on prodl.OverlayFingerboardId equals ofl.Id
                      join pegsl in pegsList on prodl.PegsId equals pegsl.Id
                      join prl in producerList on prodl.ProducerId equals prl.Id
                      join prcl in producingCountryList on prodl.ProducingCountryId equals prcl.Id
                      join spl in sidePanelList on prodl.SidePanelId equals spl.Id
                      join sl in sizeList on prodl.SizeId equals sl.Id
                      join tocl in typeOfCorpsList on prodl.TypeOfCorpsId equals tocl.Id
                      join udl in upperDeckList on prodl.UpperDeckId equals udl.Id
                      select new
                      {
                          Id = prodl.Id,
                          ProductName = prodl.ProductName,
                          Price = prodl.Price,
                          Description = prodl.Description,
                          Image = prodl.Image,
                          ColorName = cl.ColorName,
                          LoweDeckMaterial = ldl.LoweDeckMaterial,
                          FretsNumber = nofl.FretsNumber,
                          StringsNumber = nosl.StringsNumber,
                          OverlayFingerboardName = ofl.OverlayFingerboardName,
                          TypePegs = pegsl.TypePegs,
                          ProducerName = prl.ProducerName,
                          Country = prcl.Country,
                          SidePanelMaterial = spl.SidePanelMaterial,
                          SizeName = sl.SizeName,
                          TypeName = tocl.TypeName,
                          UpperDeckMaterial = udl.UpperDeckMaterial
                      };
            return _mapper.Map<List<Product>, List<ProductDTO>>(productList);
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
