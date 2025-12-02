using AgendaSalasApi.Models;

namespace AgendaSalasApi.Repositories.Interfaces
{
    public interface IProfessorRepository
    {
        Task<List<Professor>> GetAllAsync();
        Task<Professor?> GetByIdAsync(int id);
        Task<Professor> CreateAsync(Professor professor);
        Task<Professor> UpdateAsync(Professor professor);
        Task<bool> DeleteAsync(int id);
    }
}