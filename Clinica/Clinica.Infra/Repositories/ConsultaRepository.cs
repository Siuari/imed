using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Clinica.Domain.Enums;
using Clinica.Domain.Models;
using Clinica.Infra.Context;
using Clinica.Infra.Repositories.Base;
using Clinica.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Clinica.Infra.Repositories
{
    public class ConsultaRepository : RepositoryBase<Consulta>, IConsultaRepository
    {
        private readonly ClinicaContext _context;

        public ConsultaRepository(ClinicaContext context) : base(context)
        {
            _context = context;
        }

        public ICollection<Consulta> ListarConsultas(Expression<Func<Consulta, bool>> predicate)
        {
            return _context.Set<Consulta>()
                .Include(x => x.Paciente)
                .Include(x => x.Cobertura)
                .Include(x => x.HorarioAtendimento).ThenInclude(x => x.Horario)
                .Where(predicate)
                .ToList();
        }

        public Consulta ObterConsultaAgendada(Guid idPaciente)
        {
            return _context.Set<Consulta>()
                .Include(consulta => consulta.Paciente)
                .Include(consulta => consulta.HorarioAtendimento)
                .ThenInclude(horarioAtendimento => horarioAtendimento.Medico)
                .Include(consulta => consulta.HorarioAtendimento)
                .ThenInclude(horarioAtendimento => horarioAtendimento.Horario)
                .FirstOrDefault(consulta => consulta.IdPaciente == idPaciente && consulta.StatusConsulta == EnumStatusConsulta.Agendada);
        }

        public Consulta ObterNaoFinalizadaPorId(Guid id)
        {
            return _context.Set<Consulta>()
                .FirstOrDefault(consulta => consulta.Id == id && consulta.StatusConsulta == EnumStatusConsulta.Agendada);
        }

        public ICollection<Consulta> ListarConsultasVencidas()
        {
            return _context.Set<Consulta>()
                .Include(x => x.HorarioAtendimento).ThenInclude(x => x.Horario)
                .Include(x => x.HorarioAtendimento).ThenInclude(x => x.Medico.Especialidade)
                .Include(x => x.Paciente)
                .Where(consulta => consulta.DataConsulta < DateTime.Now)
                .ToList();
        }
    }
}
