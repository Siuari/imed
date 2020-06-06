using System;
using Clinica.Domain.Interfaces.Repositories.Base;
using Clinica.Domain.Models;

namespace Clinica.Domain.Interfaces.Repositories
{
    public interface IPacienteRepository : IRepositoryBase<Guid, Paciente>
    {
        Paciente ObterPorId(Guid id);
        Paciente ObterPorCpf(string cpf);
        Guid ObterIdPacientePorCpf(string cpf);
    }
}
