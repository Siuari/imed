using System;
using System.Collections.Generic;
using System.Text;
using Clinica.Domain.Enums;

namespace Clinica.AppService.ViewModels.Usuario
{
    public class UsuarioLogadoViewModel
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public EnumTipoUsuario TipoUsuario { get; set; }
        public PacienteLogadoViewModel Paciente  { get; set; }
    }
}
