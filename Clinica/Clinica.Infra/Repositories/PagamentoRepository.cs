using Clinica.Domain.Interfaces.Repositories.Base;
using Clinica.Domain.Models;
using Clinica.Infra.Context;
using Clinica.Infra.Repositories.Base;

namespace Clinica.Infra.Repositories
{
    public class PagamentoRepository : RepositoryBase<Pagamento>, IPagamentoRepository
    {
        private readonly ClinicaContext _context;

        public PagamentoRepository(ClinicaContext context) : base(context)
        {
            _context = context;
        }
    }
}
