using Services.Services.Third.Models;

namespace Services.Services.Third
{
    public interface IThirdService
    {
        public Task<bool> SaveThirdAsync(RequestModel request);
        public Task<List<ResponseModel>> GetThirdsAsync(RequestModel request);
    }
}
