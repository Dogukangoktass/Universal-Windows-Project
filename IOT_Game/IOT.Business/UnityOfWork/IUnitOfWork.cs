using IOT.Business.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Business.UnityOfWork
{
   public interface IUnitOfWork:IDisposable
    {
        IRepository<T> GetRepository<T>() where T : class;

        int SaveChanges();
    }
}
