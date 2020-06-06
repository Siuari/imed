using System;
using Clinica.Domain.Models;
using System.Collections.Generic;

namespace Clinica.Domain.Interfaces.Services
{
    public interface IMedicoService
    {
        ICollection<Medico> ListarMedicos();
        Medico CadastrarMedico(Medico medico);
        Medico AtualizarMedico(Medico medico);
        Medico DeletarMedico(Guid id);
    }
}
