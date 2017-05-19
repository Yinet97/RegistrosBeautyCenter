using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistrosBeautyCenter.Models
{
    public class Provincias
    {
        [Key]

        public int ProvinciaID { get; set; }
        public string Nombre { get; set; }
    }
}