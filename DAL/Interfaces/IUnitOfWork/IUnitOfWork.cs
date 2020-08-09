using DAL.Entities;
using DAL.Interfaces.IRepositories;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces.IUnitOfWork
{
    public interface IUnitOfWork
    {
        IColorRepository ColorRepository { get; }
        IFeaturesRepository FeaturesRepository { get; }
        ILowerDeckRepository LowerDeckRepository { get; }
        INumberOfFretsRepository NumberOfFretsRepository { get; }
        INumberOfStringsRepository NumberOfStringsRepository { get; }
        IOrderProductRepository OrderProductRepository { get; }
        IOrderRepository OrderRepository { get; }
        IOverlayFingerboardRepository OverlayFingerboardRepository { get; }
        IPegsRepository PegsRepository { get; }
        IProducerRepository ProducerRepository { get; }
        IProducingCountryRepository ProducingCountryRepository { get; }
        IProductRepository ProductRepository { get; }
        ISidePanelRepository SidePanelRepository { get; }
        ISizeRepository SizeRepository { get; }
        IGuitarTypeRepository GuitarTypeRepository { get; }
        IUpperDeckRepository UpperDeckRepository { get; }
        UserManager<User> UserManager { get; }
        SignInManager<User> SignInManager { get; }
    }
}
