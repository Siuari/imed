using System.Collections.Generic;
using Clinica.Domain.Interfaces.Repositories.Base;
using Clinica.Domain.Models;
using Clinica.Infra.Context;
using Clinica.Infra.Repositories.Base;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Clinica.Infra.Repositories
{
    public class MedicoRepository : RepositoryBase<Medico>, IMedicoRepository
    {
        private readonly ClinicaContext _context;
        
        public MedicoRepository(ClinicaContext context) : base(context)
        {
            _context = context; 
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
