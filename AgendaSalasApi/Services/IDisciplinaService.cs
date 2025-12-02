using AgendaSalasApi.Models;

namespace API.Services.Interfaces
{
    public interface IDisciplinaService
    {
        Task<List<Disciplina>> GetAllAsync();
        Task<Disciplina?> GetByIdAsync(int id);
        Task<Disciplina> CreateAsync(Disciplina disciplina);
        Task<Disciplina> UpdateAsync(int id, Disciplina disciplina);
        Task<bool> DeleteAsync(int id);
    }
}