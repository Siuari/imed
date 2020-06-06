using Clinica.Domain.Interfaces.Repositories;
using Clinica.Domain.Models;
using Clinica.Infra.Context;
using Clinica.Infra.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Clinica.Infra.Repositories
{
    public class MedicoRepository : RepositoryBase<Medico>, IMedicoRepository
    {
        private readonly ClinicaContext _context;
        
        public MedicoRepository(ClinicaContext context) : base(context)
        {
            _context = context; 
        }

        public void CadastrarMedico(Medico medico)
        {
            throw new System.NotImplementedException();
        }

        public Medico ObterPorCrm(string crm)
        {
            return _context.Set<Medico>()
                .FirstOrDefault(x => x.Crm == crm);
        }

        public ICollection<Medico> ListarMedicos()
        {
            return _context.Set<Medico>()
                .Include(x => x.Especialidade)
                .ToList();
        }
    }
}
