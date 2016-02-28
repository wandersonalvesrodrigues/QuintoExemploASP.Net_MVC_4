using CadeMeuMedicoAPI.Models;
using CadeMeuMedicoAPI.Repository;
using System.Collections.Generic;

namespace CadeMeuMedicoAPI.Business
{
    public class EspecialidadeBL
    {
        public static ICollection<Especialidade> BuscaCidades()
        {
            var especialidadeRepositorio = new EspecialidadeRepositorio(Contexto.GetContexto());
            return especialidadeRepositorio.BuscaEspecialidades();
        }
    }
}