using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinica.AppService.Interfaces;
using Clinica.AppService.ViewModels.Horario_Atendimento;
using Clinica.Domain.Enums;
using Clinica.WebApi.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clinica.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HorarioAtendimentoController : ControllerBase
    {
        private readonly IHorarioAtendimentoAppService _horarioAtendimentoAppService;

        public HorarioAtendimentoController(IHorarioAtendimentoAppService horarioAtendimentoAppService)
        {
            _horarioAtendimentoAppService = horarioAtendimentoAppService;
        }

        [HttpGet]
        [Route("obter-data-disponivel")]
        public IActionResult ObterDataDisponivel(EnumDia dia, Guid idEspecialidade)
        {
            try
            {
                var result = _horarioAtendimentoAppService.ObterHorarioAtendimentoDoDia(dia, idEspecialidade);

                return Ok(new ResponseHelper("", true, result));
            }
            catch (Exception e)
            {
                return Ok(new ResponseHelper(e.Message, false, e));
            }
        }

        [HttpGet]
        [Route("listar")]
        public IActionResult ListarHorariosAtendimento(EnumDia dia, Guid idEspecialidade)
        {
            try
            {
                var result = _horarioAtendimentoAppService.ListarHorariosAtendimentos();

                return Ok(new ResponseHelper("", true, result));
            }
            catch (Exception e)
            {
                return Ok(new ResponseHelper(e.Message, false, e));
            }
        }

        [HttpPost]
        [Route("inserir-horario-atendimento")]
        public IActionResult InserirHorarioAtendimento([FromBody]CadastrarHorarioAtendimentoViewModel viewModel)
        {
            try
            {
                _horarioAtendimentoAppService.CadastrarHorarioAtendimento(viewModel);

                return Ok(new ResponseHelper("", true, null));
            }
            catch (Exception e)
            {
                return Ok(new ResponseHelper(e.Message, false, e));
            }
        }
    }
}