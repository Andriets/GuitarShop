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
            CreateMap<Color, ColorDTO>()
                .ReverseMap();

            CreateMap<Features, FeaturesDTO>()
                .ReverseMap();

            CreateMap<LowerDeck, LowerDeckDTO>()
                 .ReverseMap();

            CreateMap<NumberOfFrets, NumberOfFretsDTO>()
                 .ReverseMap();

            CreateMap<NumberOfStrings, NumberOfStringsDTO>()
                 .ReverseMap();

            CreateMap<Order, OrderDTO>()
                 .ReverseMap();

            CreateMap<OrderProduct, OrderProductDTO>()
                 .ReverseMap();

            CreateMap<OverlayFingerboard, OverlayFingerboardDTO>()
                 .ReverseMap();

            CreateMap<Pegs, PegsDTO>()
                 .ReverseMap();

            CreateMap<Producer, ProducerDTO>()
                 .ReverseMap();

            CreateMap<ProducingCountry, ProducingCountryDTO>()
                 .ReverseMap();

            CreateMap<Product, ProductDTO>()
                 .ReverseMap();

            CreateMap<SidePanel, SidePanelDTO>()
                 .ReverseMap();

            CreateMap<Size, SizeDTO>()
                 .ReverseMap();

            CreateMap<GuitarType, GuitarTypeDTO>()
                 .ReverseMap();

            CreateMap<UpperDeck, UpperDeckDTO>()
                 .ReverseMap();

            CreateMap<User, UserDTO>()
                 .ReverseMap();
        }
    }
}
