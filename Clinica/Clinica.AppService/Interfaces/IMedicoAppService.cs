using System.Collections.Generic;
using Clinica.AppService.ViewModels.Medico;

namespace Clinica.AppService.Interfaces
{
    public interface IMedicoAppService
    {
        void CadastrarMedico(CadastrarMedicoViewModel viewModel);
        ICollection<MedicoViewModel> ListarMedicos();
    }
}
