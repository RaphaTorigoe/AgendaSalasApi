using AgendaSalasApi.Models;
using AgendaSalasApi.Repositories.Interfaces;
using API.Services.Interfaces;

namespace API.Services
{
    public class ProfessorService : IProfessorService
    {
        private readonly IProfessorRepository _repository;

        public ProfessorService(IProfessorRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Professor>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Professor?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Professor> CreateAsync(Professor professor)
        {
            await _repository.CreateAsync(professor);
            return professor;
        }

        public async Task<Professor> UpdateAsync(int id, Professor professor)
        {
            var existing = await _repository.GetByIdAsync(id);

            if (existing == null)
                throw new Exception("Professor não encontrado.");

            existing.Nome = professor.Nome;
            existing.Email = professor.Email;

            await _repository.UpdateAsync(existing);
            return existing;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var professor = await _repository.GetByIdAsync(id);

            if (professor == null)
                return false;

            await _repository.DeleteAsync(id);
            return true;
        }
    }
}