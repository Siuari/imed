﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Clinica.AppService.ViewModels.Medico
{
    public class AtualizarMedicoViewModel
    {
        public Guid Id { get; set; }
        public Guid IdEspecialidade { get; set; }
        public string Nome { get; set; }
        public string Crm { get; set; }
    }
}
