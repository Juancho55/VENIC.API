using Services.Services.DocumentType.Models;

namespace Services.Services.DocumentType
{
    public interface IDocumentTypeService
    {
        public Task<List<ResponseModel>> GetDocumentType();
    }
}
