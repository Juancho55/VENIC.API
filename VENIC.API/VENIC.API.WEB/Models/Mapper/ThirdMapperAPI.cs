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
    }
}
