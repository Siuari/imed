using System;
using System.Collections.Generic;
using System.Text;
using Clinica.Domain.Models;

namespace Clinica.Domain.Interfaces.Services
{
    public interface IPagamentoService
    {
        Pagamento PagarConsulta(Pagamento pagamento);
    }
}
