using System;
using System.Collections.Generic;

namespace Clinica.AppService.ViewModels.Medico
{
    public class CadastrarMedicoViewModel
    {
        public Guid IdEspecialidade { get; set; }
        public string Nome { get; set; }
        public string Crm { get; set; }
        public ICollection<HorarioAtendimentoViewModel> HorariosAtendimento { get; set; }
    }
}
