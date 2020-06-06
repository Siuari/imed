using System;
using System.Collections.Generic;
using System.Text;

namespace Clinica.AppService.ViewModels.Consulta
{
    public class ConsultaMarcadaViewModel
    {
        public Guid Id { get; set; }
        public string NomePaciente { get; set; }
        public string NomeMedico { get; set; }
        public DateTime DataConsulta { get; set; }
        public string HoraConsulta { get; set; }
    }
}
