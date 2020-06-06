using System;
using System.Collections.Generic;
using System.Linq;
using Clinica.Domain.Enums;
using Clinica.Domain.Interfaces.Repositories;
using Clinica.Domain.Models;
using Clinica.Infra.Context;
using Clinica.Infra.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace Clinica.Infra.Repositories
{
    public class HorarioAtendimentoRepository : RepositoryBase<HorarioAtendimento>, IHorarioAtendimentoRepository
    {
        private readonly ClinicaContext _context;

        public HorarioAtendimentoRepository(ClinicaContext context) : base(context)
        {
            _context = context;
        }

        public HorarioAtendimento ObterComHorario(Guid id)
        {
            return _context.Set<HorarioAtendimento>()
                .Include(x => x.Horario)
                .FirstOrDefault(x => x.Id == id);
        }

        public ICollection<HorarioAtendimento> ListarComConsulta(EnumDia dia, Guid idEspecialidade)
        {
            return _context.Set<HorarioAtendimento>()
                .Include(x => x.Consultas)
                .Include(x => x.Horario)
                .Where(x => x.Horario.Dia == dia && x.Medico.IdEspecialidade == idEspecialidade)
                .ToList();
        }

        public ICollection<HorarioAtendimento> ListarComMedicoHorario()
        {
            return _context.Set<HorarioAtendimento>()
                .Include(x => x.Medico)
                .Include(x => x.Horario)
                .ToList();
        }
    }
}
