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
    public class ModeloConsultaTarjeta
    {
        private int idTarjeta;
        private string empleado;
        private string uid;
        private DateTime fecha;
        private float valor_Recarga;

        private IRepositorioTarjeta repositorioTarjeta;
        public EstadoEntidad estado { private get; set; }
        private List<ModeloConsultaTarjeta> ListaRecarga;

        public int IdTarjeta { get => idTarjeta; set => idTarjeta = value; }
        public string Empleado { get => empleado; set => empleado = value; }
        public string Uid { get => uid; set => uid = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public float Valor_Recarga { get => valor_Recarga; set => valor_Recarga = value; }

        public ModeloConsultaTarjeta()
        {
            repositorioTarjeta = new RepositorioTarjeta();
        }
        public List<ModeloConsultaTarjeta> GetAll()
        {
            var ModeloDatosTarjeta = repositorioTarjeta.GetAll();
            ListaRecarga = new List<ModeloConsultaTarjeta>();
            foreach (TB_TARJETA item in ModeloDatosTarjeta)
            {
                ListaRecarga.Add(new ModeloConsultaTarjeta
                {
                    idTarjeta = item.IdTarjeta,
                    empleado = item.Empleado,
                    uid = item.UID,
                    fecha= item.Fecha,
                    Valor_Recarga= item.Valor_Recarga,
                });
            }
            return ListaRecarga;
        }
        public IEnumerable<ModeloConsultaTarjeta> FindById(string filter)
        {
            return ListaRecarga.FindAll(e => e.empleado.Contains(filter));
        }
    }
}