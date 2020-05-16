using System;
using System.Collections.Generic;
using System.Text;

namespace Clinica.AppService.ViewModels.Paciente
{
    public class AtualizarNomeCpfPaciente
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
    }
}
