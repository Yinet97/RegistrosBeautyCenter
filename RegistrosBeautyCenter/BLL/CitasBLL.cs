
using RegistrosBeautyCenter.Models;
using RegistrosBeautyCenter.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RegistrosBeautyCenter.BLL
{
    public class CitasBLL
    {
        public static bool Insertar(Citas cita)
        {
            bool retorno = false;

            using (var Conn = new BeautyCenterDb())
            {
                try
                {
                    var e = Buscar(cita.CitaId);
                    if (e == null)
                    {
                        Conn.Cita.Add(cita);
                    }
                    else
                        Conn.Entry(cita).State = EntityState.Modified;
                    Conn.SaveChanges();
                    retorno = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return retorno;
        }
        public static Citas Buscar(int Id)
        {
            var c = new Citas();
            using (var Conn = new BeautyCenterDb())
            {
                try
                {
                    c = Conn.Cita.Find(Id);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return c;
        }
        public static bool Eliminar(Citas cita)
        {
            bool resultado = false;
            using (var Conn = new BeautyCenterDb())
            {
                try
                {
                    Conn.Entry(cita).State = EntityState.Deleted;
                    Conn.SaveChanges();
                    resultado = true;
                    ///
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return resultado;
        }
        public static List<Citas> GetLista()
        {
            var lista = new List<Citas>();
            using (var conexion = new BeautyCenterDb())
            {
                try
                {
                    lista = conexion.Cita.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return lista;
        }
        public static List<Citas> GetListaId(int CitasId)
        {
            List<Citas> list = new List<Citas>();
            using (var db = new BeautyCenterDb())
            {
                try
                {
                    list = db.Cita.Where(p => p.CitaId == CitasId).ToList();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return list;
        }
    }
}