using System;
using Clinica.AppService.ViewModels.Medico;
using System.Collections.Generic;
using Clinica.AppService.ViewModels.Especialidade;

namespace Clinica.AppService.Interfaces
{
    public interface IEspecialidadeAppService
    {
        ICollection<EspecialidadeViewModel> Listar();
        EspecialidadeComMedicosViewModel ObterPorIdComMedicos(Guid id);
    }
}
