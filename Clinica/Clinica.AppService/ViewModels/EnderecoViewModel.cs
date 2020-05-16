using System;

namespace Clinica.AppService.ViewModels
{
    public class EnderecoViewModel
    {
        public Guid Id { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }
    }
}
