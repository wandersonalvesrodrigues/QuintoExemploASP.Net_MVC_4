using System.Data;

namespace CadeMeuMedicoAPI.Repository.Access
{
    public interface IConnectionFactory
    {
        IDbConnection Create();
    }
}
