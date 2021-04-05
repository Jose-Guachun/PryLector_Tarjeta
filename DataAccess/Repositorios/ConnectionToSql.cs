using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Configuration;


namespace DataAccess
{
    //no puede ser instanciada solo se puede heredar
    public abstract class ConnectionToSql
    {
        //readonly es una forma de encapsulacion
        private readonly string connectionString;
        /// <summary>
        /// Antes de escribir esta linea se debe referenciar 
        /// el DataAcces con System.configuration y a su vez 
        /// implementarlo using System.Configuration;
        /// </summary>
        public ConnectionToSql()
        {
            connectionString = ConfigurationManager.ConnectionStrings["BD_Recarga_Tarjeta"].ToString();
        }
        // Se obtiene la conexion.
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
