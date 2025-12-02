using AgendaSalasApi.Models;
using API.Repositories.Interfaces;
using API.Services.Interfaces;

namespace API.Services
{
    public class SalaService : ISalaService
    {
        private readonly ISalaRepository _repository;

        public SalaService(ISalaRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Sala>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Sala?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Sala> CreateAsync(Sala sala)
        {
            await _repository.CreateAsync(sala);
            return sala;
        }

        public async Task<Sala> UpdateAsync(int id, Sala sala)
        {
            var existing = await _repository.GetByIdAsync(id);

            if (existing == null)
                throw new Exception("Sala não encontrada.");

            existing.NomeSala = sala.NomeSala;

            await _repository.UpdateAsync(existing);

            return existing;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var sala = await _repository.GetByIdAsync(id);

            if (sala == null)
                return false;

            await _repository.DeleteAsync(sala);
            return true;
        }
    }
}