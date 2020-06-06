using Clinica.AppService.Interfaces;
using Clinica.AppService.ViewModels.Medico;
using Clinica.WebApi.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Clinica.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        private readonly IMedicoAppService _medicoAppService;

        public MedicoController(IMedicoAppService medicoAppService)
        {
            _medicoAppService = medicoAppService;
        }

        [HttpPost]
        [Route("cadastro-medico")]
        public IActionResult CadastrarMedico([FromBody] CadastrarMedicoViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return BadRequest("Erro, view model invalida");

            try
            {
                _medicoAppService.CadastrarMedico(viewModel);

                return Ok(new ResponseHelper("Cadastro concluido com sucesso", true, null));
            }
            catch (Exception e)
            {
                return BadRequest(new ResponseHelper(e.Message, false, e));
            }
        }

        [HttpPut]
        [Route("atualizar-medico")]
        public IActionResult AtualizarMedico([FromBody] AtualizarMedicoViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return BadRequest("Erro, view model invalida");

            try
            {
                var result = _medicoAppService.AtualizarMedico(viewModel);

                return Ok(new ResponseHelper("Cadastro concluido com sucesso", true, null));
            }
            catch (Exception e)
            {
                return BadRequest(new ResponseHelper(e.Message, false, e));
            }
        }

        [HttpGet]
        [Route("listar-medicos")]
        public IActionResult ListarMedicos()
        {
            try
            {
                var result = _medicoAppService.ListarMedicos();

                return Ok(new ResponseHelper("", true, result));
            }
            catch (Exception e)
            {
                return BadRequest(new ResponseHelper(e.Message, false, e));
            }
        }

        [HttpDelete]
        [Route("deletar-medico")]
        public IActionResult DeletarMedicos(Guid id)
        {
            try
            {
                var result = _medicoAppService.DeletarMedico(id);

                return Ok(new ResponseHelper("", true, result));
            }
            catch (Exception e)
            {
                return BadRequest(new ResponseHelper(e.Message, false, e));
            }
        }
    }
}