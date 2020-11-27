﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ventas.BL;

namespace Ventas.WebAdministracion.Controllers
{
    public class ProductosController : Controller
    {
        productosBL _productosBL;
        CategoriasBL _categoriasBL;

        public ProductosController()
        {
            _productosBL = new productosBL();
            _categoriasBL = new CategoriasBL();
        }

        // GET: Productos
        public ActionResult Index()
        {
            var listadeProductos = _productosBL.ObtenerProductos();

            return View(listadeProductos);
        }

        public ActionResult Crear()
        {
            var nuevoProducto = new Producto();
            var categorias = _categoriasBL.ObtenerCategorias();

            ViewBag.ListadeCategorias = new SelectList(categorias, "Id", "Descripcion");

            return View(nuevoProducto);
        }

        [HttpPost]
        public ActionResult Crear(Producto producto)
        {
            _productosBL.GuardarProducto(producto);

            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {
            var producto = _productosBL.ObtenerProducto(id);
            var categorias = _categoriasBL.ObtenerCategorias();

            ViewBag.CategoriaId = new SelectList(categorias, "Id", "Descripcion", producto.CategoriaId);

            return View(producto);
        }

        [HttpPost]
        public ActionResult Editar(Producto producto)
        {
            _productosBL.GuardarProducto(producto);

            return RedirectToAction("Index");
        }

        public ActionResult Detalle(int id)
        {
            var producto = _productosBL.ObtenerProducto(id);

            return View(producto);
        }

        public ActionResult Eliminar(int id)
        {
            var producto = _productosBL.ObtenerProducto(id);
            var categorias = _categoriasBL.ObtenerCategorias();

            return View(producto);
        }

        [HttpPost]
        public ActionResult Eliminar(Producto producto)
        {
            _productosBL.EliminarProducto(producto.Id);

            return RedirectToAction("Index");
        }
    }
}