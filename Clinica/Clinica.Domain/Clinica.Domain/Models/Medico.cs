using Clinica.Domain.Models.Base;
using System;
using System.Collections.Generic;

namespace Clinica.Domain.Models
{
    public class Medico : Entity
    {
        public Guid IdEspecialidade { get; set; }
        public string Nome { get; set; }
        public string Crm { get; set; }

        public Especialidade Especialidade { get; set; }
        public IEnumerable<HorarioAtendimento> HorariosAtendimento { get; set; }
    }
}
