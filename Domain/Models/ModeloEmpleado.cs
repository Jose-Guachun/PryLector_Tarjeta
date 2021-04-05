using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Contratos;
using DataAccess.Entidades;
using DataAccess.Repositorios;
using Domain.ValorObjetos;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Domain.Models
{
    public class ModeloEmpleado
    {
        private int idEmpleado;
        private int idTipoUsu;
        private int idHorario;
        private string hora_Ingreso;
        private string hora_Salida;
        private string codigo;
        private string nombre_Apellido;
        private DateTime fecha_Nacimiento;
        private string estado_Civil;
        private string genero;
        private string nacionalidad;
        private string telefono;
        private string e_mail;
        private string direccion;
        private string cedula_Usuario;
        private string contraseña;
        private int edad;

        private IRepositorioEmpleado repositorioEmpleado;
        public EstadoEntidad estado { private get; set; }
        private List<ModeloEmpleado> ListaEmpleados;

        //propiedades/modelo de vista /validar datos
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public int IdTipoUsuario { get => idTipoUsu; set => idTipoUsu = value; }
        public int IdHorarios { get => idHorario; set => idHorario = value; }
        public string Hora_Ingreso { get => hora_Ingreso; set => hora_Ingreso = value; }
        public string Hora_Salida { get => hora_Salida; set => hora_Salida = value; }
        [Required(ErrorMessage = "El campo codigo del emepleado es requerido")]
        [RegularExpression("([0-9]+)", ErrorMessage = "El campo Codigo solo debe estar conformado por numeros")]
        [StringLength(maximumLength: 10, MinimumLength = 10, ErrorMessage = "El codigo debe de contener 10 digitos")]
        public string Codigo { get => codigo; set => codigo = value; }
        [Required]
        [StringLength(maximumLength: 100, MinimumLength = 6)]
        public string Nombre_Apellido { get => nombre_Apellido; set => nombre_Apellido = value; }
        public DateTime Fecha_Nacimiento { get => fecha_Nacimiento; set => fecha_Nacimiento = value; }
        public string Estado_Civil { get => estado_Civil; set => estado_Civil = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        [Required(ErrorMessage = "El campo Telefono del emepleado es requerido")]
        [RegularExpression("([0-9]+)", ErrorMessage = "El campo Telefono olo debe estar conformado por numeros")]
        [StringLength(maximumLength: 10, MinimumLength = 10, ErrorMessage = "El campo Telefono debe de contener 10 digitos")]
        public string Telefono { get => telefono; set => telefono = value; }
        [Required]
        public string E_mail { get => e_mail; set => e_mail = value; }
        [Required(ErrorMessage = "La Direccion del empleado es requerido")]
        public string Direccion { get => direccion; set => direccion = value; }
        [Required(ErrorMessage = "La Cedula Usuario del empleado es requerido")]
        [RegularExpression("([0-9]+)", ErrorMessage = "El campo Cedula Usuario solo debe estar conformado por numeros")]
        [StringLength(maximumLength: 10, MinimumLength = 10, ErrorMessage = "El campo Cedula Usuario debe de contener 10 digitos")]
        public string Cedula_usuario { get => cedula_Usuario; set => cedula_Usuario = value; }
        [Required(ErrorMessage = "La Contraseña del empleado es requerida")]
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public int Edad { get => edad; private set => edad = value; }

        public ModeloEmpleado()
        {
            repositorioEmpleado = new RepositorioEmpleado();
        }
        public string Guardar()
        {
            string mensaje=null;
            try
            {
                var ModeloDatosEmpleado = new TB_EMPLEADO();
                ModeloDatosEmpleado.IdEmpleado = idEmpleado;
                ModeloDatosEmpleado.IdTipoUsu = idTipoUsu;
                ModeloDatosEmpleado.IdHorario = idHorario;
                ModeloDatosEmpleado.Codigo = codigo;
                ModeloDatosEmpleado.Nombre_Apellido = nombre_Apellido;
                ModeloDatosEmpleado.Fecha_Nacimiento = fecha_Nacimiento;
                ModeloDatosEmpleado.Estado_Civil = estado_Civil;
                ModeloDatosEmpleado.Genero = genero;
                ModeloDatosEmpleado.Nacionalidad = nacionalidad;
                ModeloDatosEmpleado.Telefono = telefono;
                ModeloDatosEmpleado.E_mail = e_mail.ToLower();
                ModeloDatosEmpleado.Direccion = direccion;
                ModeloDatosEmpleado.Cedula_Usuario = cedula_Usuario;
                ModeloDatosEmpleado.Contraseña = contraseña;

                switch (estado)
                {
                    case EstadoEntidad.Agregar:
                        //ejecutar reglas comerciales/calculos
                        repositorioEmpleado.Add(ModeloDatosEmpleado);
                        mensaje = "Se a registrado Correctamente";
                        break;
                    case EstadoEntidad.Modificar:
                        repositorioEmpleado.Adit(ModeloDatosEmpleado);
                        mensaje = "Se a editado correctamente";
                        break;
                    case EstadoEntidad.Eliminar:
                        repositorioEmpleado.Remove(idEmpleado);
                        mensaje = "Se a Eliminado correctamente";
                        break;
                }

            }
            catch (Exception ex)
            {
                System.Data.SqlClient.SqlException sqlEx = ex as System.Data.SqlClient.SqlException;
                if (sqlEx!=null && sqlEx.Number==2627 )
                {
                    mensaje = "Registro Duplicado";
                }
                else
                    mensaje = ex.ToString();
            }
            return mensaje;
        }


    }
}
