using System;
using Clinica.Domain.Enums;

namespace Clinica.AppService.ViewModels.Horario
{
    public class HorarioListagemViewModel
    {
        public Guid Id { get; set; }
        public string HoraInicio { get; set; }
        public EnumDia Dia { get; set; }
    }
}
