using Clinica.Domain.Models;
using System;
using System.Collections.Generic;

namespace Clinica.Domain.Interfaces.Services
{
    public interface IEspecialidadeService
    {
        ICollection<Especialidade> Listar();
        Especialidade ObterPorIdComMedicos(Guid id);
    }
}
