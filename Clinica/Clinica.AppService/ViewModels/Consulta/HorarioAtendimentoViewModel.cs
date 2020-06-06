using System;
using Clinica.Domain.Enums;

namespace Clinica.AppService.ViewModels.Consulta
{
    public class HorarioAtendimentoViewModel
    {
        public Guid Id { get; set; }
        public string HoraInicio { get; set; }
        public EnumDia Dia { get; set; }
    }
}
