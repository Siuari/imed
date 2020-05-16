using System;
using Clinica.Domain.Interfaces.Repositories.Base;
using Clinica.Domain.Models;

namespace Clinica.Domain.Interfaces.Repositories
{
    public interface IPacienteRepository : IRepositoryBase<Guid, Paciente>
    {
        Paciente ObterPorId(Guid id);
        object Listar(Func<object, bool> p);
    }
}
