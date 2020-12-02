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
            ListadeProductos = _contexto.Producto.Include("Categoria")
                .ToList();

            return ListadeProductos;
        }

        public void GuardarProducto(Producto producto)
        {
            if(producto.Id == 0)
            {
                _contexto.Producto.Add(producto);
            }
            else
            {
                var productoExistente = _contexto.Producto.Find(producto.Id);
                
                productoExistente.Descripcion = producto.Descripcion;
                productoExistente.CategoriaId = producto.CategoriaId;
                productoExistente.Precio = producto.Precio;
                productoExistente.UrlImagen = producto.UrlImagen;
            }           
            _contexto.SaveChanges();
        } 

        public Producto ObtenerProducto(int id)
        {
            var producto = _contexto.Producto.Include("Categoria").FirstOrDefault(p => p.Id == id);

            return producto;
        }

        public void EliminarProducto(int id)
        {
            var producto = _contexto.Producto.Find(id);

            _contexto.Producto.Remove(producto);
            _contexto.SaveChanges();
        }
    }
}
