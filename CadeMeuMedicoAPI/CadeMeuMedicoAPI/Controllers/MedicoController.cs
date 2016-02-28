using CadeMeuMedicoAPI.Business;
using CadeMeuMedicoAPI.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace CadeMeuMedicoAPI.Controllers
{
    public class MedicoController : ApiController
    {
        public IEnumerable<Medico> Get()
        {
            return MedicoBL.BuscaMedicos();
        }

        public Medico Get(int id)
        {
            return MedicoBL.BuscaPorId(id);
        }

        [HttpPost]
        public dynamic Post(Medico medico)
        {
            var result = MedicoBL.Inserir(medico);

            if (result)
            {
                return new { Status = "S", Message = "Sucesso" };
            }
            return new { Status = "E", Message = "Erro" };
        }

        [HttpDelete]
        public dynamic Delete(int id)
        {
            var result = MedicoBL.Excluir(id);

            if (result)
            {
                return new { Status = "S", Message = "Sucesso" };
            }
            return new { Status = "E", Message = "Erro" };
        }

        [HttpPut]
        public dynamic Put(Medico medico)
        {
            var result = MedicoBL.Atualizar(medico);

            if (result)
            {
                return new { Status = "S", Message = "Sucesso" };
            }
            return new { Status = "E", Message = "Erro" };
        }

    }
}
