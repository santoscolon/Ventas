using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.BL
{
    public class Contexto: DbContext
    {
        public Contexto(): base(@"Data Source=(LocalDb)\MSSQLLocalDB;AttachDBFilename=" + 
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\VentasDB.mdf")
        {
                
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Producto> Producto { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
