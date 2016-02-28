using CadeMeuMedicoAPI.Repository.Access;

namespace CadeMeuMedicoAPI.Repository
{
    public class Contexto
    {
        public static AdoNetContext GetContexto()
        {
            var factory = new AppConfigConnectionFactory("ModeloDeDados");
            return new AdoNetContext(factory);
        }
    }
}