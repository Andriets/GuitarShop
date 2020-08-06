using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BLL.IServices;
using BLL.Mapping;
using BLL.Services;
using DAL.Context;
using DAL.Entities;
using DAL.Interfaces.IRepositories;
using DAL.Interfaces.ISortHelper;
using DAL.Interfaces.IUnitOfWork;
using DAL.Repositories;
using DAL.SortHelper;
using DAL.UnitOfWork;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace GuitarShop
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddTransient<ApplicationContext>();

            services.AddIdentity<User, IdentityRole>()
            .AddEntityFrameworkStores<ApplicationContext>();

            services.AddAutoMapper(typeof(Mapping));

            #region Repositories

            services.AddTransient<IColorRepository, ColorRepository>();
            services.AddTransient<IFeaturesRepository, FeaturesRepository>();
            services.AddTransient<ILowerDeckRepository, LowerDeckRepository>();
            services.AddTransient<INumberOfFretsRepository, NumberOfFretsRepository>();
            services.AddTransient<INumberOfStringsRepository, NumberOfStringsRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IOrderProductRepository, OrderProductRepository>();
            services.AddTransient<IOverlayFingerboardRepository, OverlayFingerboardRepository>();
            services.AddTransient<IPegsRepository, PegsRepository>();
            services.AddTransient<IProducerRepository, ProducerRepository>();
            services.AddTransient<IProducingCountryRepository, ProducingCountryRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<ISidePanelRepository, SidePanelRepository>();
            services.AddTransient<ISizeRepository, SizeRepository>();
            services.AddTransient<ITypeOfCorpsRepository, TypeOfCorpsRepository>();
            services.AddTransient<IUpperDeckRepository, UpperDeckRepository>();

            #endregion
            services.AddTransient<ISortHelper<Product>, SortHelper<Product>>();

            #region Services

            services.AddTransient<IColorService, ColorService>();
            services.AddTransient<IFeatureService, FeatureService>();
            services.AddTransient<ILowerDeckService, LowerDeckService>();
            services.AddTransient<INumberOfFretsService, NumberOfFretsService>();
            services.AddTransient<INumberOfStringsService, NumberOFStringsService>();
            services.AddTransient<IOrderProductService, OrderProductService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IOverlayFingerboardService, OverlayFingerboardService>();
            services.AddTransient<IPegsService, PegsService>();
            services.AddTransient<IProducerService, ProducerService>();
            services.AddTransient<IProducingCountryService, ProducingCountryService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<ISidePanelService, SidePanelService>();
            services.AddTransient<ISizeService, SizeService>();
            services.AddTransient<ITypeOfCorpsService, TypeOfCorpsService>();
            services.AddTransient<IUpperDeckService, UpperDeckService>();

            #endregion

            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
