using Infra.Interfaces;
using Services.Services.Authority.Mapper;
using Services.Services.Authority.Models;
using Services.Services.Third.Mapper;
using Services.Services.Third.Models;

namespace Services.Services.Authority
{
    public class AuthorityService : IAuthorityServie
    {
        private readonly IAuthorityInfra authorityInfra;

        public AuthorityService(IAuthorityInfra authorityInfra)
        {
            this.authorityInfra = authorityInfra;
        }

        public async Task<ResponseAuthorityServie> AuthorityAsync(RequestAutorithyService request)
        {
            return new AuthorityMap().MappResp(await authorityInfra.GetAsync(new AuthorityMap().MapReq(request)));
        }
    }
}
