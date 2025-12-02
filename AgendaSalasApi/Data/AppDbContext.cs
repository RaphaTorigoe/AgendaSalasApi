using Microsoft.EntityFrameworkCore;
using AgendaSalasApi.Models;

namespace AgendaSalasApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Professor> Professores { get; set; }
        public DbSet<Sala> Salas { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }
    }
}