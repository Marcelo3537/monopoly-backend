namespace Backend
{
    public class MonopolyDbContext : IdentityDbContext<IdentityUser> // Hereda de Identity para gestionar usuarios
    {
        // Conjuntos de tablas (DbSets)
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<EstadisticasUsuario> EstadisticasUsuarios { get; set; }
        // ... más DbSets para Partida, Item, etc.

        // Constructor para la configuración
        public MonopolyDbContext(DbContextOptions<MonopolyDbContext> options) : base(options) { }

        // Este método se usa para configurar las relaciones complejas
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configura la relación 1:1 entre Usuario y EstadisticasUsuario
            modelBuilder.Entity<EstadisticasUsuario>()
                .HasOne(e => e.Usuario)
                .WithOne(u => u.Estadisticas)
                .HasForeignKey<EstadisticasUsuario>(e => e.Id);
        }
    }
}