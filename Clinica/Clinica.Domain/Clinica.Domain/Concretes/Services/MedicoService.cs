using Clinica.Domain.Interfaces.Services;
using Clinica.Domain.Models;
using System;
using System.Collections.Generic;
using Clinica.Domain.Interfaces.Repositories;

namespace Clinica.Domain.Concretes.Services
{
    public class MedicoSercive : IMedicoService
    {
        private readonly IMedicoRepository _medicoRepository;

        public MedicoSercive(IMedicoRepository medicoRepository)
        {
            _medicoRepository = medicoRepository;
        }

        public Medico CadastrarMedico(Medico medico)
        {
            var medicoCadastrado = _medicoRepository.ObterPorCrm(medico.Crm);

            if(medicoCadastrado != null)
                throw new Exception("CRM já cadastrado");

            medico.GerarId();
            _medicoRepository.Inserir(medico);
            _medicoRepository.Salvar();

            return medico;
        }

        public Medico AtualizarMedico(Medico medico)
        {
            var medicoAtualizado = _medicoRepository.Atualizar(medico);
            _medicoRepository.Salvar();

            return medicoAtualizado;
        }

        public Medico DeletarMedico(Guid id)
        {
            var medico = _medicoRepository.Remover(id);
            _medicoRepository.Salvar();

            return medico;
        }

        public ICollection<Medico> ListarMedicos()
        {
            return _medicoRepository.ListarMedicos();
        }
    }
}
