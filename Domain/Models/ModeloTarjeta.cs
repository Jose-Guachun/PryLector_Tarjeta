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
    public class ModeloTarjeta
    {
        private int idTarjeta;
        private int idEmpleado;
        private string uid;
        private DateTime fecha;
        private float valor_Recarga;

        private IRepositorioTarjeta repositorioTarjeta;
        public EstadoEntidad estado { private get; set; }
        private List<ModeloTarjeta> ListaRecarga;
        
        public int IdTarjeta { get => idTarjeta; set => idTarjeta = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string Uid { get => uid; set => uid = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public float Valor_Recarga { get => valor_Recarga; set => valor_Recarga = value; }

        public ModeloTarjeta()
        {
            repositorioTarjeta = new RepositorioTarjeta();
        }
        public string Guardar()
        {
            string mensaje = null;
            try
            {
                var ModeloDatosTarjeta = new TB_TARJETA();
                ModeloDatosTarjeta.IdTarjeta = idTarjeta;
                ModeloDatosTarjeta.IdEmpleado = idEmpleado;
                ModeloDatosTarjeta.UID= uid;
                ModeloDatosTarjeta.Fecha= fecha;
                ModeloDatosTarjeta.Valor_Recarga = Valor_Recarga;
                switch (estado)
                {
                    case EstadoEntidad.Agregar:
                        //ejecutar reglas comerciales/calculos
                        repositorioTarjeta.Add(ModeloDatosTarjeta);
                        mensaje = "Se recargo Correctamente";
                        break;
                    case EstadoEntidad.Modificar:
                        repositorioTarjeta.Adit(ModeloDatosTarjeta);
                        mensaje = "Se a editado correctamente";
                        break;
                    case EstadoEntidad.Eliminar:
                        repositorioTarjeta.Remove(idTarjeta);
                        mensaje = "Se a Eliminado correctamente";
                        break;
                }

            }
            catch (Exception ex)
            {
                System.Data.SqlClient.SqlException sqlEx = ex as System.Data.SqlClient.SqlException;
                if (sqlEx != null && sqlEx.Number == 2627)
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
