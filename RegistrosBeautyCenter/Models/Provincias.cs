using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistrosBeautyCenter.Models
{
    public class Provincias
    {
        public IList<SelectListItem> StateNames { get; set; }
        public IList<SelectListItem> DistrictNames { get; set; }

        [Key]
        public int ProvinciaID { get; set; }
        public string Nombre { get; set; }
    }
}