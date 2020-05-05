using Clinica.Domain.Interfaces.Services.Base;
using Clinica.Domain.Models;

namespace Clinica.Domain.Interfaces.Services
{
    public interface IPacienteService : IServiceBase<Paciente>
    {
        Paciente Inserir(Paciente paciente);
        Paciente Atualizar(Paciente paciente);
        Paciente Deletar(Paciente paciente);
    }
}
