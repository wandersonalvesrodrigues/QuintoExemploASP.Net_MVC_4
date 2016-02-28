using CadeMeuMedicoAPI.Models;
using CadeMeuMedicoAPI.Models.Business;
using System.Web.Http;

namespace CadeMeuMedicoAPI.Controllers
{
    public class UsuarioController : ApiController
    {
        public Usuario Get(int id)
        {
            return UsuarioBL.RecuperaUsuarioPorID(id);
        }

        public Usuario Get(string login, string senha)
        {
            return UsuarioBL.AutenticarUsuario(login, senha);
        }
    }
}
