using System;

namespace Clinica.AppService.ViewModels
{
    public class CadastrarPacienteViewModel
    {
        public string Nome { get; set; }
        public DateTime DateNascimento { get; set; }
        public string NumeroTelefone { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }

        public EnderecoCadastroClienteViewModel Endereco { get; set; }
    }
}
