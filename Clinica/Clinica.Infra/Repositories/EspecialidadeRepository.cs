using Clinica.Domain.Interfaces.Repositories;
using Clinica.Domain.Models;
using Clinica.Infra.Context;
using Clinica.Infra.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Clinica.Infra.Repositories
{
    public class EspecialidadeRepository : RepositoryBase<Especialidade>, IEspecialidadeRepository
    {
        private readonly ClinicaContext _context;

        public EspecialidadeRepository(ClinicaContext context) : base(context)
        {
            _context = context;
        }

        public Especialidade ObterPorIdComMedicos(Guid id)
        {
            return _context.Set<Especialidade>()
                .Include(x => x.Medicos).ThenInclude(x => x.HorariosAtendimento)
                .FirstOrDefault(x => x.Id == id);
        }
    }
}
