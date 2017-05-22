using RegistrosBeautyCenter.DAL;
using RegistrosBeautyCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrosBeautyCenter.BLL
{
    public class CiudadesBLL
    {
        public static bool Guardar()
        {
            bool retorno = false;
            try
            {
                using (var db = new BeautyCenterDb())
                {
                    db.ciudade.Add(new Ciudades() { ProvinciaId = 1, CiudadesId = 1,NombreCiudad ="SFM"});
                    db.ciudade.Add(new Ciudades() { ProvinciaId = 1, CiudadesId = 1, NombreCiudad = "SFM" });
                    db.ciudade.Add(new Ciudades() { ProvinciaId = 1, CiudadesId = 3, NombreCiudad = "SFM" });
                    db.ciudade.Add(new Ciudades() { ProvinciaId = 1, CiudadesId = 4, NombreCiudad = "SFM" });
                    db.ciudade.Add(new Ciudades() { ProvinciaId = 1, CiudadesId = 5, NombreCiudad = "SFM" });
                    db.ciudade.Add(new Ciudades() { ProvinciaId = 1, CiudadesId = 6, NombreCiudad = "SFM" });
                    db.SaveChanges();
                }
                retorno = true;
            }
            catch (Exception)
            {
                throw;
            }
            return retorno;
        }
    }
}