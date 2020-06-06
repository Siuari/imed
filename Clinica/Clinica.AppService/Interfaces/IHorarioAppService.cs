using System;
using System.Collections.Generic;
using System.Text;
using Clinica.AppService.ViewModels.Horario;

namespace Clinica.AppService.Interfaces
{
    public interface IHorarioAppService
    {
        ICollection<HorarioListagemViewModel> ListarHorarios();
    }
}
