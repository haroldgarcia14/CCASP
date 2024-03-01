/*****************************************************************
**                 Author: Harold Garcia                        ** 
**      C# - ASP.NET / ADO.NET => .NET FRAMEWORK 4.8            **
*****************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacionAdmin.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        //agregando vista USUARIO
        public ActionResult Usuarios() 
        {
            return View(); //retorna la vida del html creado con la master page de layout.cshtml
        }

        //Devolver la lista Usuarios de la db
        [HttpGet] //es una url que devuelve datos
        public JsonResult ListarUsuarios()
        {
            List<Usuario> oLista = new List<Usuario>();

            oLista = new CN_Usuarios().Listar();

            return Json(oLista,JsonRequestBehavior.AllowGet);

            //return Json(new { elemento = oLista, estado = true }, JsonRequestBehavior.AllowGet);
        }

        /*
         * no se usaran y se borraran el archivo 
         * 
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        */
    }
}