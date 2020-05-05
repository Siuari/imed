using System.Collections.Generic;
using Clinica.Domain.Models.Base;

namespace Clinica.Domain.Models
{
    public class Endereco : Entity
    {
        public string Rua { get; private set; }
        public string Bairro { get; private set; }
        public string Numero { get; private set; }
        public string Cep { get; private set; }

        public IEnumerable<Paciente> Pacientes { get; private set; }


    }
}
