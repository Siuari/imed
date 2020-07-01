using System;
using System.Collections.Generic;
using Clinica.Domain.Models;

namespace Clinica.Domain.Interfaces.Services
{
    public interface IConsultaService
    {
        Consulta InserirConsulta(Consulta consulta);
        Consulta CancelarConsulta(Guid id);
        Consulta AtualizarConsulta(Consulta conulsta);
        ICollection<Consulta> ListarConsultasPorIdPaciente(Guid idPaciente);
        ICollection<Consulta> ListarConsultasPorIdMedico(Guid idMedico);
        Consulta ObterConsultaPorId(Guid id);
        Consulta ObterConsultaAgendada(Guid idPaciente);
        Consulta PagarConsulta(Guid id, IEnumerable<Pagamento> pagamentos);
        ICollection<Consulta> ListarConsultasVencidas();
    }
}
