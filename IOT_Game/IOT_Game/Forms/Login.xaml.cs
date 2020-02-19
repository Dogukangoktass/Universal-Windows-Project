using IOT_Game.GameServiceReference;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class Login : Page
    {
        public Login()
        {
            this.InitializeComponent();
        }
        GameServiceReference.GameServiceClient client = new GameServiceReference.GameServiceClient();
        private async void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPassword.Password))
            {
                var ms = new MessageDialog("Eksik veri girişi yaptınız kontrol ediniz");
                await ms.ShowAsync();
            }
            else
            {
                var loginControl = client.LoginUserAsync(txtUser.Text, txtPassword.Password);
                if (loginControl != null)
                {
                    User user = new User
                    {
                        City = loginControl.Result.City,
                        DateOfBirth = loginControl.Result.DateOfBirth,
                        Email = loginControl.Result.Email,
                        FirstName = loginControl.Result.FirstName,
                        Gender = loginControl.Result.Gender,
                        Job = loginControl.Result.Job,
                        LastName = loginControl.Result.LastName,
                        Password = loginControl.Result.Password,
                        Phone = loginControl.Result.Phone,
                        TcNo = loginControl.Result.TcNo,
                        UserID = loginControl.Result.UserID,
                        UserName = loginControl.Result.UserName
                    };
                    
                    this.Frame.Navigate(typeof(User_Orientation));
                }
                else
                {
                    var message = new MessageDialog("Böyle bir kullanıcı bulunamadı");
                    await message.ShowAsync();
                }
            }
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Register));
        }
    }
}
