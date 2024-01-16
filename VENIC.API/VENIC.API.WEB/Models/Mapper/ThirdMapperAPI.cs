using Infra.Thrid.Models;
using Services.Services.Third.Models;
using VENIC.API.WEB.Models.Third;

namespace VENIC.API.WEB.Models.Mapper
{
    public class ThirdMapperAPI
    {
        public RequestModel MapReq(RequestThirdModelAPI model)
        {
            return new RequestModel()
            {
                Active = true
            };
        }
    }
}
