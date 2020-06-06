using System.Collections.Generic;
using Clinica.Domain.Models;

namespace Clinica.Domain.Interfaces.Services
{
    public interface IHorarioService
    {
        ICollection<Horario> ListarHorarios();
    }
}
