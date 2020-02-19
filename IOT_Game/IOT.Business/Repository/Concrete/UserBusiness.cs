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
    public class UserBusiness : IDatabaseBusiness<User>
    {
        GameDBEntities db = new GameDBEntities();
        public void Delete(User entity)
        {
            db.Users.Attach(entity);
            db.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var user = Get(id);
            db.Users.Attach(user);
            db.Entry(user).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }

        public User Get(int id)
        {
            return db.Users.Find(id);
        }

        public User Get(Expression<Func<User, bool>> expression)
        {
            return db.Users.Where(expression).FirstOrDefault();
        }
        public bool GetControl(Expression<Func<User, bool>> expression)
        {
           return db.Users.Where(expression).Count()==1 ? true : false;
           
        }
        public List<User> GetAll()
        {
            return db.Users.ToList();
        }

        public List<User> GetAll(Expression<Func<User, bool>> expression)
        {
            return db.Users.Where(expression).ToList();
        }

        public void Insert(User entity)
        {
            db.Users.Add(entity);
            db.SaveChanges();
        }

        public void Update(User entity)
        {
            db.Users.Attach(entity);
            db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

    }
}
