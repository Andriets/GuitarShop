using AutoMapper;
using BLL.DTO;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Mapping
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<NumberOfFrets, NumberOfFretsDTO>();
            CreateMap<NumberOfFretsDTO, NumberOfFrets>();

            CreateMap<Features, FeaturesDTO>();
            CreateMap<FeaturesDTO, Features>();

            CreateMap<LowerDeck, NumberOfFretsDTO>();
            CreateMap<NumberOfFretsDTO, LowerDeck>();

            CreateMap<NumberOfFrets, NumberOfFretsDTO>();
            CreateMap<NumberOfStrings, NumberOfStringsDTO>();

            CreateMap<Order, OrderDTO>();
            CreateMap<OrderDTO, Order>();

            CreateMap<OrderProduct, OrderProductDTO>();
            CreateMap<OrderProductDTO, OrderProduct>();

            CreateMap<OverlayFingerboard, OverlayFingerboardDTO>();
            CreateMap<OverlayFingerboardDTO, OverlayFingerboard>();

            CreateMap<Pegs, PegsDTO>();
            CreateMap<PegsDTO, Pegs>();

            CreateMap<Producer, ProducerDTO>();
            CreateMap<ProducerDTO, Producer>();

            CreateMap<ProducingCountry, ProducingCountryDTO>();
            CreateMap<ProducingCountryDTO, ProducingCountry>();

            CreateMap<Product, ProductDTO>();
            CreateMap<ProductDTO, Product>();

            CreateMap<SidePanel, SidePanelDTO>();
            CreateMap<SidePanelDTO, SidePanel>();

            CreateMap<Size, SizeDTO>();
            CreateMap<SizeDTO, Size>();

            CreateMap<TypeOfCorps, TypeOfCorpsDTO>();
            CreateMap<TypeOfCorpsDTO, TypeOfCorps>();

            CreateMap<UpperDeck, UpperDeckDTO>();
            CreateMap<UpperDeckDTO, UpperDeck>();

            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
        }
    }
}
