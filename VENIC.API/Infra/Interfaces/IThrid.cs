using Infra.Thrid.Models;

namespace Infra.Interfaces
{
    public interface IThrid
    {
        public Task<bool> SaveAsync(ThirdRequest thirdCollection);
        public Task<bool> UpdateAsync(ThirdRequest thirdCollection);
        public Task<bool> DeleteAsync(long Id);
        public Task<ThirdResponse> GetAsync(ThirdRequest thirdCollection);
    }
}
