using AgendaSalasApi.Models;

namespace API.Services.Interfaces
{
    public interface ISalaService
    {
        Task<List<Sala>> GetAllAsync();
        Task<Sala?> GetByIdAsync(int id);
        Task<Sala> CreateAsync(Sala sala);
        Task<Sala> UpdateAsync(int id, Sala sala);
        Task<bool> DeleteAsync(int id);
    }
}