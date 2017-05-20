using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistrosBeautyCenter.Models
{
    public class Servicios
    {
        [Key]

        public int ServicioId { get; set; }
        [Display(Name = "TipoServicio"), Required(ErrorMessage = "No puede quedarse vacio")]
        public string TipoServicio { get; set; }
        public int Costo { get; set; }
        
    }
}