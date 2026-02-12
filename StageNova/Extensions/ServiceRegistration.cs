using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StageNova.Data;
using StageNova.Models.DbConfiguration;
using StageNova.Services;
using StageNova.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageNova.Extensions
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddStageNovaServices(this IServiceCollection services)
        {
            services.AddDbContext<StageNovaDbContext>(options =>
                options.UseSqlServer(Configuration.ConnectionString));

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IPlayService, PlayService>();
            services.AddScoped<ITicketService, TicketService>();
            services.AddScoped<ISouvenirService, SouvenirService>();

            return services;
        }
    }
}
