using System;
using System.Collections.Generic;
using System.Text;
using Clinica.Domain.Enums;

namespace Clinica.AppService.ViewModels
{
    public class UsuarioCadastrarViewModel
    {
        public string Login { get; private set; }
        public string Senha { get; private set; }
        public EnumTipoUsuario TipoUsuario { get; private set; }
    }
}
