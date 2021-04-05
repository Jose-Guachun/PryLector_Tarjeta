using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Contratos;
using DataAccess.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Repositorios
{
    public class RepositorioTarjeta : RepositorioMaestro, IRepositorioTarjeta
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;
        //constructores
        public RepositorioTarjeta()
        {
            selectAll = "SELECT IdTarjeta, Nombre_Apellido, UID, Fecha, Valor_Recarga FROM TB_TARJETA inner join TB_EMPLEADO  ON TB_TARJETA.IdEmpleado=TB_EMPLEADO.IdEmpleado";
            insert = "insert into TB_TARJETA values(@IdEmpleado, @UID, @Fecha, @Valor_Recarga)";
            update = "update TB_TARJETA set IdEmpleado=@IdEmpleado, UID=@UID, Fecha=@Fecha, Valor_Recarga=@Valor_Recarga where IdTarjeta=@IdTarjeta";
            delete = "delete from TB_TARJETA WHERE IdTarjeta=@IdTarjeta";
        }

        //este metodo recive como parametro un metodo que es la entidad TB_EMPLEADO
        public int Add(TB_TARJETA entity)
        {
            //creamos una lista de parametros referenciar el data
            //y el data.sqlclient.
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IdEmpleado", entity.IdEmpleado));
            parameters.Add(new SqlParameter("@UID", entity.UID));
            parameters.Add(new SqlParameter("@Fecha", entity.Fecha));
            parameters.Add(new SqlParameter("@Valor_Recarga", entity.Valor_Recarga));
            //requiere que enviemos un comando transactSQL 
            return ExecuteNonQuery(insert);
        }

        public int Adit(TB_TARJETA entity)
        {
            parameters.Add(new SqlParameter("@IdTarjeta", entity.IdTarjeta));
            parameters.Add(new SqlParameter("@IdEmpleado", entity.IdEmpleado));
            parameters.Add(new SqlParameter("@UID", entity.UID));
            parameters.Add(new SqlParameter("@Fecha", entity.Fecha));
            parameters.Add(new SqlParameter("@Valor_Recarga", entity.Valor_Recarga));
            //requiere que enviemos un comando transactSQL 
            return ExecuteNonQuery(update);
        }

        public IEnumerable<TB_TARJETA> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listTarjeta = new List<TB_TARJETA>();
            foreach (DataRow item in tableResult.Rows)
            {
                listTarjeta.Add(new TB_TARJETA
                {
                    IdTarjeta = Convert.ToInt32(item[0]),
                    Empleado =item[1].ToString(),
                    UID = item[2].ToString(),
                    Fecha= Convert.ToDateTime(item[3]),
                    Valor_Recarga =float.Parse(item[4].ToString()),
                });
            }
            return listTarjeta;
        }

        public int Remove(int IdTarjeta)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IdTarjeta", IdTarjeta));
            //requiere que enviemos un comando transactSQL 
            return ExecuteNonQuery(delete);
        }
    }
}

