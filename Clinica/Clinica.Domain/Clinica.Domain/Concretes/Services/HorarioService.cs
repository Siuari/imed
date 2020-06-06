using System;
using System.Collections.Generic;
using System.Text;
using Clinica.Domain.Interfaces.Repositories;
using Clinica.Domain.Interfaces.Services;
using Clinica.Domain.Models;

namespace Clinica.Domain.Concretes.Services
{
    public class HorarioService : IHorarioService
    {
        private readonly IHorarioRepository _horarioRepository;

        public HorarioService(IHorarioRepository horarioRepository)
        {
            _horarioRepository = horarioRepository;
        }

        public ICollection<Horario> ListarHorarios()
        {
            return _horarioRepository.Listar();
        }
    }
}
