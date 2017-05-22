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
        RegistrosBeautyCenter.DAL.BeautyCenterDb db = new RegistrosBeautyCenter.DAL.BeautyCenterDb();
        public JsonResult ProvinciaList()
        {return Json(((from p in db.provincia select new { ProvinciaId = p.ProvinciaId, NombreProvincia = p.NombreProvincia })), JsonRequestBehavior.AllowGet);}
        public JsonResult CiudadesList(int ProvinciaId)
        {var books = (from a in db.ciudade where (a.ProvinciaId == ProvinciaId) select new { CiudadId = a.CiudadesId, NombreCiudad = a.NombreCiudad });
            return Json(books, JsonRequestBehavior.AllowGet);}


        //public ActionResult ProvinciaList()
        //{
        //    IQueryable provincias = Provincias.GetProvincias();

        //    if (HttpContext.Request.IsAjaxRequest())
        //    {
        //        return Json(new SelectList(
        //            provincias,
        //            "ProvinciaId",
        //            "NombreProvincia"), JsonRequestBehavior.AllowGet
        //            );
        //    }
        //    return View(provincias);
        //}
        //public ActionResult CiudadList(string provinciaId)
        //{
        //    IQueryable ciudades = Ciudades.GetCiudades().Where(x => x.ProvinciaId == provinciaId);
        //    if (HttpContext.Request.IsAjaxRequest())
        //    {
        //        return Json(new SelectList(
        //            ciudades,
        //            "CiudadesId",
        //            "NombreCiudad"), JsonRequestBehavior.AllowGet
        //            );
        //    }
        //    return View(ciudades);
        //}
        List<Servicios> lista = new List<Servicios>(); List<Clientes> listaC = new List<Clientes>();
        public ActionResult Index()
        {
            //ViewBag.TotalService = lista.Count();
            //ViewBag.Clientes = listaC.Count();
            return View();
        }
    }
}
