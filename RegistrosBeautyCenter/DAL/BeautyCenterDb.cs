using RegistrosBeautyCenter.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RegistrosBeautyCenter.DAL
{
    public class BeautyCenterDb : DbContext
    {
        public BeautyCenterDb(): base("ConStr")
        {

        }
        public DbSet<Clientes> Cliente { get; set; }

        //public DbSet<Empleados> Empleado { get; set; }

        //public DbSet<Usuarios> Usuario { get; set; }

        public DbSet<Citas> Cita { get; set; }

        public DbSet<Servicios> service { get; set; }
        public DbSet<Provincias> provincia { get; set; }
        public DbSet<Ciudades> ciudade { get; set; }
    }
}
        