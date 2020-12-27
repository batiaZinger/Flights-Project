using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Repositories;

namespace Services
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IFlightService, FlightService>();
            services.AddScoped<IAirportService, AirportService>();
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddRepositories();
            return services;
        }
    }
}
