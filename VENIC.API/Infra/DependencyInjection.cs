using Business.ADO;
using Business.ADO.Interface;
using Infra.Autority;
using Infra.Interfaces;
using Infra.Thrid;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infra
{
    public static class DependencyInjection
    {
        public static void AddInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IVenicContext, VenicContext>(db => new VenicContext(configuration, "VenicConnectionString"));
            services.AddSingleton<IThrid, Third>();
            services.AddSingleton<IAuthorityInfra, AuthorityInfra>();
            services.AddSingleton<IThirdType, ThirdType>();
        }
    }
}
