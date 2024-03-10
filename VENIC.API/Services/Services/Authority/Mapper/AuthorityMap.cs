using Infra.Autority.Model;
using Services.Services.Authority.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.Authority.Mapper
{
    public class AuthorityMap
    {
        public AuthorityRequest MapReq(RequestAutorithyService req)
        {
            return new AuthorityRequest()
            {
                Name = req.Name,
                Password = req.Password
            };
        }

        public ResponseAuthorityServie MappResp(AuthorityResponse model)
        {
            return new ResponseAuthorityServie()
            {
                Id_Rol = model.Id_Rol,
                Id_Trhid = model.Id_Trhid,
                Id_User = model.Id_User
            };
        }
    }
}
