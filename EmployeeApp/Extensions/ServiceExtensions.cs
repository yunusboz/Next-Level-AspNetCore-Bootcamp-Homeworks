using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using Repositories;
using Services.Contracts;
using Services;
using FluentValidation;
using System.Reflection;
using FluentValidation.AspNetCore;
using System.ComponentModel.DataAnnotations;
using EmployeeApp.Validations;

namespace EmployeeApp.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositoryConfigurations(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RepositoryContext>(options => options.UseSqlServer(configuration.GetConnectionString("Northwind")));
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IRepositoryManager, RepositoryManager>();
            services.AddScoped<IOrderRepository, OrderRepository>();

            return services;
        }

        public static IServiceCollection AddServiceConfigurations(this IServiceCollection services)
        {
            services.AddScoped<IServiceManager, ServiceManager>();
            services.AddScoped<IEmployeeService, EmployeeManager>();
            services.AddScoped<IOrderService, OrderManager>();
            
            return services;
        }

        public static IServiceCollection AddDomainConfigurations(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation();
            services.AddValidatorsFromAssemblyContaining<EmployeeValidator>();
            return services;
        }
    }
}
