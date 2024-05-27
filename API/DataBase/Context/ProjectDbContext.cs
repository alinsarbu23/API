using DataBase.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Context
{
    public class ProjectDbContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Owner> Owners { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>()
                .HasOne(a => a.Owner)
                .WithMany(o => o.Animals)
                .HasForeignKey(a => a.OwnerId);
        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=market;Username=postgres;Password=1q2w3e");
        }
    }
}
