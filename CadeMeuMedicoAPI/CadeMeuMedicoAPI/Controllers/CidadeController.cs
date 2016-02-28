using CadeMeuMedicoAPI.Business;
using CadeMeuMedicoAPI.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace CadeMeuMedicoAPI.Controllers
{
    public class CidadeController : ApiController
    {
        public IEnumerable<Cidade> Get()
        {
            return CidadeBL.BuscaCidades();
        }
    }
}
