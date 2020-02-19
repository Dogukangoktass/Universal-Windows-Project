using IOT.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace IOT_SL
{
    [ServiceContract]
    public interface IGameService
    {
        [OperationContract]
        User LoginUser(string username,string password);
        [OperationContract]
        List<User> GetUser();
        [OperationContract]
        void AddUser(User user);
        [OperationContract]
        void RemoveUser(int id);
        [OperationContract]
        void EditUser(User user);

    }



}
