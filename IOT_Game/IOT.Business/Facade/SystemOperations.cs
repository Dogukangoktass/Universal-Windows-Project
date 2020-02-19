using IOT.Business.Repository.Concrete;
using IOT.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Business.Facade
{
   public class SystemOperations
    {
        UserBusiness userBusiness = new UserBusiness();
        public User UserGet(string username,string password)
        {
            return userBusiness.Get(x => x.UserName == username && x.Password == password);
        }
        public User Login (string username, string password)
        {
            return UserGet(username,password);
        }
    }
}
