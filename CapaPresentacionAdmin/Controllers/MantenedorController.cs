/*****************************************************************
**                 Author: Harold Garcia                        ** 
**      C# - ASP.NET / ADO.NET => .NET FRAMEWORK 4.8            **
*****************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaPresentacionAdmin.Controllers
{
    public class MantenedorController : Controller
    {
        // GET: Mantenedor

        //controlador para las vistas Categoria, Marca, Producto
        public ActionResult Categoria()
        {
            return View(); 
        }

        public ActionResult Marca() 
        {
            return View(); 
        }

        public ActionResult Producto()
        {
            return View();
        }
    }
}