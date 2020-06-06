using Clinica.AppService.ViewModels.Horario_Atendimento;
using Clinica.Domain.Enums;
using System;
using System.Collections.Generic;

namespace Clinica.AppService.Interfaces
{
    public interface IHorarioAtendimentoAppService
    {
        void CadastrarHorarioAtendimento(CadastrarHorarioAtendimentoViewModel horarioAtendimento);
        DataHorarioAtendimentoViewModel ObterHorarioAtendimentoDoDia(EnumDia dia, Guid idEspecialidade);
        ICollection<HorarioAtendimentoViewModel> ListarHorariosAtendimentos();
    }
}
