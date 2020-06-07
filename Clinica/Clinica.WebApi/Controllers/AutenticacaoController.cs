using System;
using Clinica.AppService.Interfaces;
using Clinica.AppService.ViewModels;
using Clinica.WebApi.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Clinica.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutenticacaoController : ControllerBase
    {
        private readonly IAutenticacaoAppService _autenticacaoAppService;

        public AutenticacaoController(IAutenticacaoAppService autenticacaoAppService)
        {
            _autenticacaoAppService = autenticacaoAppService;
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login([FromBody] LoginViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("View model inválido");
            }

            try
            {
                var result = _autenticacaoAppService.Login(viewModel);

                return Ok(new ResponseHelper("LOGADO COM SUCESSO", true, result));
            }
            catch (Exception e)
            {
                return Ok(new ResponseHelper(e.Message, false, null));
            }
        }
    }
}