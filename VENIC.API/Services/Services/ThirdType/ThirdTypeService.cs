using Infra.Interfaces;
using Services.Services.ThirdType.Mapper;
using Services.Services.ThirdType.Models;

namespace Services.Services.ThirdType
{
    public class ThirdTypeService : IThirdTypeService
    {
        private readonly IThirdType thirdType;

        public ThirdTypeService(IThirdType thirdType)
        {
            this.thirdType = thirdType;
        }

        public async Task<List<ResponseModel>> GetThirdsType()
        {
            return new ThirdTypeMap().MappResp(await thirdType.GetThirdsTypes());
        }
    }
}
