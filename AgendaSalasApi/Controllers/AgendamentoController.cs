using AgendaSalasApi.DTOs;
using AgendaSalasApi.Data;
using AgendaSalasApi.Models;
using API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgendamentoController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IAgendamentoService _service;

        public AgendamentoController(AppDbContext context, IAgendamentoService service)
        {
            _context = context;
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var agendamento = await _service.GetByIdAsync(id);
            return agendamento == null ? NotFound() : Ok(agendamento);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]AgendamentoDTO dto)
        {
            try
            {
                var agendamento = new Agendamento
                {
                    ProfessorId = dto.ProfessorId,
                    SalaId = dto.SalaId,
                    DisciplinaId = dto.DisciplinaId,
                    DataHora = dto.DataHora
                };

                _context.Agendamentos.Add(agendamento);
                await _context.SaveChangesAsync();

                return Ok(agendamento);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Agendamento agendamento)
        {
            try
            {
                var updated = await _service.UpdateAsync(id, agendamento);
                return Ok(updated);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            bool deleted = await _service.DeleteAsync(id);
            return deleted ? NoContent() : NotFound();
        }
    }
}