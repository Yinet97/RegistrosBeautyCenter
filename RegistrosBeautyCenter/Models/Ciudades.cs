using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistrosBeautyCenter.Models
{
    public class Ciudades
    {
        [Key]
        public int ProvinciaId { get; set; }
        public int CiudadesId { get; set; }
        public string NombreCiudad { get; set; }
        
        //public static IQueryable<Ciudades> GetCiudades()
        //{
        //    return new List<Ciudades>
        //    {
        //        new Ciudades {ProvinciaId  = "DU",CiudadesId = 1,NombreCiudad = "San Francisco De Macoris"},
        //        new Ciudades {ProvinciaId  = "DU",CiudadesId = 2,NombreCiudad = "Arenoso"},
        //        new Ciudades {ProvinciaId  = "SA",CiudadesId = 3,NombreCiudad = "otra mas"},
        //        new Ciudades {ProvinciaId  = "SA",CiudadesId = 4,NombreCiudad = "Santiago de los caballeros"}
        //    }.AsQueryable();
        //}
    }
}