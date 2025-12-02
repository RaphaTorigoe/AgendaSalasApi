using AgendaSalasApi.Data;
using AgendaSalasApi.Models;
using AgendaSalasApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AgendaSalasApi.Repositories
{
    public class ProfessorRepository : IProfessorRepository
    {
        private readonly AppDbContext _context;

        public ProfessorRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Professor>> GetAllAsync()
        {
            return await _context.Professores.ToListAsync();
        }

        public async Task<Professor?> GetByIdAsync(int id)
        {
            return await _context.Professores.FindAsync(id);
        }

        public async Task<Professor> CreateAsync(Professor professor)
        {
            _context.Professores.Add(professor);
            await _context.SaveChangesAsync();
            return professor;
        }

        public async Task<Professor> UpdateAsync(Professor professor)
        {
            _context.Professores.Update(professor);
            await _context.SaveChangesAsync();
            return professor;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var existing = await _context.Professores.FindAsync(id);

            if (existing == null)
                return false;

            _context.Professores.Remove(existing);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}