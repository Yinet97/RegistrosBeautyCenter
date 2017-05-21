using RegistrosBeautyCenter.DAL;
using RegistrosBeautyCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrosBeautyCenter.BLL
{
    public class ProvinciasBLL
    {
        public static bool Guardar()
        {
            bool retorno = false;
            try
            {
                using (var db = new BeautyCenterDb())
                {
                    db.Provincia.Add(new Provincias() { Nombre = "Duarte" });
                    db.Provincia.Add(new Provincias() { Nombre = "Mao" });
                    db.Provincia.Add(new Provincias() { Nombre = "Sanchez Ramirez" });
                    db.Provincia.Add(new Provincias() { Nombre = "Sto Dgo" });
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


        public static List<Provincias> GetLista()
        {
            List<Provincias> lista = new List<Provincias>();
            BeautyCenterDb db = new BeautyCenterDb();

            lista = db.Provincia.ToList();
            return lista;
        }
    }
}