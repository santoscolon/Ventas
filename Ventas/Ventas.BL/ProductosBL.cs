using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.BL
{
    public class productosBL
    {
        Contexto _contexto;
        public List<Producto> ListadeProductos { get; set; }

        public productosBL()
        {
            _contexto = new Contexto();
            ListadeProductos = new List<Producto>();
        }

       public List<Producto> ObtenerProductos()
        {
            ListadeProductos = _contexto.Producto.ToList();
            return ListadeProductos;
        }
    }
}
