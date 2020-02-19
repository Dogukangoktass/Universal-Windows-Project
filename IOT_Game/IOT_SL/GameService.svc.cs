using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using IOT.Business.Repository.Concrete;
using IOT.Entities;

namespace IOT_SL
{
    public class GameService : IGameService
    {
        UserBusiness UserBusiness = new UserBusiness();
        public void AddUser(User user)
        {
            UserBusiness.Insert(user);
        }

        public void EditUser(User user)
        {
            UserBusiness.Update(user);
        }

        public List<User> GetUser()
        {
            return UserBusiness.GetAll();
        }

        public User LoginUser(string username, string password)
        {
            return UserBusiness.Get(x => x.UserName == username && x.Password == password);
        }

        public void RemoveUser(int id)
        {
            UserBusiness.Delete(id);
        }
    }
}
