using AgendaSalasApi.Data;
using AgendaSalasApi.Models;
using API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories
{
    public class DisciplinaRepository : IDisciplinaRepository
    {
        private readonly AppDbContext _context;

        public DisciplinaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Disciplina>> GetAllAsync()
        {
            return await _context.Disciplinas.ToListAsync();
        }

        public async Task<Disciplina?> GetByIdAsync(int id)
        {
            return await _context.Disciplinas.FindAsync(id);
        }

        public async Task CreateAsync(Disciplina disciplina)
        {
            await _context.Disciplinas.AddAsync(disciplina);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Disciplina disciplina)
        {
            _context.Disciplinas.Update(disciplina);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Disciplina disciplina)
        {
            _context.Disciplinas.Remove(disciplina);
            await _context.SaveChangesAsync();
        }
    }
}