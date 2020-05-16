using Clinica.AppService.Interfaces;
using Clinica.AppService.ViewModels;
using Clinica.WebApi.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Clinica.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private readonly IPacienteAppService _pacienteAppService;

        public PacienteController(IPacienteAppService pacienteAppService)
        {
            _pacienteAppService = pacienteAppService;
        }

        [HttpPost]
        [Route("cadastrar")]
        public IActionResult CadastrarPaciente([FromBody] CadastrarPacienteViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Erro! View Model invalida");
            }

            try
            {
                _pacienteAppService.Inserir(viewModel);

                return Ok(new ResponseHelper("Paciente cadastrado com sucesso", true, null));
            }
            catch (Exception e)
            {
                return BadRequest(new ResponseHelper(e.Message, false, e));
            }
        }

        [HttpGet]
        [Route("obter-por-id")]
        public IActionResult ObterPacientePorId(Guid id)
        {
            try
            {
                var result = _pacienteAppService.ObterPorId(id);

                return Ok(new ResponseHelper("", true, result));
            }
            catch (Exception e)
            {
                return BadRequest(new ResponseHelper(e.Message, false, e));
            }
        }

        [HttpPut]
        [Route("remover-paciente")]
        public IActionResult RemoverPaciente(Guid id)
        {
            try
            {
                var result = _pacienteAppService.RemoverPaciente(id);

                return Ok(new ResponseHelper("Paciente removido com sucesso", true,result));
            }
            catch (Exception e)
            {
                return BadRequest(new ResponseHelper(e.Message, false, e));
            }
        }
    }
}