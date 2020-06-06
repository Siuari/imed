using System;
using Clinica.AppService.Interfaces;
using Clinica.WebApi.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Clinica.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EspecialidadeController : ControllerBase
    {
        private readonly IEspecialidadeAppService _especialidadeAppService;

        public EspecialidadeController(IEspecialidadeAppService especialidadeAppService)
        {
            _especialidadeAppService = especialidadeAppService;
        }

        [HttpGet]
        [Route("listar")]
        public IActionResult ListarEspecialidades()
        {
            try
            {
                var result = _especialidadeAppService.Listar();

                return Ok(new ResponseHelper("", true, result));
            }
            catch (Exception e)
            {
                return BadRequest(new ResponseHelper(e.Message, false, e));
            }
        }        
        
        [HttpGet]
        [Route("obter-com-medicos")]
        public IActionResult ObterPorIdComMedicos(Guid id)
        {
            try
            {
                var result = _especialidadeAppService.ObterPorIdComMedicos(id);

                return Ok(new ResponseHelper("", true, result));
            }
            catch (Exception e)
            {
                return BadRequest(new ResponseHelper(e.Message, false, e));
            }
        }
    }
}