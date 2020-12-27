using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddDbContext<Flights>(opt => opt.UseSqlServer(@"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\henri\\Documents\\Batia Zinger\\WebApi\\Project\\טיסות\\DB\\Flights.mdf;Integrated Security=True;Connect Timeout=30"));
            services.AddScoped<IFlightRepository, FlightRepository>();
            services.AddScoped<IAirportRepository, AirportRepository>();
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            return services;
        }
    }
}
