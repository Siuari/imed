using System;
using System.Collections.Generic;
using Clinica.Domain.Models;

namespace Clinica.Domain.Interfaces.Repositories.Base
{
    public interface IMedicoRepository : IRepositoryBase<Guid, Medico>
    {
        Medico ObterPorCrm(string crm);
        ICollection<Medico> ListarMedicos();
    }
}
