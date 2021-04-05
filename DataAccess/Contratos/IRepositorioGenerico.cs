using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Entidades;

namespace DataAccess.Contratos
{
    //interfaz generica y por ende tendra un
    //parametro de tipo generico 
    public interface IRepositorioGenerico<Entity> where Entity:class
    {
        //metodos comunes que se utilizara para todos los
        //repositorios que la implementen 
        int Add(Entity entity);
        int Adit(Entity entity);
        int Remove(int IdPk);
        IEnumerable<Entity> GetAll();
    }
}
