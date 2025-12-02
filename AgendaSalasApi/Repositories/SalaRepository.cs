using AgendaSalasApi.Data;
using AgendaSalasApi.Models;
using API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories
{
    public class SalaRepository : ISalaRepository
    {
        private readonly AppDbContext _context;

        public SalaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Sala>> GetAllAsync()
        {
            return await _context.Salas.ToListAsync();
        }

        public async Task<Sala?> GetByIdAsync(int id)
        {
            return await _context.Salas.FindAsync(id);
        }

        public async Task CreateAsync(Sala sala)
        {
            await _context.Salas.AddAsync(sala);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Sala sala)
        {
            _context.Salas.Update(sala);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Sala sala)
        {
            _context.Salas.Remove(sala);
            await _context.SaveChangesAsync();
        }
    }
}