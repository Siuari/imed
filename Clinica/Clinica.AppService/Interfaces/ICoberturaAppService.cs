using System;
using System.Collections.Generic;
using System.Text;
using Clinica.AppService.ViewModels.Cobertura;

namespace Clinica.AppService.Interfaces
{
    public interface ICoberturaAppService
    {
        CoberturaViewModel ObterPorId(Guid id);
        ICollection<CoberturaViewModel> Listar();

    }
}
