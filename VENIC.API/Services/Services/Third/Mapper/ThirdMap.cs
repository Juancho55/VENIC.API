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
                    CreateDate = requestModel.CreateDate,
                    DocumentNumber = requestModel.DocumentNumber,
                    DocumentTypeId = requestModel.DocumentTypeId,
                    FirstName = requestModel.FirstName,
                    FirstSurName = requestModel.FirstSurName,
                    GenderId = requestModel.GenderId,
                    LegalDate = requestModel.LegalDate,
                    SecondName = requestModel.SecondName,
                    SecondSurName = requestModel.SecondSurName,
                    ThirdTypeId = requestModel.ThirdTypeId,
                    UpdateDate = requestModel.UpdateDate
                }
            };
        }
    }
}
