using RegistrosBeautyCenter.DAL;
using RegistrosBeautyCenter.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RegistrosBeautyCenter.BLL
{
    public class ClientesBLL
    {
        public static bool Insertar(Clientes cliente)
        {
            bool retorno = false;

            using (var Conn = new BeautyCenterDb())
            {
                try
                {
                    var e = Buscar(cliente.ClienteID);
                    if (e == null)
                    {
                        Conn.Cliente.Add(cliente);
                    }
                    else
                        Conn.Entry(cliente).State = EntityState.Modified;
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
        public static Clientes Buscar(int Id)
        {
            var c = new Clientes();
            using (var Conn = new BeautyCenterDb())
            {
                try
                {
                    c = Conn.Cliente.Find(Id);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return c;
        }
        public static bool Eliminar(Clientes cliente)
        {
            bool resultado = false;
            using (var Conn = new BeautyCenterDb())
            {
                try
                {
                    Conn.Entry(cliente).State = EntityState.Deleted;
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
        public static List<Clientes> GetLista()
        {
            var lista = new List<Clientes>();
            using (var conexion = new BeautyCenterDb())
            {
                try
                {
                    lista = conexion.Cliente.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return lista;
        }
        public static List<Clientes> GetListaId(int ClientesId)
        {
            List<Clientes> list = new List<Clientes>();
            using (var db = new BeautyCenterDb())
            {
                try
                {
                    list = db.Cliente.Where(p => p.ClienteID == ClientesId).ToList();
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