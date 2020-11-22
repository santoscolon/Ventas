using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.BL
{
    public class productosBL
    {
       public List<Producto> ObtenerProductos()
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Camisas Tie Dye";

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Vestidos";

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Tops";

            var producto4 = new Producto();
            producto4.Id = 4;
            producto4.Descripcion = "Bodys";

            var producto5 = new Producto();
            producto5.Id = 5;
            producto5.Descripcion = "Crocs";

            var producto6 = new Producto();
            producto6.Id = 6;
            producto6.Descripcion = "Piercings";

            var producto7 = new Producto();
            producto7.Id = 7;
            producto7.Descripcion = "Cosmetiqueras";

            var producto8 = new Producto();
            producto8.Id = 8;
            producto8.Descripcion = "Brochas";

            var producto9 = new Producto();
            producto9.Id = 9;
            producto9.Descripcion = "Panties";

            var producto10 = new Producto();
            producto10.Id = 10;
            producto10.Descripcion = "Brasieres";

            var producto11 = new Producto();
            producto11.Id = 11;
            producto11.Descripcion = "Diademas";

            var producto12 = new Producto();
            producto12.Id = 12;
            producto12.Descripcion = "Colas";

            var producto13 = new Producto();
            producto13.Id = 13;
            producto13.Descripcion = "Fajas";

            var producto14 = new Producto();
            producto14.Id = 14;
            producto14.Descripcion = "Bolsos Pequeños";

            var listadeProductos = new List<Producto>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);
            listadeProductos.Add(producto4);
            listadeProductos.Add(producto5);
            listadeProductos.Add(producto6);
            listadeProductos.Add(producto7);
            listadeProductos.Add(producto8);
            listadeProductos.Add(producto9);
            listadeProductos.Add(producto10);
            listadeProductos.Add(producto11);
            listadeProductos.Add(producto12);
            listadeProductos.Add(producto13);
            listadeProductos.Add(producto14);

            return listadeProductos;
        }
    }
}
