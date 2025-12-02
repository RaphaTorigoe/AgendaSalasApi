using AgendaSalasApi.Models;

namespace API.Services.Interfaces
{
    public interface IAgendamentoService
    {
        Task<List<Agendamento>> GetAllAsync();
        Task<Agendamento?> GetByIdAsync(int id);
        Task<Agendamento> CreateAsync(Agendamento agendamento);
        Task<Agendamento> UpdateAsync(int id, Agendamento agendamento);
        Task<bool> DeleteAsync(int id);
    }
}