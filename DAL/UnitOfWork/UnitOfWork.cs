using DAL.Entities;
using DAL.Interfaces.IRepositories;
using DAL.Interfaces.IUnitOfWork;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private IColorRepository colorRepository;
        private IFeaturesRepository featuresRepository;
        private ILowerDeckRepository lowerDeckRepository;
        private INumberOfFretsRepository numberOfFretsRepository;
        private INumberOfStringsRepository numberOfStringsRepository;
        private IOrderProductRepository orderProductRepository;
        private IOrderRepository orderRepository;
        private IOverlayFingerboardRepository overlayFingerboardRepository;
        private IPegsRepository pegsRepository;
        private IProducerRepository producerRepository;
        private IProducingCountryRepository producingCountryRepository;
        private IProductRepository productRepository;
        private ISidePanelRepository sidePanelRepository;
        private ITypeOfCorpsRepository typeOfCorpsRepository;
        private IUpperDeckRepository upperDeckRepository;
        public UserManager<User> UserManager { get; set; }
        public SignInManager<User> SignInManager { get; set; }
        public UnitOfWork(IColorRepository colorRepository,
            IFeaturesRepository featuresRepository,
            ILowerDeckRepository lowerDeckRepository,
            INumberOfFretsRepository numberOfFretsRepository,
            INumberOfStringsRepository numberOfStringsRepository,
            IOrderProductRepository orderProductRepository,
            IOrderRepository orderRepository,
            IOverlayFingerboardRepository overlayFingerboardRepository,
            IPegsRepository pegsRepository,
            IProducerRepository producerRepository,
            IProducingCountryRepository producingCountryRepository,
            ISidePanelRepository sidePanelRepository,
            ITypeOfCorpsRepository typeOfCorpsRepository,
            IUpperDeckRepository upperDeckRepository,
            UserManager<User> userManager,
            SignInManager<User> signInManager)
        {
            this.colorRepository = colorRepository;
            this.featuresRepository = featuresRepository;
            this.lowerDeckRepository = lowerDeckRepository;
            this.numberOfFretsRepository = numberOfFretsRepository;
            this.numberOfStringsRepository = numberOfStringsRepository;
            this.orderProductRepository = orderProductRepository;
            this.orderRepository = orderRepository;
            this.overlayFingerboardRepository = overlayFingerboardRepository;
            this.pegsRepository = pegsRepository;
            this.producerRepository = producerRepository;
            this.producingCountryRepository = producingCountryRepository;
            this.sidePanelRepository = sidePanelRepository;
            this.typeOfCorpsRepository = typeOfCorpsRepository;
            this.upperDeckRepository = upperDeckRepository;
            UserManager = userManager;
            SignInManager = signInManager;
        }

        public IColorRepository ColorRepository => colorRepository;
        public IFeaturesRepository FeaturesRepository => featuresRepository;
        public ILowerDeckRepository LowerDeckRepository => lowerDeckRepository;
        public INumberOfFretsRepository NumberOfFretsRepository => numberOfFretsRepository;
        public INumberOfStringsRepository NumberOfStringsRepository => numberOfStringsRepository;
        public IOrderProductRepository OrderProductRepository => orderProductRepository;
        public IOrderRepository OrderRepository => orderRepository;
        public IOverlayFingerboardRepository OverlayFingerboardRepository => overlayFingerboardRepository;
        public IPegsRepository PegsRepository => pegsRepository;
        public IProducerRepository ProducerRepository => producerRepository;
        public IProducingCountryRepository ProducingCountryRepository => producingCountryRepository;
        public IProductRepository ProductRepository => productRepository;
        public ISidePanelRepository SidePanelRepository => sidePanelRepository;
        public ITypeOfCorpsRepository TypeOfCorpsRepository => typeOfCorpsRepository;
        public IUpperDeckRepository UpperDeckRepository => upperDeckRepository;
    }
}
