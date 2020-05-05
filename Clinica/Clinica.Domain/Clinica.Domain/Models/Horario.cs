using System.Collections.Generic;
using Clinica.Domain.Enums;
using Clinica.Domain.Models.Base;

namespace Clinica.Domain.Models
{
    public class Horario : Entity
    {
        public string HoraInicio { get; set; }
        public EnumDia Dia { get; set; }

        public IEnumerable<HorarioAtendimento> HorariosAtendimento { get; set; }
    }
}
