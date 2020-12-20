using System.Linq;
using Clinica.Domain.Interfaces.Repositories.Base;
using Clinica.Domain.Models;
using Clinica.Infra.Context;
using Clinica.Infra.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace Clinica.Infra.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        private readonly ClinicaContext _context;

        public UsuarioRepository(ClinicaContext context) : base(context)
        {
            _context = context;
        }

        public Usuario ObterUsuarioPorLoginSenha(string login, string senha)
        {
            return _context.Set<Usuario>()
                .Include(usuario => usuario.Paciente)
                .FirstOrDefault(usuario => usuario.Login == login && usuario.Senha == senha);
        }
    }
}
