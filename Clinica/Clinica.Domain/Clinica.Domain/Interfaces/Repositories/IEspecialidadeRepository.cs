using Clinica.Domain.Interfaces.Repositories.Base;
using Clinica.Domain.Models;
using System;

namespace Clinica.Domain.Interfaces.Repositories
{
    public interface IEspecialidadeRepository : IRepositoryBase<Guid, Especialidade>
    {
        Especialidade ObterPorIdComMedicos(Guid id);
    }
}
