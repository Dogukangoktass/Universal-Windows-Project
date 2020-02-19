using IOT_Game.GameServiceReference;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace IOT_Game.Forms
{
    public sealed partial class Questions : Page
    {
        GameServiceClient client = new GameServiceClient();
        List<Category> categoryList = new List<Category>();
        //List<Option> categoryList = new List<Option>();
   
            

        public Questions()
        {
            this.InitializeComponent();
            var categories = new ObservableCollection<Category>();
            categories = client.GetCategoryAsync().Result;
            foreach (var item in categories)
            {
                QuestionCategory.Items.Add(item.CategoryName);
            
            }

        }


        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
