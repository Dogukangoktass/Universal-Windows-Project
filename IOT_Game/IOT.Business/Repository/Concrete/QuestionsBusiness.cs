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
	public class QuestionsBusiness : IDatabaseBusiness<Question>
	{
		GameDBEntities db = new GameDBEntities();


		public void Delete(Question entity)
		{
			{
				db.Questions.Attach(entity);
				db.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
				db.SaveChanges();
			}
		}
		public void Delete(int id)
		{
			var question = Get(id);
			db.Questions.Attach(question);
			db.Entry(question).State = System.Data.Entity.EntityState.Deleted;
			db.SaveChanges();
		}

		public Question Get(int id)
		{
			return db.Questions.Find(id);
		}

		public Question Get(Expression<Func<Question, bool>> expression)
		{
			return db.Questions.Where(expression).FirstOrDefault();
		}

		public List<Question> GetAll()
		{
			return db.Questions.ToList();
		}

		public List<Question> GetAll(Expression<Func<Question, bool>> expression)
		{
			return db.Questions.Where(expression).ToList();
		}

		public void Insert(Question entity)
		{
			db.Questions.Add(entity);
			db.SaveChanges();
		}

		public void Update(Question entity)
		{
			db.Questions.Attach(entity);
			db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
			db.SaveChanges();
		}
	}
}
