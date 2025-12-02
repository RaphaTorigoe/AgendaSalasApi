namespace AgendaSalasApi.DTOs
{
    public class AgendamentoDTO
    {
        public DateTime DataHora { get; set; }
        public int ProfessorId { get; set; }
        public int SalaId { get; set; }
        public int DisciplinaId { get; set; }
    }
}