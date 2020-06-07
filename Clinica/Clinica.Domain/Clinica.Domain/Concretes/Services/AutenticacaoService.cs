using System;
using Clinica.Domain.Interfaces.Repositories.Base;
using Clinica.Domain.Interfaces.Services;
using Clinica.Domain.Models;

namespace Clinica.Domain.Concretes.Services
{
    public class AutenticacaoService : IAutenticacaoService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public AutenticacaoService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public Usuario Login(string login, string senha)
        {
            var usuario = _usuarioRepository.ObterUsuarioPorLoginSenha(login, senha);

            if (usuario == null)
            {
                throw new Exception("Usuario inválido");
            }

            return usuario;
        }
    }
}
