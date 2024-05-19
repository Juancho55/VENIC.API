using Infra.Thrid.Models;

namespace Infra.Interfaces
{
    public interface IThirdType
    {
        public Task<List<ThirdTypeResponse>> GetThirdsTypes();
    }
}
