﻿using LatinoNet.UseCasesPorts;
using Microsoft.Extensions.DependencyInjection;

namespace LatinoNet.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped<IGetAllProductsOutputPort, GetAllProductsPresenter>();
            services.AddScoped<ICreateProductOutputPort, CreateProductPresenter>();

            return services;
        }
    }
}