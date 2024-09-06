using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace BibliotecaAppDocker.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // DbSets para cada una de las entidades
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Libro> Libros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración de las relaciones entre las entidades

            modelBuilder.Entity<Libro>()
                .HasOne(l => l.Autor)
                .WithMany(a => a.Libros)
                .HasForeignKey(l => l.AutorID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Libro>()
                .HasOne(l => l.Categoria)
                .WithMany(c => c.Libros)
                .HasForeignKey(l => l.CategoriaID)
                .OnDelete(DeleteBehavior.Cascade);

            // Configuración adicional (opcional)
            modelBuilder.Entity<Autor>()
                .Property(a => a.Nombre)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<Autor>()
                .Property(a => a.Apellido)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<Categoria>()
                .Property(c => c.Nombre)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<Libro>()
                .Property(l => l.Titulo)
                .HasMaxLength(200)
                .IsRequired();

            modelBuilder.Entity<Libro>()
                .Property(l => l.FechaPublicacion)
                .IsRequired();
        }
    }
}
