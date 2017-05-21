using RegistrosBeautyCenter.DAL;
using RegistrosBeautyCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrosBeautyCenter.BLL
{
    public class ItemBLL
    {
        public static List<Items> GetLista()
        {
            var lista = new List<Items>();
            using (var conexion = new BeautyCenterDb())
            {
                try
                {
                    lista = conexion.item.ToList();

                }
                catch (Exception)
                {

                    throw;
                }
            }
            return lista;
        }
    }
}