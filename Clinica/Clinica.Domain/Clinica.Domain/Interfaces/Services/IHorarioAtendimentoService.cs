using System;
using System.Collections.Generic;
using Clinica.Domain.Enums;
using Clinica.Domain.Models;

namespace Clinica.Domain.Interfaces.Services
{
    public interface IHorarioAtendimentoService
    {
        HorarioAtendimento CadastrarHorarioAtendimento(HorarioAtendimento horarioAtendimento);
        Tuple<DateTime, Guid> ObterHorarioAtendimentoDoDia(EnumDia dia, Guid idEspecialidade);
        ICollection<HorarioAtendimento> ListarHorariosAtendimentos();
    }
}
