using System;
using System.Collections.Generic;
using Clinica.Domain.Interfaces.Repositories.Base;
using Clinica.Domain.Models;

namespace Clinica.Domain.Interfaces.Repositories
{
    public interface IMedicoRepository : IRepositoryBase<Guid, Medico>
    {
        void CadastrarMedico(Medico medico);
        Medico ObterPorCrm(string crm);
        ICollection<Medico> ListarMedicos();
    }
}
