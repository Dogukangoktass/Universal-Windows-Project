using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using IOT.Business.Repository.Concrete;
using IOT.Entities;
using IOT.Entities.ViewModel;

namespace IOT.Service
{
    public class GameService : IGameService
    {
        UserBusiness userBusiness = new UserBusiness();
		QuestionsBusiness questionBusiness = new QuestionsBusiness();
        CategoryBusiness categoryBusiness = new CategoryBusiness();
        RankBusiness RankBusiness = new RankBusiness();
        DegreeOfDiffilcultBusiness dod = new DegreeOfDiffilcultBusiness();
        OptionBusiness OptionBusiness = new OptionBusiness();

		public void AddQuestion(Question question)
		{
			questionBusiness.Insert(question);
		}

		public void AddUser(User user)
        {
            userBusiness.Insert(user);
        }

		public void EditQuestion(Question question)
		{
			questionBusiness.Update(question);
		}

		public void EditUser(User user)
        {
            userBusiness.Update(user);
        }

        public async Task<List<Category>> GetCategory(string categoryname)
        {           
            return categoryBusiness.GetAll(x => x.CategoryName == categoryname).ToList();
        }

        public async Task<List<Category>>GetCategory()
        {
            return  categoryBusiness.GetAll();
        }

        public async Task<List<DegreeOfDifficulty>> GetDod()
        {
            return  dod.GetAll();
        }

        public async Task<List<Option>> GetOption()
        {
            return OptionBusiness.GetAll();
        }

        public async Task<List<Question>> GetQuestions()
		{
			return questionBusiness.GetAll();
		}

        public async Task<List<RankViewModel>> GetRanks()
        {
            return await RankBusiness.Ranks();
        }

        public async Task<List<User>> GetUsers()
        {
            return userBusiness.GetAll();
        }

        public  User LoginUser(string username, string password)
        {
            return userBusiness.Get(x => x.UserName == username && x.Password == password);
        }

		public void RemoveQuestion(int id)
		{
			throw new NotImplementedException();
		}

		public void RemoveUser(int id)
        {
            userBusiness.Delete(id);
        }

        public bool UserControl(string Username)
        {
           return userBusiness.GetControl(x => x.UserName == Username);
        }
    }
}
