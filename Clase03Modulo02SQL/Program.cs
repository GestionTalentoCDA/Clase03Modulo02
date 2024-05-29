using Microsoft.EntityFrameworkCore;

namespace Clase03Modulo02SQL
{
    internal class Program
    {
        static void Main( string[] args )
        {
            var options = new DbContextOptionsBuilder<BDContext>();
            options.UseSqlServer( "Data Source=LAPTOP-728EDF47;Initial Catalog=Clase3Modulo2;Integrated Security=True" );

            var context = new BDContext( options.Options );

            //Cliente nuevoCliente = new Cliente() { ApellidoCliente = "Ramirez", NombreCliente = "Hernan", EdadCliente = 50 };
            //Cliente nuevoCliente2 = new Cliente() { ApellidoCliente = "Elprimo", NombreCliente = "Hernan", EdadCliente = 63 };

            //context.Cliente.Add( nuevoCliente );
            //context.Cliente.Add( nuevoCliente2 );

            //context.SaveChanges();

            //TODOS los datos de la tabla Cliente
            var result = context.Cliente.ToList().FirstOrDefault();
            var result2 = context.Cliente.Skip( 1 ).ToList();
            var result3 = context.Cliente.Take( 2 ).ToList();

            //Todos cuyo nombre = hernan

            var resultHernan = context.Cliente.Where( cliente => cliente.NombreCliente == "Hernan" ).Select( p => p.ApellidoCliente ).ToList();

            //Apellido y ID cuyo nombre = hernan
            var result4 = context.Cliente.Where( cliente => cliente.NombreCliente == "Hernan" ).Select( x => new { x.ApellidoCliente, x.Id } ).ToList();

            var totalMenor3 = context.Cliente.Where( cliente => cliente.Id < 3 ).Count();




        }
    }
}