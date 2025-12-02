namespace AgendaSalasApi.Models
{
    public class Agendamento
    {
        public int Id { get; set; }
        public DateTime DataHora { get; set; }

        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }

        public int SalaId { get; set; }
        public Sala Sala { get; set; }

        public int DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}