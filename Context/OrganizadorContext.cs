using Microsoft.EntityFrameworkCore;
using TrilhaApiDesafio.Models;

namespace TrilhaApiDesafio.Context
{
    public class OrganizadorContext(DbContextOptions<OrganizadorContext> options) : DbContext(options)
    {
		public DbSet<Tarefa> Tarefas { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            modelBuilder.Entity<Tarefa>().HasData(
                new Tarefa()
                {
                    Id = 1,
                    Titulo = "Desafio DIO",
                    Descricao = "Criar desafio de API (MVC) da DIO",
                    Data = DateTime.Now,
                    Status = EnumStatusTarefa.Pendente
                }
            );
		}
    }
}