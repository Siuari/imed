using System;
using Clinica.Domain.Enums;
using Clinica.Domain.Interfaces.Repositories;
using Clinica.Domain.Interfaces.Repositories.Base;
using Clinica.Domain.Interfaces.Services;
using Clinica.Domain.Models;

namespace Clinica.Domain.Concretes.Services
{
    public class PagamentoService : IPagamentoService
    {
        private readonly IPagamentoRepository _pagamentoRepository;
        private readonly IConsultaRepository _consultaRepository;

        public PagamentoService(IPagamentoRepository pagamentoRepository, IConsultaRepository consultaRepository)
        {
            _pagamentoRepository = pagamentoRepository;
            _consultaRepository = consultaRepository;
        }

        public Pagamento PagarConsulta(Pagamento pagamento)
        {
            var consultaPagar = _consultaRepository.ObterNaoFinalizadaPorId(pagamento.IdConsulta);

            if(consultaPagar == null)
            {
                throw new Exception("Está consulta não está finalizada ou não existe");
            }

            consultaPagar.AlterarStatus(EnumStatusConsulta.Finalizada);

            _pagamentoRepository.Inserir(pagamento);

            _pagamentoRepository.Salvar();

            return pagamento;
        }
    }
}
