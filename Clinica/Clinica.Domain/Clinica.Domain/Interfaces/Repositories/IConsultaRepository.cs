using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Clinica.Domain.Interfaces.Repositories.Base;
using Clinica.Domain.Models;

namespace Clinica.Domain.Interfaces.Repositories
{
    public interface IConsultaRepository : IRepositoryBase<Guid, Consulta>
    {
        ICollection<Consulta> ListarConsultas(Expression<Func<Consulta, bool>> predicate);
        Consulta ObterConsultaAgendada(Guid idPaciente);
        Consulta ObterNaoFinalizadaPorId(Guid id);
        ICollection<Consulta> ListarConsultasVencidas();
    }
}
