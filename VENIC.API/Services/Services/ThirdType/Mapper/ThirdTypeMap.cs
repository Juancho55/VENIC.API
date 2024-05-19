using Infra.Thrid.Models;
using Services.Services.ThirdType.Models;

namespace Services.Services.ThirdType.Mapper
{
    public class ThirdTypeMap
    {
        public List<ResponseModel> MappResp(List<ThirdTypeResponse> model)
        {
            List<ResponseModel> result = model.Select(s => new ResponseModel
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
