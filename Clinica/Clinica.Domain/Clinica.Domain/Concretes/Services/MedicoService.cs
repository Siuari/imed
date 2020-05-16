using Clinica.Domain.Interfaces.Repositories;
using Clinica.Domain.Interfaces.Repositories.Base;
using Clinica.Domain.Models;
using System;
using System.Collections.Generic;

namespace Clinica.Domain.Concretes.Services
{
    public class MedicoSercive : IMedicoService
    {
        private readonly IMedicoRepository _medicoRepository;

        public MedicoSercive(IMedicoRepository medicoRepository)
        {
            _medicoRepository = medicoRepository;
        }

        public void CadastrarMedico(Medico medico)
        {
            var medicoCadastrado = _medicoRepository.ObterPorCrm(medico.Crm);

            if(medicoCadastrado != null)
                throw new Exception("CRM já cadastrado");

            medico.GerarId();
            _medicoRepository.Inserir(medico);
            _medicoRepository.Salvar();
        }

        public ICollection<Medico> ListarMedicos()
        {
            return _medicoRepository.ListarMedicos();
        }
    }
}
