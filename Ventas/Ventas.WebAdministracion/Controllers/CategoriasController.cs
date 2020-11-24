﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ventas.BL;

namespace Ventas.WebAdministracion.Controllers
{
    public class CategoriasController : Controller
    {
        CategoriasBL _categoriasBL;

        public CategoriasController()
        {
            _categoriasBL = new CategoriasBL();
        }

        // GET: Categorias
        public ActionResult Index()
        {
            var listadeCategorias = _categoriasBL.ObtenerCategorias();

            return View(listadeCategorias);
        }

        public ActionResult Crear()
        {
            var nuevaCategoria = new Categoria();

            return View(nuevaCategoria);
        }

        [HttpPost]
        public ActionResult Crear(Categoria producto)
        {
            _categoriasBL.GuardarCategoria(producto);

            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {
            var producto = _categoriasBL.ObtenerCategoria(id);

            return View(producto);
        }
    }
}