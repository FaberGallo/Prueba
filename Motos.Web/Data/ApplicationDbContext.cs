using Microsoft.EntityFrameworkCore;
using Motos.Web.Models;

namespace Motos.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Registry> Registries { get; set; }

        public DbSet<Service> Service { get; set; }
        public DbSet<ServiceImage> ServiceImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>()

                .HasIndex(t => t.Name)
                .IsUnique();

            modelBuilder.Entity<Role>()
                .HasIndex(t => t.Name)
                .IsUnique();

            modelBuilder.Entity<User>()
                .HasIndex(t => t.Name)
                .IsUnique();

            modelBuilder.Entity<Registry>()
                .HasIndex(t => t.Placa)
                .IsUnique();

            modelBuilder.Entity<Service>()
          .HasIndex(t => t.Name)
          .IsUnique();
        }

        public DbSet<Motos.Web.Models.Category> Category { get; set; }

    }
}

