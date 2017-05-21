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
                    db.Provincia.Add(new Provincias() { Nombre = "Cotui" });
                    db.Provincia.Add(new Provincias() { Nombre = "SFM" });
                    db.Provincia.Add(new Provincias() { Nombre = "Capital" });
                    db.Provincia.Add(new Provincias() { Nombre = "marimar" });
                    db.Provincia.Add(new Provincias() { Nombre = "klk" });
                    db.Provincia.Add(new Provincias() { Nombre = "Hola" });
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


        public static List<Ciudades> GetLista()
        {
            List<Ciudades> lista = new List<Ciudades>();
            BeautyCenterDb db = new BeautyCenterDb();

            lista = db.ciudades.ToList();
            return lista;
        }

       
    }
}