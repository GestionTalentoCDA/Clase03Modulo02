using Microsoft.EntityFrameworkCore;

namespace Clase03Modulo02SQL
{
    public class BDContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }

        public BDContext( DbContextOptions<BDContext> options ) : base( options )
        {

        }

        protected override void OnModelCreating( ModelBuilder modelBuilder )
        {
            modelBuilder.Entity<Cliente>().Property( prop => prop.NombreCliente ).HasColumnName( "nombre" );
            modelBuilder.Entity<Cliente>().Property( prop => prop.ApellidoCliente ).HasColumnName( "apellido" );
            modelBuilder.Entity<Cliente>().Property( prop => prop.EdadCliente ).HasColumnName( "edad" );


            base.OnModelCreating( modelBuilder );
        }
    }
}
