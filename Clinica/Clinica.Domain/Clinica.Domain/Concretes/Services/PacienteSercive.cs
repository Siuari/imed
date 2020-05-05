using System;
using System.Linq;
using Clinica.Domain.Concretes.Services.Base;
using Clinica.Domain.Interfaces.Repositories;
using Clinica.Domain.Interfaces.Repositories.Base;
using Clinica.Domain.Interfaces.Services;
using Clinica.Domain.Models;

namespace Clinica.Domain.Concretes.Services
{
    public class PacienteSercive : ServiceBase<Paciente>, IPacienteService
    {
        private readonly IPacienteRepository _pacienteRepository;
        private readonly IEnderecoRepository _enderecoRepository;

        public PacienteSercive(IRepositoryBase<Paciente> repositoryBase, IPacienteRepository pacienteRepository, IEnderecoRepository enderecoRepository) : base(repositoryBase)
        {
            _pacienteRepository = pacienteRepository;
            _enderecoRepository = enderecoRepository;
        }

        public Paciente Inserir(Paciente paciente)
        {
            var pacienteExistente = _pacienteRepository.Listar(p => p.Cpf == paciente.Cpf).FirstOrDefault();

            if (pacienteExistente != null) throw new Exception("CPF JA CADASTRADO!!");

            var endereco = InserirEnderecoDoPaciente(paciente.Endereco);


            paciente.GerarId();
            paciente.AlocarEndereco(endereco.Id.Value);

            _pacienteRepository.Inserir(paciente);
            Salvar();

            return paciente;
        }

        private Endereco InserirEnderecoDoPaciente(Endereco endereco)
        {
            var enderecoCadastrado = _enderecoRepository.Listar(e => e.Cep == endereco.Cep 
                                                                     && e.Bairro.ToUpper() == endereco.Bairro.ToUpper()
                                                                     && e.Rua.ToUpper() == endereco.Rua.ToUpper()
                                                                     && e.Numero.ToUpper() == endereco.Numero.ToUpper());

            if (enderecoCadastrado.Any()) 
                return enderecoCadastrado.FirstOrDefault();
            
            endereco.GerarId();
            _enderecoRepository.Inserir(endereco);
            Salvar();

            return endereco;
        }

        public Paciente Atualizar(Paciente paciente)
        {
            throw new System.NotImplementedException();
        }

        public Paciente Deletar(Paciente paciente)
        {
            throw new System.NotImplementedException();
        }
    }
}
