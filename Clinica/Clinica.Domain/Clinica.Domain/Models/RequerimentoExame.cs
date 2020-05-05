using System;
using Clinica.Domain.Models.Base;

namespace Clinica.Domain.Models
{
    public class RequerimentoExame : Entity
    {
        public Guid IdConsulta { get; set; }
        public string Descricao { get; set; }
        public DateTime DataEmissao { get; set; }

        public Consulta Consulta { get; set; }
    }
}
