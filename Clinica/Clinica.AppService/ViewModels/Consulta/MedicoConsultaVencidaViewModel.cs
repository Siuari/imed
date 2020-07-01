using System;

namespace Clinica.AppService.ViewModels.Consulta
{
    public class MedicoConsultaVencidaViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Crm { get; set; }
        public string Especialidade { get; set; }
    }
}
