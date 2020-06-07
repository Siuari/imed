using Clinica.AppService.ViewModels.Consulta;
using System;
using System.Collections.Generic;

namespace Clinica.AppService.Interfaces
{
    public interface IConsultaAppService
    {
        void InserirConsulta(CadastrarConsultaViewModel contulta);
        ConsultaDeletadaViewModel CancelarConsulta(Guid id);
        ICollection<ConsultaViewModel> ListarConsultasPorIdPaciente(Guid idPaciente);
        ICollection<ConsultaViewModel> ListarConsultasPorIdMedico(Guid idMedico);
        ConsultaViewModel ObterConsultaPorId(Guid id);
        ConsultaMarcadaViewModel ObterConsultaAgendada(Guid idPaciente);
        ConsultaPagaViewModel PagarConsulta(PagarConsultaViewModel viewModel);
    }
}
