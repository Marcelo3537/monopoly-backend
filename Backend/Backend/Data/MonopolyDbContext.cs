using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data
{
    public class MonopolyDbContext : DbContext
    {
        public MonopolyDbContext(DbContextOptions<MonopolyDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Partida> Partidas { get; set; }
        public DbSet<UsuarioPartida> UsuarioPartidas { get; set; }

        public DbSet<Tarjeta> Tarjetas { get; set; }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Inventario> Inventarios { get; set; }

        public DbSet<Logro> Logros { get; set; }
        public DbSet<UsuarioLogro> UsuarioLogros { get; set; }

        public DbSet<Recompensa> Recompensas { get; set; }
        public DbSet<HistorialRecompensa> HistorialRecompensas { get; set; }

        public DbSet<Casilla> Casillas { get; set; }
        public DbSet<Posesion> Posesiones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Usuario
            modelBuilder.Entity<Usuario>()
                .HasIndex(u => u.UsuarioNombre)
                .IsUnique();

            modelBuilder.Entity<Usuario>()
                .HasIndex(u => u.Correo)
                .IsUnique();

            // UsuarioPartida (N:M)
            modelBuilder.Entity<UsuarioPartida>()
                .HasOne(up => up.Usuario)
                .WithMany(u => u.UsuarioPartidas)
                .HasForeignKey(up => up.IdUsuario);

            modelBuilder.Entity<UsuarioPartida>()
                .HasOne(up => up.Partida)
                .WithMany(p => p.UsuarioPartidas)
                .HasForeignKey(up => up.IdPartida);

            // Inventario
            modelBuilder.Entity<Inventario>()
                .HasOne(i => i.Usuario)
                .WithMany(u => u.Inventario)
                .HasForeignKey(i => i.IdUsuario);

            modelBuilder.Entity<Inventario>()
                .HasOne(i => i.Producto)
                .WithMany(p => p.Inventarios)
                .HasForeignKey(i => i.IdProducto);

            // UsuarioLogro
            modelBuilder.Entity<UsuarioLogro>()
                .HasOne(ul => ul.Usuario)
                .WithMany(u => u.UsuarioLogros)
                .HasForeignKey(ul => ul.IdUsuario);

            modelBuilder.Entity<UsuarioLogro>()
                .HasOne(ul => ul.Logro)
                .WithMany(l => l.UsuarioLogros)
                .HasForeignKey(ul => ul.IdLogro);

            // HistorialRecompensa
            modelBuilder.Entity<HistorialRecompensa>()
                .HasOne(h => h.Usuario)
                .WithMany(u => u.HistorialRecompensas)
                .HasForeignKey(h => h.IdUsuario);

            modelBuilder.Entity<HistorialRecompensa>()
                .HasOne(h => h.Recompensa)
                .WithMany(r => r.Historiales)
                .HasForeignKey(h => h.IdRecompensa);
        }
    }
}
