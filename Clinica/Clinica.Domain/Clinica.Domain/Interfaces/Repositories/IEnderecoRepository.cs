using System;
using Clinica.Domain.Interfaces.Repositories.Base;
using Clinica.Domain.Models;

namespace Clinica.Domain.Interfaces.Repositories
{
    public interface IEnderecoRepository : IRepositoryBase<Guid, Endereco>
    }
}
