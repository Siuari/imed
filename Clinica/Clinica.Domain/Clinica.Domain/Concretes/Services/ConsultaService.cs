using Clinica.Domain.Interfaces.Repositories;
using Clinica.Domain.Interfaces.Services;
using Clinica.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Clinica.Domain.Enums;

namespace Clinica.Domain.Concretes.Services
{
    public class ConsultaService : IConsultaService
    {
        private readonly IConsultaRepository _consultaRepository;
        private readonly IHorarioAtendimentoRepository _horarioAtendimentoRepository;
        private static int LIMITE_CONSULTAS_POR_HORARIO = 3;

        public ConsultaService(IConsultaRepository consultaRepository, IHorarioAtendimentoRepository horarioAtendimentoRepository)
        {
            _consultaRepository = consultaRepository;
            _horarioAtendimentoRepository = horarioAtendimentoRepository;
        }
        
        public void InserirConsulta(Consulta contulta)
        {
            var consultasMarcadas = _consultaRepository.Listar(x => x.IdHorarioAtendimento == contulta.IdHorarioAtendimento && x.DataConsulta == contulta.DataConsulta);
            var horarioAtendimento= _horarioAtendimentoRepository.ObterComHorario(contulta.IdHorarioAtendimento);

            if (consultasMarcadas.Count > LIMITE_CONSULTAS_POR_HORARIO)
                throw new Exception("LIMITE DE CONSULTAS EXCEDIDO");

            if (horarioAtendimento == null || (int)contulta.DataConsulta.DayOfWeek != (int)horarioAtendimento.Horario.Dia-1) 
                throw new Exception("Erro, horario de atendimento invalido");

            contulta.GerarId();
            contulta.ConsultaAgendada();

            _consultaRepository.Inserir(contulta);
            _consultaRepository.Salvar();
        }

        public Consulta CancelarConsulta(Guid id)
        {
            var consulta =_consultaRepository.Listar(consulta => consulta.Id == id).FirstOrDefault();
            consulta.AlterarStatus(EnumStatusConsulta.Cancelada);

            _consultaRepository.Atualizar(consulta);
            _consultaRepository.Salvar();

            return consulta;
        }

        public Consulta AtualizarConsulta(Consulta conulsta)
        {
            var consulta = _consultaRepository.Atualizar(conulsta);
            _consultaRepository.Salvar();

            return conulsta;
        }

        public ICollection<Consulta> ListarConsultasPorIdPaciente(Guid idPaciente)
        {
            return _consultaRepository.ListarConsultas(x => x.IdPaciente == idPaciente);
        }

        public ICollection<Consulta> ListarConsultasPorIdMedico(Guid idMedico)
        {
            return _consultaRepository.ListarConsultas(x => x.HorarioAtendimento.IdMedico == idMedico);
        }

        public Consulta ObterConsultaPorId(Guid id)
        {
            return _consultaRepository.ListarConsultas(x => x.Id == id).FirstOrDefault();
        }

        public Consulta ObterConsultaAgendada(Guid idPaciente)
        {
            return _consultaRepository.ObterConsultaAgendada(idPaciente);
        }

        public Consulta PagarConsulta(Guid id, IEnumerable<Pagamento> pagamentos)
        {
            var consulta = _consultaRepository.ObterNaoFinalizadaPorId(id);

            for (int i = 0; i < pagamentos.Count(); i++)
            {
                pagamentos.ElementAt(i).AtualizarDataPagamento();
            }

            consulta.AdicionarPagamento(pagamentos);

            if (!consulta.ConsultaQuitada())
            {
                throw new Exception("Valor incompleto para quitar a consulta");
            }
            
            consulta.AlterarStatus(EnumStatusConsulta.Finalizada);
            
            var consultaAtualizada = _consultaRepository.Atualizar(consulta);
            _consultaRepository.Salvar();

            return consultaAtualizada;
        }
    }
}
