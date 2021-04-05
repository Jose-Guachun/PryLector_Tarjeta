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
    public class RepositorioEmpleado : RepositorioMaestro, IRepositorioEmpleado
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        //constructores
        public RepositorioEmpleado()
        {
            selectAll= "SELECT IdEmpleado,Tipo_Usuario, Hora_Ingreso, Hora_Salida, Codigo, Nombre_Apellido,Fecha_Nacimiento,Estado_Civil,Genero,Nacionalidad,Telefono,E_mail,Direccion,Cedula_Usuario,Contraseña FROM TB_EMPLEADO inner join TB_TIPO_USUARIO  ON TB_EMPLEADO.IdTipoUsu=TB_TIPO_USUARIO.IdTipoUsu inner join TB_HORARIO ON TB_EMPLEADO.IdHorario=TB_HORARIO.IdHorario";
            insert = "insert into TB_EMPLEADO values(@IdTipoUsu, @IdHorario, @Codigo, @Nombre_Apellido, @Fecha_Nacimiento, @Estado_Civil, @Genero, @Nacionalidad, @Telefono, @E_mail, @Direccion, @Cedula_Usuario, @Contraseña)";
            update = "update TB_EMPLEADO set IdTipoUsu=@IdTipoUsu, IdHorario=@IdHorario, Codigo=@Codigo, Nombre_Apellido=@Nombre_Apellido, Fecha_Nacimiento=@Fecha_Nacimiento, Estado_Civil=@Estado_Civil, Genero=@Genero, Nacionalidad=@Nacionalidad, Telefono=@Telefono, E_mail=@E_mail, Direccion=@Direccion, Cedula_Usuario=@Cedula_Usuario, Contraseña=@Contraseña where IdEmpleado=@IdEmpleado";
            delete = "delete from TB_EMPLEADO WHERE IdEmpleado=@IdEmpleado";
        }

        //este metodo recive como parametro un metodo que es la entidad TB_EMPLEADO
        public int Add(TB_EMPLEADO entity)
        {
            //creamos una lista de parametros referenciar el data
            //y el data.sqlclient.
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IdTipoUsu", entity.IdTipoUsu));
            parameters.Add(new SqlParameter("@IdHorario", entity.IdHorario));
            parameters.Add(new SqlParameter("@Codigo", entity.Codigo));
            parameters.Add(new SqlParameter("@Nombre_Apellido", entity.Nombre_Apellido));
            parameters.Add(new SqlParameter("@Fecha_Nacimiento", entity.Fecha_Nacimiento));
            parameters.Add(new SqlParameter("@Estado_Civil", entity.Estado_Civil));
            parameters.Add(new SqlParameter("@Genero", entity.Genero));
            parameters.Add(new SqlParameter("@Nacionalidad", entity.Nacionalidad));
            parameters.Add(new SqlParameter("@Telefono", entity.Telefono));
            parameters.Add(new SqlParameter("@E_mail", entity.E_mail));
            parameters.Add(new SqlParameter("@Direccion", entity.Direccion));
            parameters.Add(new SqlParameter("@Cedula_Usuario", entity.Cedula_Usuario));
            parameters.Add(new SqlParameter("@Contraseña", entity.Contraseña));
            //requiere que enviemos un comando transactSQL 
            return ExecuteNonQuery(insert);
        }

        public int Adit(TB_EMPLEADO entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IdEmpleado", entity.IdEmpleado));
            parameters.Add(new SqlParameter("@IdTipoUsu", entity.IdTipoUsu));
            parameters.Add(new SqlParameter("@IdHorario", entity.IdHorario));
            parameters.Add(new SqlParameter("@Codigo", entity.Codigo));
            parameters.Add(new SqlParameter("@Nombre_Apellido", entity.Nombre_Apellido));
            parameters.Add(new SqlParameter("@Fecha_Nacimiento", entity.Fecha_Nacimiento));
            parameters.Add(new SqlParameter("@Estado_Civil", entity.Estado_Civil));
            parameters.Add(new SqlParameter("@Genero", entity.Genero));
            parameters.Add(new SqlParameter("@Nacionalidad", entity.Nacionalidad));
            parameters.Add(new SqlParameter("@Telefono", entity.Telefono));
            parameters.Add(new SqlParameter("@E_mail", entity.E_mail));
            parameters.Add(new SqlParameter("@Direccion", entity.Direccion));
            parameters.Add(new SqlParameter("@Cedula_Usuario", entity.Cedula_Usuario));
            parameters.Add(new SqlParameter("@Contraseña", entity.Contraseña));
            //requiere que enviemos un comando transactSQL 
            return ExecuteNonQuery(update);
        }

        public IEnumerable<TB_EMPLEADO> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listEmpleado = new List<TB_EMPLEADO>();
            foreach (DataRow item in tableResult.Rows)
            {
                listEmpleado.Add(new TB_EMPLEADO
                {
                    IdEmpleado=Convert.ToInt32(item[0]),
                    Tipo_Usu = item[1].ToString(),
                    Hora_Ingreso =item[2].ToString(),
                    Hora_Salida = item[3].ToString(),
                    Codigo =item[4].ToString(),
                    Nombre_Apellido= item[5].ToString(),
                    Fecha_Nacimiento= Convert.ToDateTime(item[6]),
                    Estado_Civil = item[7].ToString(),
                    Genero = item[8].ToString(),
                    Nacionalidad = item[9].ToString(),
                    Telefono = item[10].ToString(),
                    E_mail = item[11].ToString(),
                    Direccion = item[12].ToString(),
                    Cedula_Usuario = item[13].ToString(),
                    Contraseña = item[14].ToString()
                } ); 
            }
            return listEmpleado;
        }

        public int Remove(int IdEmpleado)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IdEmpleado", IdEmpleado));
            //requiere que enviemos un comando transactSQL 
            return ExecuteNonQuery(delete);
        }
    }
}
