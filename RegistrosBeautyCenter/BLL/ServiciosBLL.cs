using RegistrosBeautyCenter.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrosBeautyCenter.BLL
{
    public class ServiciosBLL
    {
        public static bool Guardar()
        {
            using (var conexion = new BeautyCenterDb())
            {
                try
                {
                    conexion.service.Add(new Models.Servicios() { TipoServicio = "Secado" });
                    conexion.service.Add(new Models.Servicios() { TipoServicio = "blabla" });
                    conexion.service.Add(new Models.Servicios() { TipoServicio = "Nose" });
                    conexion.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return false;
        }
    }
}