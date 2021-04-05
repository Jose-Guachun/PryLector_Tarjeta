using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Entidades
{
    public class TB_TARJETA
    {
        public int IdTarjeta { get; set; }
        public int IdEmpleado { get; set; }
        public string Empleado { get; set; }
        public string UID { get; set; }
        public DateTime Fecha { get; set; }
        public float Valor_Recarga { get; set; }
    }
}
