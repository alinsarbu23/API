using DataBase.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Core.Services;
using DataBase.Repositories;

namespace API
{
    public static class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddServices();
            services.AddRepository();
        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IOwnerService, OwnerService>();
            services.AddScoped<IAnimalService, AnimalService>();
        }

        public static void AddRepository(this IServiceCollection services)
        {
            services.AddScoped<IAnimalRepository, AnimalRepository>();
            services.AddScoped<IOwnerRepository, OwnerRepository>();
            services.AddDbContext<ProjectDbContext>();
            services.AddScoped<DbContext, ProjectDbContext>();
        }
    }
}
