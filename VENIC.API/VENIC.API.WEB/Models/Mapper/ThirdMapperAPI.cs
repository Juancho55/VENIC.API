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
                BirthDay = model?.BirthDay ?? DateTime.Now,
                ComercialName = model?.ComercialName ?? string.Empty,
                DocumentNumber = model?.DocumentNumber ?? string.Empty,
                DocumentTypeId = model?.DocumentTypeId ?? 0,
                FirstName = model?.FirstName ?? string.Empty,
                FirstSurName = model?.FirstSurName ?? string.Empty,
                GenderId = model?.GenderId ?? 0,
                Id = model?.Id ?? 0,
                LegalDate = model?.LegalDate ?? DateTime.Now,
                SecondName = model?.SecondName ?? string.Empty,
                SecondSurName = model?.SecondSurName ?? string.Empty,
                ThirdTypeId = model?.ThirdTypeId ?? 0,
                Active = true
            };
        }

        public List<ResponseThirdModelAPI> Mapresponse(List<ResponseModel> response)
        {
            return response.Select(s => new ResponseThirdModelAPI()
            {
                Active = s.Active,
                BirthDay = s.BirthDay,
                ComercialName = s.ComercialName,
                DocumentNumber = s.DocumentNumber,
                DocumentTypeId = s.DocumentTypeId,
                FirstName = s.FirstName,
                FirstSurName = s.FirstSurName,
                GenderId = s.GenderId,
                Id = s.Id,
                LegalDate = s.LegalDate,
                SecondName = s.SecondName,
                SecondSurName = s.SecondSurName,
                ThirdTypeId = s.ThirdTypeId
            }).ToList();
        }
    }
}
