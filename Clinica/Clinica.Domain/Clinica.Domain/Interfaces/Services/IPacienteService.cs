using System;
using Clinica.Domain.Models;

namespace Clinica.Domain.Interfaces.Services
{
    public interface IPacienteService
    {
        Paciente Inserir(Paciente paciente);
        Paciente ObterPorId(Guid id);
        Paciente Atualizar(Paciente paciente);
        Paciente RemoverPaciente(Guid id);
    }
}
