using DataBase.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Core.Services;
using DataBase.Repositories;

namespace WebApplication1
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
            services.AddScoped<IAnimalService, AnimalService>(); // Modificarea a fost aplicată aici
            services.AddScoped<IOwnerService, OwnerService>();
        }

        public static void AddRepository(this IServiceCollection services)
        {
            services.AddScoped<IOwnerRepository, OwnerRepository>();
            services.AddScoped<IAnimalRepository, AnimalRepository>(); // Modificarea a fost aplicată aici
            services.AddDbContext<ProjectDbContext>();
            services.AddScoped<DbContext, ProjectDbContext>();
        }
    }
}
