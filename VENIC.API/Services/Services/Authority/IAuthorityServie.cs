using Services.Services.Authority.Models;

namespace Services.Services.Authority
{
    public interface IAuthorityServie
    {
        public Task<ResponseAuthorityServie> AuthorityAsync(RequestAutorithyService request);
    }
}
