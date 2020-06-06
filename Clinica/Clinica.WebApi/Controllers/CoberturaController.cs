using Clinica.AppService.Interfaces;
using Clinica.WebApi.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Clinica.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoberturaController : ControllerBase
    {
        private readonly ICoberturaAppService _coberturaAppService;

        public CoberturaController(ICoberturaAppService coberturaAppService)
        {
            _coberturaAppService = coberturaAppService;
        }

        [HttpGet]
        [Route("obter-por-id")]
        public IActionResult ObterPorId(Guid id)
        {
            try
            {
                var result = _coberturaAppService.ObterPorId(id);

                return Ok(new ResponseHelper("", true, result));
            }
            catch (Exception e)
            {
                return Ok(new ResponseHelper(e.Message, false, e));
            }
        }

        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            try
            {
                var result = _coberturaAppService.Listar();

                return Ok(new ResponseHelper("", true, result));
            }
            catch (Exception e)
            {
                return Ok(new ResponseHelper(e.Message, false, e));
            }
        }
    }
}