using Clinica.Domain.Interfaces.Repositories.Base;
using Clinica.Domain.Models;
using Clinica.Infra.Context;
using Clinica.Infra.Repositories.Base;

namespace Clinica.Infra.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        private readonly ClinicaContext _context;

        public UsuarioRepository(ClinicaContext context) : base(context)
        {
            _context = context;
        }
    }
}
