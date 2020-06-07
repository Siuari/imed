using System;
using System.Collections.Generic;

namespace Clinica.AppService.ViewModels.Consulta
{
    public class PagarConsultaViewModel
    {
        public Guid Id { get; set; }
        public IEnumerable<PagamentoViewModel> Pagamentos { get; set; }
    }
}
