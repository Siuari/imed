using System;
using System.Collections.Generic;
using Clinica.Domain.Models.Base;

namespace Clinica.Domain.Models
{
    public class Consulta : Entity
    {
        public Guid IdPaciente { get; private set; }
        public Guid IdCobertura { get; private set; }
        public Guid IdHorarioAtendimento { get; private set; }
        public DateTime DataConsulta { get; private set; }

        public Cobertura Cobertura { get; private set; }
        public Paciente Paciente { get; private set; }
        public HorarioAtendimento HorarioAtendimento { get; private set; }
        public IEnumerable<Pagamento> Pagamentos { get; private set; }
        public IEnumerable<ReceitaMedica> ReceitasMedica { get; private set; }
        public IEnumerable<RequerimentoExame> RequerimentosExame { get; private set; }
    }
}
