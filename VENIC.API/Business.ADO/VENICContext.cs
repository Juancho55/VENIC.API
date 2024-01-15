using Business.ADO.Interface;
using Microsoft.Extensions.Configuration;

namespace Business.ADO
{
    public class VenicContext : VENICConectionContext, IVenicContext
    {
        public VenicContext(IConfiguration config, string database) : base(config, database)
        {
        }
    }
}
