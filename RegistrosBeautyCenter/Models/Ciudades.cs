using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrosBeautyCenter.Models
{
    public class Ciudades
    {
        public int ProvinciaId { get; set; }
        public int CiudadesId { get; set; }
        public string NombreCiudad { get; set; }

        public static IQueryable<Ciudades> GetCiudades()
        {
            return new List<Ciudades>
            {
                new Ciudades {ProvinciaId  = 1,CiudadesId = 1,NombreCiudad = "San Francisco De Macoris"},
                new Ciudades {ProvinciaId  = 1,CiudadesId = 2,NombreCiudad = "Arenoso"},
                new Ciudades {ProvinciaId  = 1,CiudadesId = 3,NombreCiudad = "otra mas"},
                new Ciudades {ProvinciaId  = 2,CiudadesId = 1,NombreCiudad = "Santiago de los caballeros"}
            }.AsQueryable();
        }
    }
}