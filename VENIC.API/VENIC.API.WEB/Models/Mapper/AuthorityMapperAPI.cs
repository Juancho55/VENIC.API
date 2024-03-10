using Services.Services.Authority.Models;
using VENIC.API.WEB.Models.Authority;

namespace VENIC.API.WEB.Models.Mapper
{
    public class AuthorityMapperAPI
    {
        public RequestAutorithyService MapReq(RequestAuthorityAPI req)
        {
            return new RequestAutorithyService()
            {
                Name = req.Name,
                Password = req.Password,
            };
        }

        public ResponserAuthorityAPI MapRes(ResponseAuthorityServie model)
        {
            return new ResponserAuthorityAPI()
            {
                Id_Rol = model.Id_Rol,
                Id_Trhid = model.Id_Trhid,
                Id_User = model.Id_User
            };
        }
    }
}
