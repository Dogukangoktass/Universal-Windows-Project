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
    public class CategoryBusiness : IDatabaseBusiness<Category>
    {
        GameDBEntities db = new GameDBEntities();
        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Category Get(int id)
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Category, bool>> expression)
        {
            return db.Categories.Where(expression).FirstOrDefault();
        }

        public List<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> expression)
        {
            return db.Categories.Where(expression).ToList();
        }

        public void Insert(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
