using AgendaSalasApi.Data;
using AgendaSalasApi.Models;
using API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories
{
    public class AgendamentoRepository : IAgendamentoRepository
    {
        private readonly AppDbContext _context;

        public AgendamentoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Agendamento>> GetAllAsync()
        {
            return await _context.Agendamentos
                .Include(a => a.Sala)
                .Include(a => a.Professor)
                .Include(a => a.Disciplina)
                .ToListAsync();
        }

        public async Task<Agendamento?> GetByIdAsync(int id)
        {
            return await _context.Agendamentos
                .Include(a => a.Sala)
                .Include(a => a.Professor)
                .Include(a => a.Disciplina)
                .FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task CreateAsync(Agendamento agendamento)
        {
            await _context.Agendamentos.AddAsync(agendamento);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Agendamento agendamento)
        {
            _context.Agendamentos.Update(agendamento);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Agendamento agendamento)
        {
            _context.Agendamentos.Remove(agendamento);
            await _context.SaveChangesAsync();
        }
    }
}