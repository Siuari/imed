using Clinica.Domain.Models;
using Clinica.Infra.Context;
using Clinica.Infra.Repositories.Base;
using Clinica.Domain.Interfaces.Repositories;

namespace Clinica.Infra.Repositories
{
    public class ConsultaRepository : RepositoryBase<Consulta>, IConsultaRepository
    {
        private readonly ClinicaContext _context;

        public ConsultaRepository(ClinicaContext context) : base(context)
        {
            _context = context;
        }
    }
}
