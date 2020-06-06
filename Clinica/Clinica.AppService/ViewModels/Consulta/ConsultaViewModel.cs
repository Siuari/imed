using System;
using System.Collections.Generic;
using System.Text;

namespace Clinica.AppService.ViewModels.Consulta
{
    public class ConsultaViewModel
    {
        public DateTime DataConsulta { get; set; }

        public CoberturaViewModel Cobertura { get; set; }
        public PacienteConsultaViewModel Paciente { get; set; }
        public HorarioAtendimentoViewModel HorarioAtendimento { get; set; }
    }
}
