using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Services.Services.Authority;
using Services.Services.Third;
using Services.Services.ThirdType;
using System.Reflection;

namespace Services
{
    public static class DependencyInjection
    {
        public static void AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddSingleton<IThirdService, ThirdService>();
            services.AddSingleton<IAuthorityServie, AuthorityService>();
            services.AddSingleton<IThirdTypeService, ThirdTypeService>();
        }
    }
}
