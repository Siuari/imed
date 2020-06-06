using System;
using Clinica.Domain.Models;

namespace Clinica.Domain.Interfaces.Services
{
    public interface IPacienteService
    {
        Paciente Inserir(Paciente paciente);
        Paciente ObterPorId(Guid id);
        Paciente ObterPorCpf(string cpf);
        Guid ObterIdPacientePorCpf(string cpf);
        Paciente AtualizarNomeCpfPaciente(Guid id, string nome, string cpf);
        Paciente RemoverPaciente(Guid id);
    }
}
