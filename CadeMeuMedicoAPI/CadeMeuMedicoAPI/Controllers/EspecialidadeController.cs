using CadeMeuMedicoAPI.Business;
using CadeMeuMedicoAPI.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace CadeMeuMedicoAPI.Controllers
{
    public class EspecialidadeController : ApiController
    {
        public IEnumerable<Especialidade> Get()
        {
            return EspecialidadeBL.BuscaCidades();
        }
    }
}
