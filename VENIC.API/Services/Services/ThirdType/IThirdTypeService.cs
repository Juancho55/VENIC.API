using Services.Services.Third.Models;
using Services.Services.ThirdType.Models;

namespace Services.Services.ThirdType
{
    public interface IThirdTypeService
    {
        public Task<List<ResponseModel>> GetThirdsType();
    }
}
