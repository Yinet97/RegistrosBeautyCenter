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

        public virtual List<Facturas> Facturas { get; set; }

        public Servicios()
        {
            this.Facturas = new List<Facturas>();
        }

        public Servicios(int ServicioId, string TipoServicio)
        {
            this.ServicioId = ServicioId;
            this.TipoServicio = TipoServicio;
            this.Facturas = new List<Facturas>();
        }
    }
}