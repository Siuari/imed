using System;

namespace Clinica.AppService.ViewModels.Horario_Atendimento
{
    public class HorarioAtendimentoViewModel
    {
        public Guid Id { get; set; }
        public virtual MedicoViewModel Medico { get; set; }
        public virtual HorarioViewModel Horario { get; set; }
    }
}
