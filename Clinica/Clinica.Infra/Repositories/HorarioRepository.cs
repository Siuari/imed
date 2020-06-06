using Clinica.Domain.Interfaces.Repositories;
using Clinica.Domain.Models;
using Clinica.Infra.Context;
using Clinica.Infra.Repositories.Base;

namespace Clinica.Infra.Repositories
{
    public class HorarioRepository : RepositoryBase<Horario>, IHorarioRepository
    {
        private readonly ClinicaContext _context;

        public HorarioRepository(ClinicaContext context) : base(context)
        {
            _context = context;
        }
    }
}
