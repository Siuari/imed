using Clinica.Domain.Interfaces.Repositories;
using Clinica.Domain.Interfaces.Services;
using Clinica.Domain.Models;
using System;
using System.Linq;
using Clinica.Domain.Enums;
using Clinica.Domain.Interfaces.Repositories.Base;

namespace Clinica.Domain.Concretes.Services
{
    public class PacienteService : IPacienteService
    {
        private readonly IPacienteRepository _pacienteRepository;
        private readonly IEnderecoRepository _enderecoRepository;
        private readonly IUsuarioRepository _usuarioRepository;

        public PacienteService(IPacienteRepository pacienteRepository, IEnderecoRepository enderecoRepository, IUsuarioRepository usuarioRepository)
        {
            _pacienteRepository = pacienteRepository;
            _enderecoRepository = enderecoRepository;
            _usuarioRepository = usuarioRepository;
        }

        public Paciente Inserir(Paciente paciente)
        {
            var pacienteExistente = _pacienteRepository.Listar(p => p.Cpf == paciente.Cpf).FirstOrDefault();

            if (pacienteExistente != null) throw new Exception("CPF JA CADASTRADO!!");

            var endereco = InserirEnderecoDoPaciente(paciente.Endereco);


            paciente.GerarId();
            paciente.AlocarEndereco(endereco.Id.Value);
            paciente.GerarUsuario(EnumTipoUsuario.Paciente);

            _pacienteRepository.Inserir(paciente);
            _usuarioRepository.Inserir(paciente.Usuario);
            _pacienteRepository.Salvar();

            //_usuarioRepository.Salvar();

            return paciente;
        }

        public Paciente ObterPorId(Guid id)
        {
            return _pacienteRepository.ObterPorId(id);
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
            _enderecoRepository.Salvar();

            return endereco;
        }

        public Paciente Atualizar(Paciente paciente)
        {
            throw new System.NotImplementedException();
        }

        public Paciente RemoverPaciente(Guid id)
        {
            return _pacienteRepository.Remover(id);
        }
    }
}
