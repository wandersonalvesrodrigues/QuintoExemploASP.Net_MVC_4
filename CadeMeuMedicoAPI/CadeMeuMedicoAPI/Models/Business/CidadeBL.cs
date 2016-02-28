using CadeMeuMedicoAPI.Models;
using CadeMeuMedicoAPI.Repository;
using System.Collections.Generic;

namespace CadeMeuMedicoAPI.Business
{
    public class CidadeBL
    {
        public static ICollection<Cidade> BuscaCidades()
        {
            var cidadeRepositorio = new CidadeRepositorio(Contexto.GetContexto());
            return cidadeRepositorio.BuscaCidades();
        }
    }
}