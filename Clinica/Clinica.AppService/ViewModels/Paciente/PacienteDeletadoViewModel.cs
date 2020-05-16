using System;

namespace Clinica.AppService.ViewModels.Paciente
{
    public class PacienteDeletadoViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime DateNascimento { get; set; }
        public string NumeroTelefone { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
    }
}
