using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ventas.BL;

namespace Ventas.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var productoBL = new productosBL();
            var listadeProductos = productoBL.ObtenerProductos();

            return View(listadeProductos);
        }
    }
}