using AutoMapper;
using BLL.DTO;
using BLL.IServices;
using DAL.Entities;
using DAL.Interfaces.IUnitOfWork;
using DAL.PagedList;
using DAL.QueryParameters;
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

        public PagedList<ProductDTO> GetAll(ProductParameters productParameters)
        {
            var productList = UOW.ProductRepository.GetProducts(productParameters) ?? new PagedList<Product>();
            var colorList = UOW.ColorRepository.GetAll().ToList() ?? new List<Color>();
            var featuresList = UOW.FeaturesRepository.GetAll().ToList() ?? new List<Features>();
            var lowerDeckList = UOW.LowerDeckRepository.GetAll().ToList() ?? new List<LowerDeck>();
            var numberOfFretsList = UOW.NumberOfFretsRepository.GetAll().ToList() ?? new List<NumberOfFrets>();
            var numberOfStrings = UOW.NumberOfStringsRepository.GetAll().ToList() ?? new List<NumberOfStrings>();
            var overlayFingerboardList = UOW.OverlayFingerboardRepository.GetAll().ToList() ?? new List<OverlayFingerboard>();
            var pegsList = UOW.PegsRepository.GetAll().ToList() ?? new List<Pegs>();
            var producerList = UOW.ProducerRepository.GetAll().ToList() ?? new List<Producer>();
            var producingCountryList = UOW.ProducingCountryRepository.GetAll().ToList() ?? new List<ProducingCountry>();
            var sidePanelList = UOW.SidePanelRepository.GetAll().ToList() ?? new List<SidePanel>();
            var sizeList = UOW.SizeRepository.GetAll().ToList() ?? new List<Size>();
            var typeOfCorpsList = UOW.TypeOfCorpsRepository.GetAll().ToList() ?? new List<TypeOfCorps>();
            var upperDeckList = UOW.UpperDeckRepository.GetAll().ToList() ?? new List<UpperDeck>();
          
            var list = from prodl in productList
                       join fl in featuresList on prodl.FeaturesId equals fl.Id into pfg
                       from pf in pfg.DefaultIfEmpty()
                        
                       join cl in colorList on prodl.ColorId equals cl.Id into pcg
                       from pc in pcg.DefaultIfEmpty()

                       join ldl in lowerDeckList on prodl.LowerDeckId equals ldl.Id into pldg
                       from pld in pldg.DefaultIfEmpty()

                       join nofl in numberOfFretsList on prodl.NumberOfFretsId equals nofl.Id into pnofg
                       from pnof in pnofg.DefaultIfEmpty()

                       join nosl in numberOfStrings on prodl.NumberOfStringsId equals nosl.Id into pnosg
                       from pnos in pnosg.DefaultIfEmpty()

                       join ofl in overlayFingerboardList on prodl.OverlayFingerboardId equals ofl.Id into pofg
                       from pof in pofg.DefaultIfEmpty()

                       join pegsl in pegsList on prodl.PegsId equals pegsl.Id into ppg
                       from pp in ppg.DefaultIfEmpty()

                       join prl in producerList on prodl.ProducerId equals prl.Id into pprg
                       from ppr in pprg.DefaultIfEmpty()

                       join prcl in producingCountryList on prodl.ProducingCountryId equals prcl.Id into ppcg
                       from ppc in ppcg.DefaultIfEmpty()

                       join spl in sidePanelList on prodl.SidePanelId equals spl.Id into pspg
                       from psp in pspg.DefaultIfEmpty()

                       join sl in sizeList on prodl.SizeId equals sl.Id into psg
                       from ps in psg.DefaultIfEmpty()

                       join tocl in typeOfCorpsList on prodl.TypeOfCorpsId equals tocl.Id into ptocg
                       from ptoc in ptocg.DefaultIfEmpty()

                       join udl in upperDeckList on prodl.UpperDeckId equals udl.Id into pudg
                       from pud in pudg.DefaultIfEmpty()

                       select new
                       {
                           Id = prodl.Id,
                           ProductName = prodl.ProductName,
                           FeaturesName = pf?.FeaturesName,
                           Price = prodl.Price,
                           Description = prodl?.Description,
                           Image = prodl.Image,
                           ColorName = pc?.ColorName,
                           LoweDeckMaterial = pld?.LoweDeckMaterial,
                           FretsNumber = pnof?.FretsNumber,
                           StringsNumber = pnos?.StringsNumber,
                           OverlayFingerboardName = pof?.OverlayFingerboardName,
                           TypePegs = pp?.TypePegs,
                           ProducerName = ppr?.ProducerName,
                           Country = ppc?.Country,
                           SidePanelMaterial = psp?.SidePanelMaterial,
                           SizeName = ps?.SizeName,
                           TypeName = ptoc?.TypeName,
                           UpperDeckMaterial = pud?.UpperDeckMaterial
                       };
            List<ProductDTO> products = new List<ProductDTO>();
            foreach (var l in list)
            {
                ProductDTO productDTO = new ProductDTO
                {
                    Id = l.Id,
                    ProductName = l.ProducerName,
                    Price = l.Price,
                    Description = l.Description,
                    Image = l.Image,
                    Color = l.ColorName,
                    Features = l.FeaturesName,
                    LowerDeck = l.LoweDeckMaterial,
                    NumberOfFrets = l.FretsNumber,
                    NumberOfStrings = l.StringsNumber,
                    OverlayFingerboard = l.OverlayFingerboardName,
                    Pegs = l.TypePegs,
                    Producer = l.ProducerName,
                    ProducingCountry = l.Country,
                    SidePanel = l.SidePanelMaterial,
                    Size = l.SizeName,
                    TypeOfCorps = l.TypeName,
                    UpperDeck = l.UpperDeckMaterial
                };
                products.Add(productDTO);
            }
            return new PagedList<ProductDTO>(products, productList.Count, productList.CurrentPage, productList.PageSize);
        }

        public async Task<ProductDTO> GetById(int id)
        {
            var product = await UOW.ProductRepository.GetById(id);
            if (product != null)
            {
                var color = await UOW.ColorRepository.GetById((int)product.ColorId);
                var features = await UOW.FeaturesRepository.GetById((int)product.FeaturesId);
                var lowerDeck = await UOW.LowerDeckRepository.GetById((int)product.LowerDeckId);
                var numberOfFrets = await UOW.NumberOfFretsRepository.GetById((int)product.NumberOfFretsId);
                var numberOfStrings = await UOW.NumberOfStringsRepository.GetById((int)product.NumberOfStringsId);
                var overlayFingerboard = await UOW.OverlayFingerboardRepository.GetById((int)product.OverlayFingerboardId);
                var pegs = await UOW.PegsRepository.GetById((int)product.PegsId);
                var producer = await UOW.ProducerRepository.GetById((int)product.ProducerId);
                var producingCountry = await UOW.ProducingCountryRepository.GetById((int)product.ProducingCountryId);
                var sidePanel = await UOW.SidePanelRepository.GetById((int)product.SidePanelId);
                var size = await UOW.SizeRepository.GetById((int)product.SizeId);
                var typeOfCorps = await UOW.TypeOfCorpsRepository.GetById((int)product.TypeOfCorpsId);
                var upperDeck = await UOW.UpperDeckRepository.GetById((int)product.UpperDeckId);

                ProductDTO productDTO = new ProductDTO
                {
                    Id = product.Id,
                    ProductName = product.ProductName,
                    Price = product.Price,
                    Description = product.Description,
                    Image = product.Image,
                    Color = color?.ColorName,
                    Features = features?.FeaturesName,
                    LowerDeck = lowerDeck?.LoweDeckMaterial,
                    NumberOfFrets = numberOfFrets?.FretsNumber,
                    NumberOfStrings = numberOfStrings?.StringsNumber,
                    OverlayFingerboard = overlayFingerboard?.OverlayFingerboardName,
                    Pegs = pegs?.TypePegs,
                    Producer = producer?.ProducerName,
                    ProducingCountry = producingCountry?.Country,
                    SidePanel = sidePanel?.SidePanelMaterial,
                    Size = size?.SizeName,
                    TypeOfCorps = typeOfCorps?.TypeName,
                    UpperDeck = upperDeck?.UpperDeckMaterial
                };
                return productDTO;
            }
            else
            {
                return null;
            }
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
