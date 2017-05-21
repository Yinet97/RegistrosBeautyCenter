using RegistrosBeautyCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistrosBeautyCenter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult ProvinciaList()
        {
            IQueryable provincias = Provincias.GetProvincias();

            if (HttpContext.Request.IsAjaxRequest())
            {
                return Json(new SelectList(
                    provincias,
                    "ProvinciaId",
                    "NombreProvincia"), JsonRequestBehavior.AllowGet
                    );
            }
            return View(provincias);
        }
        public ActionResult CiudadList(int provinciaId)
        {
            IQueryable ciudades = Ciudades.GetCiudades().Where(x => x.ProvinciaId == provinciaId);
            if (HttpContext.Request.IsAjaxRequest())
            {
                return Json(new SelectList(
                    ciudades,
                    "CiudadesId",
                    "NombreCiudad"), JsonRequestBehavior.AllowGet
                    );
            }
            return View(ciudades);
        }
        List<Servicios> lista = new List<Servicios>(); List<Clientes> listaC = new List<Clientes>();
        public ActionResult Index()
        {
            //ViewBag.TotalService = lista.Count();
            //ViewBag.Clientes = listaC.Count();
            return View();
        }
    }
}
