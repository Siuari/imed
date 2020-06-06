using Clinica.Domain.Models.Base;
using System;
using System.Collections.Generic;

namespace Clinica.Domain.Models
{
    public class Medico : Entity
    {
        public Guid IdEspecialidade { get; private set; }
        public string Nome { get; private set; }
        public string Crm { get; private set; }

        public Especialidade Especialidade { get; private set; }
        public IEnumerable<HorarioAtendimento> HorariosAtendimento { get; private set; }
    }
}
