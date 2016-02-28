using CadeMeuMedicoAPI.Repository;

namespace CadeMeuMedicoAPI.Models.Business
{
    public class UsuarioBL
    {
        public static Usuario AutenticarUsuario(string Login, string SenhaCriptografada)
        {
            var usuarioRepositorio = new UsuarioRepositorio(Contexto.GetContexto());
            return usuarioRepositorio.AutenticarUsuario(Login, SenhaCriptografada);
        }

        public static Usuario RecuperaUsuarioPorID(int id)
        {
            var usuarioRepositorio = new UsuarioRepositorio(Contexto.GetContexto());
            return usuarioRepositorio.RecuperaUsuarioPorID(id);
        }
    }
}