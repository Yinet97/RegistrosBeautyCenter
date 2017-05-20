﻿using RegistrosBeautyCenter.DAL;
using RegistrosBeautyCenter.Models;
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
            bool resultado = false;
            using (var conexion = new BeautyCenterDb())
            {
                try
                {
                    conexion.service.Add(new Models.Servicios() { ServicioId = 1, TipoServicio = "Secado", Costo = 500 });
                    conexion.service.Add(new Models.Servicios() { ServicioId = 2, TipoServicio = "blabla", Costo = 500 });
                    conexion.service.Add(new Models.Servicios() { ServicioId = 3, TipoServicio = "Jesus", Costo = 500 });
                    conexion.SaveChanges();
                    resultado = true;
                }
                catch (Exception)
                {

                    throw;
                }
                return resultado;
            }
        }
        public static List<Servicios> GetLista()
        {
            var lista = new List<Servicios>();
            using (var conexion = new BeautyCenterDb())
            {
                try
                {
                    lista = conexion.service.ToList();

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

    