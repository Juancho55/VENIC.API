using Infra.Thrid.Models;

namespace Infra.Interfaces
{
    public interface IDocumentType
    {
        public Task<List<DocumentTypeResponse>> GetDocumentType();
    }
}
