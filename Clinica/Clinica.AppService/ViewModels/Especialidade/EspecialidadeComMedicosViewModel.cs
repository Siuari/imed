using System;
using System.Collections.Generic;
using System.Text;

namespace Clinica.AppService.ViewModels.Especialidade
{
    public class EspecialidadeComMedicosViewModel
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public ICollection<MedicoViewModel> Medicos { get; set; }
    }
}
