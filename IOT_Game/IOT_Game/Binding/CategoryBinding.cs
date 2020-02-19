using IOT_Game.GameServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOT_Game.Binding
{
   public class CategoryBinding
    {
        
        private int CategoryId_;

        public int CategoryId
        {
            get { return CategoryId_; }
            set { CategoryId_ = value; }
        }
        private string CategoryName_;

        public string CategoryName
        {
            get { return CategoryName_; }
            set { CategoryName_ = value; }
        }

        public CategoryBinding()
        {
          
        }

    }
}
