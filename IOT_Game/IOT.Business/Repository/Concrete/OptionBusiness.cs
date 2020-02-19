using IOT.Business.Repository.Abstract;
using IOT.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Business.Repository.Concrete
{
    public class OptionBusiness : IDatabaseBusiness<Option>
    {
        GameDBEntities db = new GameDBEntities();
        public void Delete(Option entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Option Get(int id)
        {
            throw new NotImplementedException();
        }

        public Option Get(Expression<Func<Option, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public List<Option> GetAll()
        {
            return db.Options.ToList();
        }

        public List<Option> GetAll(Expression<Func<Option, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Insert(Option entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Option entity)
        {
            throw new NotImplementedException();
        }
    }
}
