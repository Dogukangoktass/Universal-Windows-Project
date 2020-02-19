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
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdminTransactions : Page
    {
        GameServiceClient client = new GameServiceClient();
        List<User> userList = new List<User>();
        public AdminTransactions()
        {         
            this.InitializeComponent();
            var user = new ObservableCollection<User>();
            user = client.GetUsersAsync().Result;
            foreach (var item in user)
            {
                userList.Add(item);
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
