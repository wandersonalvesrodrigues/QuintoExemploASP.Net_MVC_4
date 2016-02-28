using System.Collections.Generic;

namespace CadeMeuMedicoAPI.Models
{
    public class Especialidade
    {
        public int IDEspecialidade { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Medico> Medicos { get; set; }
    }
}