using System;
using Clinica.Domain.Models;

namespace Clinica.Domain.Interfaces.Repositories.Base
{
    public interface IUsuarioRepository : IRepositoryBase<Guid, Usuario>
    {
        Usuario ObterUsuarioPorLoginSenha(string login, string senha);
    }
}
