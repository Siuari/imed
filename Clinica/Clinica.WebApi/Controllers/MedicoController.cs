using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinica.AppService.Interfaces;
using Clinica.AppService.ViewModels.Medico;
using Clinica.WebApi.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

                return Ok(new ResponseHelper {Message = "Cadastro realizado com sucesso"});
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpGet]
        [Route("listar-medicos")]
        public IActionResult ListarMedicos()
        {
            try
            {
                return Ok(_medicoAppService.ListarMedicos());
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}