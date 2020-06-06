using System;
using System.Collections.Generic;
using System.Linq;
using Clinica.Domain.Enums;
using Clinica.Domain.Interfaces.Repositories;
using Clinica.Domain.Interfaces.Services;
using Clinica.Domain.Models;
using Clinica.Domain.Valore_Estaticos;

namespace Clinica.Domain.Concretes.Services
{
    public class HorarioAtendimentoService : IHorarioAtendimentoService
    {
        private readonly IHorarioAtendimentoRepository _horarioAtendimentoRepository;

        public HorarioAtendimentoService(IHorarioAtendimentoRepository horarioAtendimentoRepository)
        {
            _horarioAtendimentoRepository = horarioAtendimentoRepository;
        }

        public HorarioAtendimento CadastrarHorarioAtendimento(HorarioAtendimento horarioAtendimento)
        {
            horarioAtendimento.GerarId();

            _horarioAtendimentoRepository.Inserir(horarioAtendimento);
            _horarioAtendimentoRepository.Salvar();

            return horarioAtendimento;
        }

        public Tuple<DateTime, Guid> ObterHorarioAtendimentoDoDia(EnumDia dia, Guid idEspecialidade)
        {
            var dataReferencia = DateTime.Now;
            dataReferencia = dataReferencia.AddDays(CalcularProximoDia((int) dataReferencia.DayOfWeek+1, (int) dia));

            var horariosAtendimento = _horarioAtendimentoRepository.ListarComConsulta(dia, idEspecialidade);

            bool dataEncontrada = false;
            Guid idHorarioAtendimento = new Guid();

            while (!dataEncontrada)
            {
                foreach (var horarioAtendimento in horariosAtendimento)
                {
                    var consultas = horarioAtendimento.Consultas.Where(x => x.DataConsulta == dataReferencia);
                    if (consultas.Count() < DomainStaticValues.MAXIMO_CONSULTAS_HORARIO)
                    {
                        dataEncontrada = true;
                        idHorarioAtendimento = horarioAtendimento.Id.Value;
                        break;
                    }

                    dataReferencia = dataReferencia.AddDays(7);
                }
            }

            var resultado = new Tuple<DateTime, Guid>(dataReferencia, idHorarioAtendimento);

            return resultado;
        }

        public ICollection<HorarioAtendimento> ListarHorariosAtendimentos()
        {
            return _horarioAtendimentoRepository.ListarComMedicoHorario();
        }

        private int CalcularProximoDia(int diaReferencia, int diaPretendido)
        {
            int diasSemana = 7;

            if (diaPretendido < diaReferencia)
            {
                int valorDia = diaReferencia - diaPretendido;

                return diasSemana - valorDia;
            }

            if (diaPretendido > diaReferencia)
            {
                return diaPretendido - diaReferencia;
            }

            return 0;
        }
    }
}
