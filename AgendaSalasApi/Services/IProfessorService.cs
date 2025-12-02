using AgendaSalasApi.Models;

namespace API.Services.Interfaces
{
    public interface IProfessorService
    {
        Task<List<Professor>> GetAllAsync();
        Task<Professor?> GetByIdAsync(int id);
        Task<Professor> CreateAsync(Professor professor);
        Task<Professor> UpdateAsync(int id, Professor professor);
        Task<bool> DeleteAsync(int id);
    }
}