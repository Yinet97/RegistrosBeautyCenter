using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistrosBeautyCenter.Models
{
    public class Facturas
    {
        [Key]

        public int FacturaId { get; set; }
        public string NombreCliente { get; set; }
        public int MontoAdicional { get; set; }
        public int Descuento { get; set; }
        public Double DescuentoPorciento { get; set; }
        public string Comentario { get; set; }
        public int Impuesto { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoPago { get; set; }
        public int ServicioId { get; set; }
        public Double Total { get; set; }
        public Double SubTotal { get; set; }


        public virtual List<Servicios> Service { get; set; }

        public Facturas()
        {
            this.Service = new List<Servicios>();
        }
    }
}