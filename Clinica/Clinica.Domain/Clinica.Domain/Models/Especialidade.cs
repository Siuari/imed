using System.Collections.Generic;
using Clinica.Domain.Models.Base;

namespace Clinica.Domain.Models
{
    public class Especialidade : Entity
    {
        public string Descricao { get; set; }

        public IEnumerable<Medico> Medicos { get; set; }
    }
}
