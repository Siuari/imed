using System;
using System.Collections.Generic;
using Clinica.Domain.Enums;
using Clinica.Domain.Models.Base;

namespace Clinica.Domain.Models
{
    public class Consulta : Entity
    {
        public Guid IdPaciente { get; private set; }
        public Guid IdCobertura { get; private set; }
        public Guid IdHorarioAtendimento { get; private set; }
        public DateTime DataConsulta { get; private set; }
        public EnumStatusConsulta StatusConsulta { get; set; }
        public decimal ValorConsulta { get; set; }

        public Cobertura Cobertura { get; private set; }
        public Paciente Paciente { get; private set; }
        public HorarioAtendimento HorarioAtendimento { get; private set; }
        public IEnumerable<Pagamento> Pagamentos { get; private set; }
        public IEnumerable<ReceitaMedica> ReceitasMedica { get; private set; }
        public IEnumerable<RequerimentoExame> RequerimentosExame { get; private set; }

        public void AlterarStatus(EnumStatusConsulta statusConsulta)
        {
            if (StatusConsulta == EnumStatusConsulta.Cancelada || StatusConsulta == EnumStatusConsulta.Finalizada)
                throw new Exception("Consulta cancelada não pode ter o status alterado!");

            if (StatusConsulta == EnumStatusConsulta.Agendada &&
                (statusConsulta == EnumStatusConsulta.Finalizada || statusConsulta == EnumStatusConsulta.Cancelada))
            {
                StatusConsulta = statusConsulta;
            }
        }

        public void ConsultaAgendada()
        {
            StatusConsulta = EnumStatusConsulta.Agendada;
        }

        public void AdicionarPagamento(IEnumerable<Pagamento> pagamentos)
        {
            Pagamentos = pagamentos;
        }

        public bool ConsultaQuitada()
        {
            var somaPagamentos = 0.0M;

            foreach (Pagamento pagamento in Pagamentos)
            {
                somaPagamentos += pagamento.Valor;
            }

            return somaPagamentos == ValorConsulta;
        }
    }
}
