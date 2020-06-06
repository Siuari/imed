using System;
using System.Collections.Generic;
using Clinica.Domain.Enums;
using Clinica.Domain.Models.Base;

namespace Clinica.Domain.Models
{
    public class Paciente : Entity
    {
        public Guid IdEndereco { get; private set; }
        public string Nome { get; private set; }
        public DateTime DateNascimento { get; private set; }
        public string NumeroTelefone { get; private set; }
        public string Rg { get; private set; }
        public string Cpf { get; private set; }

        public Endereco Endereco { get; private set; }
        public Usuario Usuario { get; private set; }
        public IEnumerable<Consulta> Consultas { get; private set; }

        public void AlocarEndereco(Guid idEndereco)
        {
            IdEndereco = idEndereco;
        }

        public void AlterarNome(string nome)
        {
            Nome = nome;
        }

        public void AlterarCpf(string cpf)
        {
            Cpf = cpf;
        }

        public void GerarUsuario(EnumTipoUsuario tipoUsuario)
        {
            Usuario = new Usuario(Cpf, Cpf, Id.Value, tipoUsuario);
            Usuario.GerarId();
        }
    }
}
