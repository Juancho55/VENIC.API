using Infra.Thrid.Models;
using Services.Services.ThirdType.Models;
using VENIC.API.WEB.Models.ThirdType;

namespace VENIC.API.WEB.Models.Mapper
{
    public class ThirdTypeMapperAPI
    {
        public List<ResponseThirdType> MappResp(List<ResponseModel> model)
        {
            List<ResponseThirdType> result = model.Select(s => new ResponseThirdType
            {
                Id = s.Id,
                Name = s.Name,
                Description = s.Description,
                Active = s.Active
            }).ToList();

            return result;
        }
    }
}
