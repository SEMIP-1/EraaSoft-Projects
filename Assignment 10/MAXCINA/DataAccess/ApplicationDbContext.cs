using Microsoft.EntityFrameworkCore;
namespace MAXCINA.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Actors> Actors { get; set; }
        public DbSet<ActorMovies> ActorMovies { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Cinemas> Cinemas { get; set; }
        public DbSet<Movies> Movies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MAXCINA; Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
