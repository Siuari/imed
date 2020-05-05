using Clinica.Domain.Models.Base;
using System;
using System.Collections.Generic;

namespace Clinica.Domain.Models
{
    public class HorarioAtendimento : Entity
    {
        public Guid IdMedico { get; set; }
        public Guid IdHorario { get; set; }

        public Medico Medico { get; set; }
        public Horario Horario { get; set; }
        public IEnumerable<Consulta> Consultas { get; set; }
    }
}
