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
    public class DegreeOfDiffilcultBusiness : IDatabaseBusiness<DegreeOfDifficulty>
    {
        GameDBEntities db = new GameDBEntities();
        public void Delete(DegreeOfDifficulty entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public DegreeOfDifficulty Get(int id)
        {
            throw new NotImplementedException();
        }

        public DegreeOfDifficulty Get(Expression<Func<DegreeOfDifficulty, bool>> expression)
        {
            return db.DegreeOfDifficulties.Where(expression).FirstOrDefault();
        }

        public List<DegreeOfDifficulty> GetAll()
        {
            return db.DegreeOfDifficulties.ToList();
        }

        public List<DegreeOfDifficulty> GetAll(Expression<Func<DegreeOfDifficulty, bool>> expression)
        {
            return db.DegreeOfDifficulties.Where(expression).ToList();
        }

        public void Insert(DegreeOfDifficulty entity)
        {
            throw new NotImplementedException();
        }

        public void Update(DegreeOfDifficulty entity)
        {
            throw new NotImplementedException();
        }
    }
}
