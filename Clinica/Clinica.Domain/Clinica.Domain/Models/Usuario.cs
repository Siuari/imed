using System;
using Clinica.Domain.Enums;
using Clinica.Domain.Models.Base;

namespace Clinica.Domain.Models
{
    public class Usuario : Entity
    {
        public string Login { get; private set; }
        public string Senha { get; private set; }
        public Guid IdPaciente { get; private set; }
        public EnumTipoUsuario TipoUsuario { get; private set; }

        public virtual Paciente Paciente { get; private set; }

        public Usuario(string login, string senha, Guid idPaciente, EnumTipoUsuario tipoUsuario)
        {
            Login = login;
            Senha = senha;
            IdPaciente = idPaciente;
            TipoUsuario = tipoUsuario;
        }
    }
}
