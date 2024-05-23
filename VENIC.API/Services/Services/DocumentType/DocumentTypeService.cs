using Infra.Interfaces;
using Services.Services.DocumentType.Mapper;
using Services.Services.DocumentType.Models;

namespace Services.Services.DocumentType
{
    public class DocumentTypeService : IDocumentTypeService
    {
        private readonly IDocumentType documentType;

        public DocumentTypeService(IDocumentType documentType)
        {
            this.documentType = documentType;
        }

        public async Task<List<ResponseModel>> GetDocumentType()
        {
            return new DocumentTypeMap().MappResp(await documentType.GetDocumentType());
        }
    }
}
