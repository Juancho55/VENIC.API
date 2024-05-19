using Business.ADO.Interface;
using Infra.Interfaces;
using Infra.Thrid.Models;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Serialization;
using Infra.Autority.Model;

namespace Infra.Autority
{
    public class AuthorityInfra : IAuthorityInfra
    {
        private readonly IVenicContext context;
        public AuthorityInfra(IVenicContext context)
        {
            this.context = context;
        }

        private  string setBase64(string? str)
        {
            byte[] plainTextBytes = System.Text.Encoding.UTF8.GetBytes(str);
            return Convert.ToBase64String(plainTextBytes);
        }

        public async Task<AuthorityResponse> GetAsync(AuthorityRequest authorityRequest)
        {
            AuthorityResponse response = new();

            var parameters = new SqlParameter[] {
                new SqlParameter { ParameterName= "@NAME", SqlDbType = SqlDbType.NVarChar, Value = authorityRequest.Name },
                new SqlParameter { ParameterName= "@PASS", SqlDbType = SqlDbType.NVarChar, Value = setBase64(authorityRequest.Password) }
            };

            DataSet dts = await context.Fill("SECURITYSYSTEM.Sp_Authority", parameters);

            if (dts != null)
                if (dts.Tables.Count > 0 && dts.Tables[0].Rows.Count > 0)
                    foreach (DataRow dr in dts.Tables[0].Rows)
                    {
                        response.Id_Rol = int.Parse(dr["ID_ROL"].ToString());
                        response.Id_User = int.Parse(dr["ID"].ToString());
                        response.Id_Trhid = long.Parse(dr["ID_THIRPARTIES"].ToString());
                    }
            return response;
        }
    }
}
