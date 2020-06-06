using System;
using System.Collections.Generic;
using Clinica.Domain.Enums;
using Clinica.Domain.Interfaces.Repositories.Base;
using Clinica.Domain.Models;

namespace Clinica.Domain.Interfaces.Repositories
{
    public interface IHorarioAtendimentoRepository : IRepositoryBase<Guid, HorarioAtendimento>
    {
        HorarioAtendimento ObterComHorario(Guid id);
        ICollection<HorarioAtendimento> ListarComConsulta(EnumDia dia, Guid idEspecialidade);
        ICollection<HorarioAtendimento> ListarComMedicoHorario();
    }
}
