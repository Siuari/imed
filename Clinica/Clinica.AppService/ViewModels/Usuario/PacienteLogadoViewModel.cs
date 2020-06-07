using System;
using System.Collections.Generic;
using System.Text;

namespace Clinica.AppService.ViewModels.Usuario
{
    public class PacienteLogadoViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime DateNascimento { get; set; }
        public string NumeroTelefone { get; set; }
        public string Cpf { get; set; }
    }
}
