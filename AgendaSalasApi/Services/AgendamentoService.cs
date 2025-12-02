using AgendaSalasApi.Models;
using AgendaSalasApi.Repositories.Interfaces;
using API.Repositories.Interfaces;
using API.Services.Interfaces;

namespace API.Services
{
    public class AgendamentoService : IAgendamentoService
    {
        private readonly IAgendamentoRepository _repository;
        private readonly ISalaRepository _salaRepository;
        private readonly IProfessorRepository _profRepository;
        private readonly IDisciplinaRepository _discRepository;

        public AgendamentoService(
            IAgendamentoRepository repository,
            ISalaRepository salaRepository,
            IProfessorRepository professorRepository,
            IDisciplinaRepository disciplinaRepository)
        {
            _repository = repository;
            _salaRepository = salaRepository;
            _profRepository = professorRepository;
            _discRepository = disciplinaRepository;
        }

        public async Task<List<Agendamento>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Agendamento?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Agendamento> CreateAsync(Agendamento agendamento)
        {
            if (await _salaRepository.GetByIdAsync(agendamento.SalaId) == null)
                throw new Exception("Sala inválida.");

            if (await _profRepository.GetByIdAsync(agendamento.ProfessorId) == null)
                throw new Exception("Professor inválido.");

            if (await _discRepository.GetByIdAsync(agendamento.DisciplinaId) == null)
                throw new Exception("Disciplina inválida.");

            var agendamentos = await _repository.GetAllAsync();

            bool conflito = agendamentos.Any(a =>
                a.SalaId == agendamento.SalaId &&
                a.DataHora == agendamento.DataHora);

            if (conflito)
                throw new Exception("Já existe um agendamento para essa sala neste horário.");

            await _repository.CreateAsync(agendamento);
            return agendamento;
        }

        public async Task<Agendamento> UpdateAsync(int id, Agendamento agendamento)
        {
            var existing = await _repository.GetByIdAsync(id);

            if (existing == null)
                throw new Exception("Agendamento não encontrado.");

            existing.SalaId = agendamento.SalaId;
            existing.ProfessorId = agendamento.ProfessorId;
            existing.DisciplinaId = agendamento.DisciplinaId;
            existing.DataHora = agendamento.DataHora;

            await _repository.UpdateAsync(existing);

            return existing;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var agendamento = await _repository.GetByIdAsync(id);

            if (agendamento == null)
                return false;

            await _repository.DeleteAsync(agendamento);
            return true;
        }
    }
}