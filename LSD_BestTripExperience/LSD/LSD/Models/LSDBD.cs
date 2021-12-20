using Microsoft.EntityFrameworkCore;

namespace LSD.Models
{
    public class LSDBD : DbContext
    {
        public DbSet<Destino> Destinos { get; set; }
        public DbSet<Promocao> Promocoes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=LSDdb;Integrated Security=True");
        }


    }
}
