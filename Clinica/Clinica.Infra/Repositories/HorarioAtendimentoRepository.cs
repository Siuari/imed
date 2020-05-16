using Clinica.Domain.Interfaces.Repositories;
using Clinica.Domain.Models;
using Clinica.Infra.Context;
using Clinica.Infra.Repositories.Base;

namespace Clinica.Infra.Repositories
{
    public class HorarioAtendimentoRepository : RepositoryBase<HorarioAtendimento>, IHorarioAtendimentoRepository
    {
        private readonly ClinicaContext _context;

        public HorarioAtendimentoRepository(ClinicaContext context) : base(context)
        {
            _context = context;
        }
    }
}
