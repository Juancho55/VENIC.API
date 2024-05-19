using Business.ADO.Interface;
using Infra.Interfaces;
using Infra.Thrid.Models;
using System.Data;

namespace Infra.Thrid
{
    public class ThirdType : IThirdType
    {
        private readonly IVenicContext context;

        public ThirdType(IVenicContext context)
        {
            this.context = context;
        }

        public async Task<List<ThirdTypeResponse>> GetThirdsTypes()
        {
            List<ThirdTypeResponse> result = new List<ThirdTypeResponse>();

            DataSet dts = await context.Views("SECURITYSYSTEM.THIRDPARTIESTYPE");

            if (dts != null)
                if (dts.Tables.Count > 0 && dts.Tables[0].Rows.Count > 0)
                    foreach (DataRow dr in dts.Tables[0].Rows)
                        result.Add(new ThirdTypeResponse
                        {
                            Id = int.Parse(dr["ID"].ToString()),
                            Name = dr["NAME"].ToString(),
                            Description = dr["DESCRIPTION"].ToString(),
                            Active = Convert.ToBoolean(dr["ACTIVE"].ToString())
                        });

            return result;
        }
    }
}
