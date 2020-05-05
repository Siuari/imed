using Clinica.Domain.Models.Base;
using System;

namespace Clinica.Domain.Models
{
    public class ReceitaMedica : Entity
    {
        public Guid IdConsulta { get; set; }
        public string Descricao { get; set; }
        public DateTime DataEmissao { get; set; }

        public Consulta Consulta { get; set; }
    }
}
