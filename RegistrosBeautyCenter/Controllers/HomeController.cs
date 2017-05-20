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
        List<Servicios> lista = new List<Servicios>();
        List<Clientes> listaC = new List<Clientes>();
        // GET: Citas
        public ActionResult Index()
        {
            ViewBag.TotalService = lista.Count();
            ViewBag.Clientes = listaC.Count();
            return View();
        }
    }
}
