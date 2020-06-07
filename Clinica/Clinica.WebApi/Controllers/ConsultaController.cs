using System;
using Clinica.AppService.Interfaces;
using Clinica.AppService.ViewModels.Consulta;
using Clinica.WebApi.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Clinica.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaController : ControllerBase
    {
        private readonly IConsultaAppService _consultaAppService;

        public ConsultaController(IConsultaAppService consultaAppService)
        {
            _consultaAppService = consultaAppService;
        }

        [HttpGet]
        [Route("listar-por-idPaciente")]
        public IActionResult ListarPorIdPaciente(Guid idPaciente)
        {
            try
            {
                var result = _consultaAppService.ListarConsultasPorIdPaciente(idPaciente);

                return Ok(new ResponseHelper("", true, result));
            }
            catch (Exception e)
            {
                return Ok(new ResponseHelper(e.Message, false, e));
            }
        }

        [HttpGet]
        [Route("listar-por-idMedico")]
        public IActionResult ListarPoridMedico(Guid idMedico)
        {
            try
            {
                var result = _consultaAppService.ListarConsultasPorIdMedico(idMedico);

                return Ok(new ResponseHelper("", true, result));
            }
            catch (Exception e)
            {
                return Ok(new ResponseHelper(e.Message, false, e));
            }
        }

        [HttpGet]
        [Route("obter-por-id")]
        public IActionResult ObterPorId(Guid id)
        {
            try
            {
                var result = _consultaAppService.ObterConsultaPorId(id);

                return Ok(new ResponseHelper("", true, result));
            }
            catch (Exception e)
            {
                return Ok(new ResponseHelper(e.Message, false, e));
            }
        }

        [HttpGet]
        [Route("obter-consulta-agendada")]
        public IActionResult ObterConsultaAgendada(Guid idPaciente)
        {
            try
            {
                var result = _consultaAppService.ObterConsultaAgendada(idPaciente);

                return Ok(new ResponseHelper("", true, result));
            }
            catch (Exception e)
            {
                return Ok(new ResponseHelper(e.Message, false, e));
            }
        }

        [HttpPost]
        [Route("cadastrar-consulta")]
        public IActionResult CadastrarConsulta([FromBody] CadastrarConsultaViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return Ok(new ResponseHelper("VIEW MODEL INVALIDA", false, null));

            try
            {
                _consultaAppService.InserirConsulta(viewModel);

                return Ok(new ResponseHelper("CONSULTA CADASTRADA COM SUCESSO", true, null));
            }
            catch (Exception e)
            {
                return Ok(new ResponseHelper(e.Message, false, e.InnerException));
            }
        }

        [HttpPut]
        [Route("pagar-consulta")]
        public IActionResult PagarConsulta([FromBody] PagarConsultaViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return Ok(new ResponseHelper("VIEW MODEL INVALIDA", false, null));

            try
            {
                var result = _consultaAppService.PagarConsulta(viewModel);

                return Ok(new ResponseHelper("CONSULTA CADASTRADA COM SUCESSO", true, result));
            }
            catch (Exception e)
            {
                return Ok(new ResponseHelper(e.Message, false, e.InnerException));
            }

        }
    }
}