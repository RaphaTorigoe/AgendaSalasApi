using AgendaSalasApi.Models;

namespace API.Repositories.Interfaces
{
    public interface ISalaRepository
    {
        Task<List<Sala>> GetAllAsync();
        Task<Sala?> GetByIdAsync(int id);
        Task CreateAsync(Sala sala);
        Task UpdateAsync(Sala sala);
        Task DeleteAsync(Sala sala);
    }
}