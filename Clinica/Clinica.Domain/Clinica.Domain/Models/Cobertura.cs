using System.Collections.Generic;
using Clinica.Domain.Models.Base;

namespace Clinica.Domain.Models
{
    public class Cobertura : Entity
    {
        public string Descricao { get; set; }

        public IEnumerable<Consulta> Consultas { get; set; }
    }
}
