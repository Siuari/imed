using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Clinica.Domain.Enums;

namespace Clinica.AppService.ViewModels.Consulta
{
    public class ConsultaVencidaViewModel
    {
        public Guid Id { get; set; }
        public DateTime DataConsulta { get; set; }
        public EnumStatusConsulta StatusConsulta { get; set; }
        public decimal ValorConsulta { get; set; }
        public PacienteConsultaViewModel Paciente { get; set; }
        public HorarioAtendimentoViewModel HorarioAtendimento { get; set; }
        public MedicoConsultaVencidaViewModel Medico { get; set; }
    }
}
