using AgendaSalasApi.Models;
using API.Repositories.Interfaces;
using API.Services.Interfaces;

namespace API.Services
{
    public class DisciplinaService : IDisciplinaService
    {
        private readonly IDisciplinaRepository _repository;

        public DisciplinaService(IDisciplinaRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Disciplina>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Disciplina?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Disciplina> CreateAsync(Disciplina disciplina)
        {
            await _repository.CreateAsync(disciplina);
            return disciplina;
        }

        public async Task<Disciplina> UpdateAsync(int id, Disciplina disciplina)
        {
            var existing = await _repository.GetByIdAsync(id);

            if (existing == null)
                throw new Exception("Disciplina não encontrada.");

            existing.Nome = disciplina.Nome;

            await _repository.UpdateAsync(existing);

            return existing;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var disciplina = await _repository.GetByIdAsync(id);

            if (disciplina == null)
                return false;

            await _repository.DeleteAsync(disciplina);
            return true;
        }
    }
}