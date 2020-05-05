using Clinica.Domain.Models.Base;
using System;

namespace Clinica.Domain.Models
{
    public class Pagamento : Entity
    {
        public Guid IdConsulta { get; set; }
        public Guid IdFormaPagamento { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataPagamento { get; set; }

        public Consulta Consulta { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
    }
}
