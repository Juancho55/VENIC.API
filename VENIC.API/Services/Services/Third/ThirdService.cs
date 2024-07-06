using Infra.Interfaces;
using Services.Services.Third.Mapper;
using Services.Services.Third.Models;

namespace Services.Services.Third
{
    public class ThirdService : IThirdService
    {
        private readonly IThrid thrid;

        public ThirdService(IThrid thrid)
        {
            this.thrid = thrid;
        }

        public async Task<bool> SaveThirdAsync(RequestModel request)
        {
            return await thrid.SaveAsync(new ThirdMap().MapReq(request));
        }

        public async Task<List<ResponseModel>> GetThirdsAsync(RequestModel request)
        {
            return new ThirdMap().MapResponse(await thrid.GetAsync(new ThirdMap().MapReq(request)));
        }
    }
}
