using System;
using Clinica.AppService.Interfaces;
using Clinica.WebApi.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Clinica.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HorarioController : ControllerBase
    {
        private readonly IHorarioAppService _horarioAppService;

        public HorarioController(IHorarioAppService horarioAppService)
        {
            _horarioAppService = horarioAppService;
        }

        [HttpGet]
        [Route("listar-horarios")]
        public IActionResult ListarHorarios()
        {
            try
            {
                var result = _horarioAppService.ListarHorarios();

                return Ok(new ResponseHelper("", true, result));
            }
            catch (Exception e)
            {
                return Ok(new ResponseHelper(e.Message, false, e.InnerException.Message));
            }
        }
    }
}