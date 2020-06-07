using System;
using System.Collections.Generic;
using System.Text;
using Clinica.Domain.Enums;

namespace Clinica.AppService.ViewModels.Consulta
{
    public class ConsultaCadastradaViewModel
    {
        public Guid Id { get; set; }
        public DateTime DataConsulta { get; private set; }
        public EnumStatusConsulta StatusConsulta { get; set; }
        public decimal ValorConsulta { get; set; }
    }
}
