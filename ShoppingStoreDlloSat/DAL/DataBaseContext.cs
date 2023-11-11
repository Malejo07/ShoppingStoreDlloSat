using Microsoft.EntityFrameworkCore;
using ShoppingStoreDlloSat.DAL.Entities;

namespace ShoppingStoreDlloSat.DAL
{
    public class DataBaseContext : DbContext
    {
        //En este constructor, creo la refrencia de DbContextOptions que me sirve para configurar las opciones de la BD, como por ejemplo usar SQL Server y usar la cadena de conexión a la BD
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }

        //DbSet me sirve para convertir mi clase Country en una tabla de BD. El nombre de la tabla será "Countries"
        public DbSet<Country> Countries { get; set; }
       
    }
}
