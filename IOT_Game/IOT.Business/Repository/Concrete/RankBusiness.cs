using IOT.Business.Repository.Abstract;
using IOT.Entities;
using IOT.Entities.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IOT.Business.Repository.Concrete
{
    public class RankBusiness : IDatabaseBusiness<Ranking>
    {
        public void Delete(Ranking entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Ranking Get(int id)
        {
            throw new NotImplementedException();
        }

        public Ranking Get(Expression<Func<Ranking, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public List<Ranking> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Ranking> GetAll(Expression<Func<Ranking, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Insert(Ranking entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Ranking entity)
        {
            throw new NotImplementedException();
        }
        public async Task<List<RankViewModel>> Ranks()
        {
            using (GameDBEntities db = new GameDBEntities())
            {
                var rank = new List<RankViewModel>().ToList();
                var result = from r in db.Rankings
                             join u in db.Users on r.UserID equals u.UserID
                             join p in db.Prizes on r.PrizeId equals p.PrizeID
                             select new
                             {
                                 r.RankingID,
                                 r.PrizeId,
                                 r.UserID,
                                 u.UserName,
                                 p.PrizeTotal
                             };

                foreach (var ranking in result)
                {
                    rank.Add(new RankViewModel
                    {
                        RankingID = ranking.RankingID,
                        PrizeId = ranking.PrizeId,
                        UserID = ranking.UserID,
                        Username = ranking.UserName,
                        PrizeTotal = Convert.ToInt32(ranking.PrizeTotal)
                    });
                }
                return rank;
            }
        }
    }
}
