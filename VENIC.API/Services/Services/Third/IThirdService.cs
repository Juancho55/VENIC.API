using Services.Services.Third.Models;

namespace Services.Services.Third
{
    public interface IThirdService
    {
        public Task<bool> SaveThirdAsync(RequestModel request);
    }
}
