using Infra.Thrid.Models;
using Services.Services.DocumentType.Models;

namespace Services.Services.DocumentType.Mapper
{
    public class DocumentTypeMap
    {
        public List<ResponseModel> MappResp(List<DocumentTypeResponse> model)
        {
            List<ResponseModel> result = model.Select(s => new ResponseModel
            {
                Id = s.Id,
                Name = s.Name,
                Active = s.Active
            }).ToList();

            return result;
        }
    }
}
