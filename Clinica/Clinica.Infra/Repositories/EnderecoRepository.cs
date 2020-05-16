using Clinica.Domain.Interfaces.Repositories;
using Clinica.Domain.Models;
using Clinica.Infra.Context;
using Clinica.Infra.Repositories.Base;

namespace Clinica.Infra.Repositories
{
    public class EnderecoRepository : RepositoryBase<Endereco>, IEnderecoRepository
    {
        private readonly ClinicaContext _context;

        public EnderecoRepository(ClinicaContext context) : base(context)
        {
            _context = context;
        }
    }
}
