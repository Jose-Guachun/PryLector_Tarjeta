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
    public class ModeloConsultaEmpleado
    {
        private int idEmpleado;
        private string tipoUsu;
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
        private List<ModeloConsultaEmpleado> ListaEmpleado;

        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string TipoUsu { get => tipoUsu; set => tipoUsu = value; }
        public string Hora_Ingreso { get => hora_Ingreso; set => hora_Ingreso = value; }
        public string Hora_Salida { get => hora_Salida; set => hora_Salida = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre_Apellido { get => nombre_Apellido; set => nombre_Apellido = value; }
        public DateTime Fecha_Nacimiento { get => fecha_Nacimiento; set => fecha_Nacimiento = value; }
        public string Estado_Civil { get => estado_Civil; set => estado_Civil = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string E_mail { get => e_mail; set => e_mail = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Cedula_Usuario { get => cedula_Usuario; set => cedula_Usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public int Edad { get => edad; set => edad = value; }
       
        public ModeloConsultaEmpleado()
        {
            repositorioEmpleado = new RepositorioEmpleado();
        }
        public List<ModeloConsultaEmpleado> GetAll()
        {
            var ModeloDatosEmpleado = repositorioEmpleado.GetAll();
            ListaEmpleado = new List<ModeloConsultaEmpleado>();
            foreach (TB_EMPLEADO item in ModeloDatosEmpleado)
            {
                ListaEmpleado.Add(new ModeloConsultaEmpleado
                {
                    idEmpleado = item.IdEmpleado,
                    tipoUsu = item.Tipo_Usu,
                    hora_Ingreso = item.Hora_Ingreso,
                    hora_Salida = item.Hora_Salida,
                    codigo = item.Codigo,
                    nombre_Apellido = item.Nombre_Apellido,
                    fecha_Nacimiento = item.Fecha_Nacimiento,
                    estado_Civil = item.Estado_Civil,
                    genero = item.Genero,
                    nacionalidad = item.Nacionalidad,
                    telefono = item.Telefono,
                    e_mail = item.E_mail,
                    direccion = item.Direccion,
                    cedula_Usuario = item.Cedula_Usuario,
                    contraseña = item.Contraseña,
                    edad = CalcularEdad(fecha_Nacimiento)
                });
            }
            return ListaEmpleado;
        }
        public IEnumerable<ModeloConsultaEmpleado> FindById(string filter)
        {
            return ListaEmpleado.FindAll(e => e.codigo.Contains(filter) || e.nombre_Apellido.ToLower().Contains(filter.ToLower()));
        }
        private int CalcularEdad(DateTime date)
        {
            DateTime dateNow = DateTime.Now;
            return dateNow.Year - date.Year;
        }
    }
}
