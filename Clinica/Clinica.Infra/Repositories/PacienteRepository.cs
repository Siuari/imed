using System;
using System.Linq;
using Clinica.Domain.Interfaces.Repositories;
using Clinica.Domain.Models;
using Clinica.Infra.Context;
using Clinica.Infra.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace Clinica.Infra.Repositories
{
    public class PacienteRepository : RepositoryBase<Paciente>, IPacienteRepository
    {
        private readonly ClinicaContext _context;

        public PacienteRepository(ClinicaContext context) : base(context)
        {
            _context = context;
        }

        public Paciente ObterPorId(Guid id)
        {
            return _context.Set<Paciente>()
                .Where(x => x.Id == id)
                .Include(x => x.Endereco)
                .FirstOrDefault();
        }
    }
}
