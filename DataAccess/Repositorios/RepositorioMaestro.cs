using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Common.Cache;
using System.Data.SqlClient;
namespace DataAccess
{
    public class RepositorioMaestro : ConnectionToSql
    {
        //lista generica de parametros Sql
        protected List<SqlParameter> parameters;

        //metodo de ejecutar comandos de no consulta, 
        //comando para insertar, editar y eliminar datos. 
        protected int ExecuteNonQuery(string transactSql)
        {
            using(var connection = GetConnection())
            {
                connection.Open();
                using (var command=new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = transactSql;
                    command.CommandType = CommandType.Text;
                    foreach (SqlParameter item in parameters)
                    {
                        command.Parameters.Add(item);
                    }
                    int result = command.ExecuteNonQuery();
                    parameters.Clear();
                    return result;
                }
            }
        }
        //se encarga de ejecutar comando de consultar leer tablas etc.
        protected DataTable ExecuteReader(string transactSql)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = transactSql;
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    using (var table = new DataTable())
                    {
                        table.Load(reader);
                        reader.Dispose();
                        return table;
                    }
                }
            }
        }

        public bool Login(string user, string pass)
        {
            //el objeto existe hasta que se termine la isntrusccion
            //es decir se desecha para ahorrar recursos
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT IdEmpleado,Tipo_Usuario, Nombre_Apellido, E_mail, Cedula_Usuario,Contraseña  FROM TB_EMPLEADO inner join TB_TIPO_USUARIO ON TB_EMPLEADO.IdTipoUsu = TB_TIPO_USUARIO.IdTipoUsu WHERE Cedula_Usuario = @usuario and Contraseña = @pass";
                    command.Parameters.AddWithValue("@usuario", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    //no se recomienda el uso de procedimientos almacenado
                    //ya que se sacrifica mantenimiento a cambia de rendimiento.
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserCache.IdEmpleado = reader.GetInt32(0);
                            UserCache.IdTipoUser = reader.GetString(1);
                            UserCache.Nombre = reader.GetString(2);
                            UserCache.E_mail = reader.GetString(3);       
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }

}