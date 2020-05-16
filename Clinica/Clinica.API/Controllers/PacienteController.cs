using Clinica.AppService.Interfaces;
using Clinica.AppService.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Clinica.API.Controllers
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

        // POST: api/Paciente
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult> PostPaciente([FromBody] CadastrarPacienteViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return BadRequest("Falha na requisição");

            try
            {
                _pacienteAppService.Inserir(viewModel);
                return Ok("Criado com sucesso");
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        // GET: api/Paciente
        [HttpGet]
        public async Task<ActionResult> GetPacientes()
        {
           return Ok("FUNCIONANDO");
        }
        
        
        
        //public async Task<ActionResult<>> PostPaciente([FromBody] CadastrarPacienteViewModel viewModel)
        //{


        //    return CreatedAtAction("GetPaciente", new { id = paciente.Id }, paciente);
        //}



        //// GET: api/Paciente
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Paciente>>> GetPacientes()
        //{
        //    return await _context.Pacientes.ToListAsync();
        //}

        //// GET: api/Paciente/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Paciente>> GetPaciente(Guid? id)
        //{
        //    var paciente = await _context.Pacientes.FindAsync(id);

        //    if (paciente == null)
        //    {
        //        return NotFound();
        //    }

        //    return paciente;
        //}

        //// PUT: api/Paciente/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutPaciente(Guid? id, Paciente paciente)
        //{
        //    if (id != paciente.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(paciente).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!PacienteExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// DELETE: api/Paciente/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Paciente>> DeletePaciente(Guid? id)
        //{
        //    var paciente = await _context.Pacientes.FindAsync(id);
        //    if (paciente == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Pacientes.Remove(paciente);
        //    await _context.SaveChangesAsync();

        //    return paciente;
        //}

        //private bool PacienteExists(Guid? id)
        //{
        //    return _context.Pacientes.Any(e => e.Id == id);
        //}
    }
}
