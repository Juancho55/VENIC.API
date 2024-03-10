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
                BirthDay = model.BirthDay,
                ComercialName = model.ComercialName,
                DocumentNumber = model.DocumentNumber,
                DocumentTypeId = model.DocumentTypeId,
                FirstName = model.FirstName,
                FirstSurName = model.FirstSurName,
                GenderId = model.GenderId,
                Id = model.Id,
                LegalDate = model.LegalDate,
                SecondName = model.SecondName,
                SecondSurName = model.SecondSurName,
                ThirdTypeId = model.ThirdTypeId,
                Active = true
            };
        }
    }
}
