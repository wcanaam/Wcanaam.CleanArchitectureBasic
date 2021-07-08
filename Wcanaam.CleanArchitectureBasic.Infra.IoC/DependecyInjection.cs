using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Wcanaam.CleanArchitectureBasic.Domain.Interfaces;
using Wcanaam.CleanArchitectureBasic.Infra.Data.Context;
using Wcanaam.CleanArchitectureBasic.Infra.Data.Repositories;

namespace Wcanaam.CleanArchitectureBasic.Infra.IoC {
    public  static class DependecyInjection {

        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("SqlServer"),
                b => b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }
    }
}
