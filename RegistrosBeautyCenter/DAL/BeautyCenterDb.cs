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
        //public System.Data.Entity.DbSet<Registros.Models.Clientes> Cliente { get; set; }

        public System.Data.Entity.DbSet<Registros.Models.Empleados> Empleado { get; set; }

        public System.Data.Entity.DbSet<Registros.Models.Usuarios> Usuario { get; set; }

        public System.Data.Entity.DbSet<Registros.Models.Citas> Cita { get; set; }

        public System.Data.Entity.DbSet<Registros.Models.Servicios> service { get; set; }
    }
}