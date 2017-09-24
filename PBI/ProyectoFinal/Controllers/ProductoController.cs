using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFinal.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult ListadoProductos()
        {
            return View();
        }

        public ActionResult EditarProductos()
        {
            return View();
        }

        public ActionResult BorrarProductos()
        {
            return View();
        }

    }
}