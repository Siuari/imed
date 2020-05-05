using System.Collections.Generic;
using Clinica.Domain.Models.Base;

namespace Clinica.Domain.Models
{
    public class FormaPagamento : Entity
    {
        public string Descricao { get; set; }

        public IEnumerable<Pagamento> Pagamentos { get; set; }
    }
}
