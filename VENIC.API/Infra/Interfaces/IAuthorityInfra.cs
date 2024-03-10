using Infra.Autority.Model;

namespace Infra.Interfaces
{
    public interface IAuthorityInfra
    {
        public Task<AuthorityResponse> GetAsync(AuthorityRequest authorityRequest);
    }
}
