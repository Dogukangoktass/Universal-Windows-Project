using IOT.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Business.Facade
{
   public class Facade
    {
        SystemOperations system = new SystemOperations();
        public User CheckUser(string username,string password)
        {
            return system.Login(username, password);
        }
    }
}
