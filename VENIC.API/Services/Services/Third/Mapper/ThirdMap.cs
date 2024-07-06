using Infra.Thrid.Models;
using Services.Services.Third.Models;

namespace Services.Services.Third.Mapper
{
    public class ThirdMap
    {
        public ThirdRequest MapReq(RequestModel requestModel)
        {
            return new ThirdRequest()
            {
                Third = new Model.Thirds.Third()
                {
                    Id = requestModel.Id,
                    Active = requestModel.Active,
                    BirthDay = requestModel.BirthDay,
                    ComercialName = requestModel.ComercialName,
                    DocumentNumber = requestModel.DocumentNumber,
                    DocumentTypeId = requestModel.DocumentTypeId,
                    FirstName = requestModel.FirstName,
                    FirstSurName = requestModel.FirstSurName,
                    GenderId = requestModel.GenderId,
                    LegalDate = requestModel.LegalDate,
                    SecondName = requestModel.SecondName,
                    SecondSurName = requestModel.SecondSurName,
                    ThirdTypeId = requestModel.ThirdTypeId
                }
            };
        }

        public List<ResponseModel> MapResponse(ThirdResponse response)
        {
            return response.Thirds.Select(s => new ResponseModel()
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
