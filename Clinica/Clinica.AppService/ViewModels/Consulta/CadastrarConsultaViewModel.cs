using System;
using System.Collections.Generic;
using System.Text;

namespace Clinica.AppService.ViewModels.Consulta
{
    public class CadastrarConsultaViewModel
    {
        public Guid IdPaciente { get; set; }
        public Guid IdCobertura { get; set; }
        public Guid IdHorarioAtendimento { get; set; }
        public DateTime DataConsulta { get; set; }
        public decimal ValorConsulta { get; set; }
    }
}
