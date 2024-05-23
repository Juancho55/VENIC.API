using Business.ADO.Interface;
using Infra.Interfaces;
using Infra.Thrid.Models;
using System.Data;

namespace Infra.Thrid
{
    public class DocumentType : IDocumentType
    {
        private readonly IVenicContext context;

        public DocumentType(IVenicContext context)
        {
            this.context = context;
        }

        public async Task<List<DocumentTypeResponse>> GetDocumentType()
        {
            List<DocumentTypeResponse> result = new List<DocumentTypeResponse>();

            DataSet dts = await context.Views("SECURITYSYSTEM.DOCUMENTTYPE");

            if (dts != null)
                if (dts.Tables.Count > 0 && dts.Tables[0].Rows.Count > 0)
                    foreach (DataRow dr in dts.Tables[0].Rows)
                        result.Add(new DocumentTypeResponse
                        {
                            Id = int.Parse(dr["ID"].ToString()),
                            Name = dr["NAME"].ToString(),
                            Active = Convert.ToBoolean(dr["ACTIVE"].ToString())
                        });

            return result;
        }
    }
}
