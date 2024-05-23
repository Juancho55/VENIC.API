using Services.Services.DocumentType.Models;
using VENIC.API.WEB.Models.DocumentType;

namespace VENIC.API.WEB.Models.Mapper
{
    public class DocumentTypeMapperAPI
    {
        public List<ResponseDocumentType> MappResp(List<ResponseModel> model)
        {
            List<ResponseDocumentType> result = model.Select(s => new ResponseDocumentType
            {
                Id = s.Id,
                Name = s.Name,
                Active = s.Active
            }).ToList();

            return result;
        }
    }
}
