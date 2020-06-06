using Clinica.Domain.Models.Base;
using System;
using System.Collections.Generic;

namespace Clinica.Domain.Models
{
    public class HorarioAtendimento : Entity
    {
        public Guid IdMedico { get; set; }
        public Guid IdHorario { get; set; }

        public virtual Medico Medico { get; set; }
        public virtual Horario Horario { get; set; }
        public virtual IEnumerable<Consulta> Consultas { get; set; }
    }
}
