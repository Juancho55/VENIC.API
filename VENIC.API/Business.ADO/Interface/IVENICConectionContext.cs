using System.Data.SqlClient;
using System.Data;

namespace Business.ADO.Interface
{
    public interface IVENICConectionContext
    {
        Task<int> ExecuteNonQueryAsync(string procedure, params SqlParameter[] parameters);
        Task<DataSet> Fill(string procedure, params SqlParameter[] parameters);
        Task<DataSet> Views(string viewName);
    }
}