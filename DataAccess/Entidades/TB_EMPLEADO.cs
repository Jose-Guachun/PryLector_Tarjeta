using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Entidades
{
    public class TB_EMPLEADO
    {
        public int IdEmpleado { get; set; }
        public int IdTipoUsu { get; set; }
        public int IdHorario { get; set; }
        public string Tipo_Usu { get; set; }
        public string Hora_Ingreso{ get; set; }
        public string Hora_Salida { get; set; }
        public string Codigo { get; set; }
        public string Nombre_Apellido { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Estado_Civil { get; set; }
        public string Genero { get; set; }
        public string Nacionalidad { get; set; }
        public string Telefono { get; set; }
        public string E_mail { get; set; }
        public string Direccion { get; set; }
        public string Cedula_Usuario { get; set; }
        public string Contraseña { get; set; }
    }
}
