using Clinica.AppService.ViewModels;
using System;
using Clinica.AppService.ViewModels.Paciente;

namespace Clinica.AppService.Interfaces
{
    public interface IPacienteAppService
    {
        void Inserir(CadastrarPacienteViewModel viewModel);
        PacienteViewModel ObterPorId(Guid id);
        PacienteDeletadoViewModel RemoverPaciente(Guid id);
    }
}
