using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;

namespace Domain
{
    public class UserModel
    {
        RepositorioMaestro userData = new RepositorioMaestro();
        public bool LoginUser(string user, string pass)
        {
            return userData.Login(user, pass);
        }
    }
}