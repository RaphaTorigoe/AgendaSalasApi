using AgendaSalasApi.Models;

namespace API.Repositories.Interfaces
{
    public interface IDisciplinaRepository
    {
        Task<List<Disciplina>> GetAllAsync();
        Task<Disciplina?> GetByIdAsync(int id);
        Task CreateAsync(Disciplina disciplina);
        Task UpdateAsync(Disciplina disciplina);
        Task DeleteAsync(Disciplina disciplina);
    }
}