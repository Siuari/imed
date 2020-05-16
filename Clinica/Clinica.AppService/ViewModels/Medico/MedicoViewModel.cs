using System;
using System.Collections.Generic;
using System.Text;

namespace Clinica.AppService.ViewModels.Medico
{
    public class MedicoViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Crm { get; set; }

        public EspecialidadeViewModel Especialidade { get; set; }
    }
}
