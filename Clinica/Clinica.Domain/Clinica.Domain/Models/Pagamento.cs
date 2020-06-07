using Clinica.Domain.Models.Base;
using System;

namespace Clinica.Domain.Models
{
    public class Pagamento : Entity
    {
        public Guid IdConsulta { get; private set; }
        public Guid IdFormaPagamento { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime DataPagamento { get; private set; }

        public Consulta Consulta { get; private set; }
        public FormaPagamento FormaPagamento { get; private set; }

        public void AtualizarDataPagamento()
        {
            DataPagamento = DateTime.Now;
        }
    }
}
