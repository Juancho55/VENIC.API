using Business.ADO.Interface;
using System.Data.SqlClient;

namespace Business.ADO
{
    public class VENICContext(string strContext) : IVENICContext
    {
        public string strContext = strContext;
        public SqlConnection? conn;

        public void Open()
        {
            this.conn = new SqlConnection
            {
                ConnectionString = strContext
            };
            this.conn.Open();
        }

        public void Close()
        {
            this.conn?.Close();
            this.conn?.Dispose();
        }
    }
}
