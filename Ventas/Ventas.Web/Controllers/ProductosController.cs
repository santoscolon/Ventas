using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ventas.Web.Models;

namespace Ventas.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var producto1 = new ProductoModel();
            producto1.Id = 1;
            producto1.Descripcion = "Camisas Tie Dye";

            var producto2 = new ProductoModel();
            producto2.Id = 2;
            producto2.Descripcion = "Vestidos";

            var producto3 = new ProductoModel();
            producto3.Id = 3;
            producto3.Descripcion = "Top";

            var producto4 = new ProductoModel();
            producto4.Id = 4;
            producto4.Descripcion = "Body";

            var producto5 = new ProductoModel();
            producto5.Id = 5;
            producto5.Descripcion = "Crocs";

            var producto6 = new ProductoModel();
            producto6.Id = 6;
            producto6.Descripcion = "Piercing";

            var producto7 = new ProductoModel();
            producto7.Id = 7;
            producto7.Descripcion = "Cosmetiqueras";

            var producto8 = new ProductoModel();
            producto8.Id = 8;
            producto8.Descripcion = "Brochas";

            var producto9 = new ProductoModel();
            producto9.Id = 9;
            producto9.Descripcion = "Panties";

            var producto10 = new ProductoModel();
            producto10.Id = 10;
            producto10.Descripcion = "Brasieres";

            var producto11 = new ProductoModel();
            producto11.Id = 11;
            producto11.Descripcion = "Diademas";

            var producto12 = new ProductoModel();
            producto12.Id = 12;
            producto12.Descripcion = "Colas";

            var producto13 = new ProductoModel();
            producto13.Id = 13;
            producto13.Descripcion = "Fajas";

            var producto14 = new ProductoModel();
            producto14.Id = 14;
            producto14.Descripcion = "Bolsos Pequeños";

            var listadeProductos = new List<ProductoModel>();
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

            return View(listadeProductos);
        }
    }
}