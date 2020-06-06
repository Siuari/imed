using System;
using System.Collections.Generic;
using Clinica.Domain.Models;

namespace Clinica.Domain.Interfaces.Services
{
    public interface ICoberturaService
    {
        Cobertura ObterPorId(Guid id);
        ICollection<Cobertura> ListarCobertura();
    }
}
