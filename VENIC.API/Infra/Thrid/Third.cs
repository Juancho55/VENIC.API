using Business.ADO.Interface;
using Infra.Interfaces;
using Infra.Thrid.Models;
using System.Data;
using System.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Infra.Thrid
{
    public class Third : IThrid
    {
        private readonly IVenicContext context;

        public Third(IVenicContext context)
        {
            this.context = context;
        }

        public async Task<bool> SaveAsync(ThirdRequest thirdCollection)
        {
            var parameters = new SqlParameter[]
            {
                new SqlParameter{ ParameterName = "@ACTION", SqlDbType = SqlDbType.Int, Value = Costants.ActionSave },
                new SqlParameter{ ParameterName = "@ID", SqlDbType = SqlDbType.BigInt, Value = 0 },
                new SqlParameter{ ParameterName = "@FIRST_NAME", SqlDbType = SqlDbType.NVarChar, Value = thirdCollection.Third.FirstName },
                new SqlParameter{ ParameterName = "@SECOND_NAME", SqlDbType = SqlDbType.NVarChar, Value = thirdCollection.Third.SecondName },
                new SqlParameter{ ParameterName = "@FIRST_SURNAME", SqlDbType = SqlDbType.NVarChar, Value = thirdCollection.Third.FirstSurName },
                new SqlParameter{ ParameterName = "@SECOND_SURNAME", SqlDbType =SqlDbType.NVarChar, Value = thirdCollection.Third.SecondSurName },
                new SqlParameter{ ParameterName = "@COMERCIAL_NAME", SqlDbType = SqlDbType.NVarChar, Value = thirdCollection.Third.ComercialName },
                new SqlParameter{ ParameterName = "@ID_DOCUMENT_TYPE", SqlDbType = SqlDbType.Int, Value = thirdCollection.Third.DocumentTypeId },
                new SqlParameter{ ParameterName = "@ID_THIRPARTIE_TYPE", SqlDbType = SqlDbType.Int, Value = thirdCollection.Third.ThirdTypeId },
                new SqlParameter{ ParameterName = "@ID_GENDER", SqlDbType = SqlDbType.Int, Value = thirdCollection.Third.GenderId },
                new SqlParameter{ ParameterName = "@DOCUMENTNUMBER", SqlDbType = SqlDbType.NVarChar, Value = thirdCollection.Third.DocumentNumber },
                new SqlParameter{ ParameterName = "@BIRTHDAY_DATE", SqlDbType = SqlDbType.DateTime, Value = thirdCollection.Third.BirthDay },
                new SqlParameter{ ParameterName = "@LEGAL_DATE", SqlDbType = SqlDbType.DateTime, Value = thirdCollection.Third.LegalDate },
                new SqlParameter{ ParameterName = "@ACTIVE", SqlDbType = SqlDbType.Bit, Value = thirdCollection.Third.Active }
            };

            int result = await context.ExecuteNonQueryAsync("SECURITYSYSTEM.Sp_CRUDTHIRD", parameters);

            if (result == 0)
                return false;
            else
                return true;
        }
        public async Task<bool> UpdateAsync(ThirdRequest thirdCollection)
        {
            var parameters = new SqlParameter[]
            {
                new SqlParameter{ ParameterName = "@ACTION", SqlDbType = SqlDbType.Int, Value = Costants.ActionUpdae },
                new SqlParameter{ ParameterName = "@ID", SqlDbType = SqlDbType.BigInt, Value = thirdCollection.Third.Id },
                new SqlParameter{ ParameterName = "@FIRST_NAME", SqlDbType = SqlDbType.NVarChar, Value = thirdCollection.Third.FirstName },
                new SqlParameter{ ParameterName = "@SECOND_NAME", SqlDbType = SqlDbType.NVarChar, Value = thirdCollection.Third.SecondName },
                new SqlParameter{ ParameterName = "@FIRST_SURNAME", SqlDbType = SqlDbType.NVarChar, Value = thirdCollection.Third.FirstSurName },
                new SqlParameter{ ParameterName = "@SECOND_SURNAME", SqlDbType =SqlDbType.NVarChar, Value = thirdCollection.Third.SecondSurName },
                new SqlParameter{ ParameterName = "@COMERCIAL_NAME", SqlDbType = SqlDbType.NVarChar, Value = thirdCollection.Third.ComercialName },
                new SqlParameter{ ParameterName = "@ID_DOCUMENT_TYPE", SqlDbType = SqlDbType.Int, Value = thirdCollection.Third.DocumentTypeId },
                new SqlParameter{ ParameterName = "@ID_THIRPARTIE_TYPE", SqlDbType = SqlDbType.Int, Value = thirdCollection.Third.ThirdTypeId },
                new SqlParameter{ ParameterName = "@ID_GENDER", SqlDbType = SqlDbType.Int, Value = thirdCollection.Third.GenderId },
                new SqlParameter{ ParameterName = "@DOCUMENTNUMBER", SqlDbType = SqlDbType.NVarChar, Value = thirdCollection.Third.DocumentNumber },
                new SqlParameter{ ParameterName = "@BIRTHDAY_DATE", SqlDbType = SqlDbType.DateTime, Value = thirdCollection.Third.BirthDay },
                new SqlParameter{ ParameterName = "@LEGAL_DATE", SqlDbType = SqlDbType.DateTime, Value = thirdCollection.Third.LegalDate },
                new SqlParameter{ ParameterName = "@ACTIVE", SqlDbType = SqlDbType.Bit, Value = thirdCollection.Third.Active }
            };

            int result = await context.ExecuteNonQueryAsync("SECURITYSYSTEM.Sp_CRUDTHIRD", parameters);

            if (result == 0)
                return false;
            else
                return true;
        }
        public async Task<bool> DeleteAsync(long Id)
        {
            var parameters = new SqlParameter[]
            {
                new SqlParameter{ ParameterName = "@ACTION", SqlDbType = SqlDbType.Int, Value = Costants.ActionDelete },
                new SqlParameter{ ParameterName = "@ID", SqlDbType = SqlDbType.BigInt, Value = Id },
                new SqlParameter{ ParameterName = "@FIRST_NAME", SqlDbType = SqlDbType.NVarChar, Value = string.Empty },
                new SqlParameter{ ParameterName = "@SECOND_NAME", SqlDbType = SqlDbType.NVarChar, Value = string.Empty },
                new SqlParameter{ ParameterName = "@FIRST_SURNAME", SqlDbType = SqlDbType.NVarChar, Value = string.Empty },
                new SqlParameter{ ParameterName = "@SECOND_SURNAME", SqlDbType =SqlDbType.NVarChar, Value = string.Empty },
                new SqlParameter{ ParameterName = "@COMERCIAL_NAME", SqlDbType = SqlDbType.NVarChar, Value =string.Empty },
                new SqlParameter{ ParameterName = "@ID_DOCUMENT_TYPE", SqlDbType = SqlDbType.Int, Value = 0 },
                new SqlParameter{ ParameterName = "@ID_THIRPARTIE_TYPE", SqlDbType = SqlDbType.Int, Value = 0 },
                new SqlParameter{ ParameterName = "@ID_GENDER", SqlDbType = SqlDbType.Int, Value = 0 },
                new SqlParameter{ ParameterName = "@DOCUMENTNUMBER", SqlDbType = SqlDbType.NVarChar, Value = string.Empty },
                new SqlParameter{ ParameterName = "@BIRTHDAY_DATE", SqlDbType = SqlDbType.DateTime, Value = null },
                new SqlParameter{ ParameterName = "@LEGAL_DATE", SqlDbType = SqlDbType.DateTime, Value = null },
                new SqlParameter{ ParameterName = "@ACTIVE", SqlDbType = SqlDbType.Bit, Value = 0 }
            };

            int result = await context.ExecuteNonQueryAsync("SECURITYSYSTEM.Sp_CRUDTHIRD", parameters);

            if (result == 0)
                return false;
            else
                return true;
        }
        public async Task<ThirdResponse> GetAsync(ThirdRequest thirdCollection)
        {
            ThirdResponse response = new ThirdResponse();

            var parameters = new SqlParameter[] {
                new SqlParameter { ParameterName= "@ACTION", SqlDbType = SqlDbType.Int, Value = Costants.ActionSave },
                new SqlParameter { ParameterName= "@ID", SqlDbType = SqlDbType.BigInt,Value = 0},
                new SqlParameter { ParameterName= "@FIRST_NAME", SqlDbType = SqlDbType.NVarChar,Value = null},
                new SqlParameter { ParameterName= "@SECOND_NAME", SqlDbType = SqlDbType.NVarChar,Value = null},
                new SqlParameter { ParameterName= "@FIRST_SURNAME", SqlDbType = SqlDbType.NVarChar,Value = null},
                new SqlParameter { ParameterName= "@SECOND_SURNAME", SqlDbType =  SqlDbType.NVarChar,Value = null},
                new SqlParameter { ParameterName= "@COMERCIAL_NAME", SqlDbType = SqlDbType.NVarChar,Value = null},
                new SqlParameter { ParameterName= "@ID_DOCUMENT_TYPE", SqlDbType = SqlDbType.Int,Value = 0},
                new SqlParameter { ParameterName= "@ID_THIRPARTIE_TYPE", SqlDbType = SqlDbType.Int,Value = 0},
                new SqlParameter { ParameterName= "@ID_GENDER", SqlDbType = SqlDbType.Int,Value = 0},
                new SqlParameter { ParameterName= "@DOCUMENTNUMBER", SqlDbType = SqlDbType.NVarChar,Value = string.Empty},
                new SqlParameter { ParameterName= "@BIRTHDAY_DATE", SqlDbType = SqlDbType.DateTime,Value = null},
                new SqlParameter { ParameterName= "@LEGAL_DATE", SqlDbType = SqlDbType.DateTime,Value = null},
                new SqlParameter { ParameterName= "@ACTIVE", SqlDbType = SqlDbType.Bit,Value = 0}
            };

            DataSet dts = await context.Fill("SECURITYSYSTEM.Sp_CRUDTHIRD", parameters);

            if (dts != null)
                if (dts.Tables.Count > 0 && dts.Tables[0].Rows.Count > 0)
                    foreach (DataRow dr in dts.Tables[0].Rows)
                        response.Thirds?.Add(new Model.Thirds.Third
                        {
                            Id = long.Parse(dr["Id"].ToString()),
                            FirstName = dr["FirstName"].ToString()
                        });

            return response;
        }
    }
}
