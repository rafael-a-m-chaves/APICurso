using APICurso.Domain.Entities;
using APICurso.Infra.Mapping;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace APICurso.Infra.Contexts
{
    public class Context : IdentityDbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public Context()
        {
        }

        //Seta as Classes que devem estar no banco de dados e atribui o Get e Set
        public DbSet<LimiteCliente> LimiteCliente { get; set; }
        public DbSet<Log> Log { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Informa ao Context as classes maps 
            modelBuilder.Entity<LimiteCliente>(new LimiteClienteMap().Configure);
            modelBuilder.Entity<Log>(new LogMap().Configure);

            base.OnModelCreating(modelBuilder);
        }
    }
}
