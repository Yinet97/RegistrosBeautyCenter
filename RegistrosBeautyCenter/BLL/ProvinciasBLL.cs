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
                    db.provincia.Add(new Provincias() {ProvinciaId = 1, NombreProvincia = "Duarte" });
                    db.provincia.Add(new Provincias() {ProvinciaId = 1, NombreProvincia = "Mao" });
                    db.provincia.Add(new Provincias() {ProvinciaId = 1, NombreProvincia= "Sanchez Ramirez" });
                    db.provincia.Add(new Provincias() {ProvinciaId = 1, NombreProvincia = "Sto Dgo" });
                    db.provincia.Add(new Provincias() {ProvinciaId = 1, NombreProvincia = "klk" });
                    db.provincia.Add(new Provincias() {ProvinciaId = 1, NombreProvincia = "Hola" });
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


        //public static List<Provincias> GetLista()
        //{
        //    List<Provincias> lista = new List<Provincias>();
        //    BeautyCenterDb db = new BeautyCenterDb();

        //    lista = db.Provincia.ToList();
        //    return lista;
        //}
    }
}