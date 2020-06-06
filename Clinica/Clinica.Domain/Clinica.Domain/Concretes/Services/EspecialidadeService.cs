using Clinica.Domain.Interfaces.Repositories;
using Clinica.Domain.Interfaces.Services;
using Clinica.Domain.Models;
using System;
using System.Collections.Generic;

namespace Clinica.Domain.Concretes.Services
{
    public class EspecialidadeService : IEspecialidadeService
    {
        private readonly IEspecialidadeRepository _especialidadeRepository;

        public EspecialidadeService(IEspecialidadeRepository especialidadeRepository)
        {
            _especialidadeRepository = especialidadeRepository;
        }


        public ICollection<Especialidade> Listar()
        {
            return _especialidadeRepository.Listar();
        }

        public Especialidade ObterPorIdComMedicos(Guid id)
        {
            return _especialidadeRepository.ObterPorIdComMedicos(id);
        }
    }
}
