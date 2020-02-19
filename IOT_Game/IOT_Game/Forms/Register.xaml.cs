using System;
using System.Collections.Generic;
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
using IOT_Game.GameServiceReference;
using Windows.UI.Popups;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace IOT_Game.Forms
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Register : Page
    {
        public Register()
        {
            this.InitializeComponent();
        }
        GameServiceClient client = new GameServiceClient();
        
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Login));
        }

        private async void BtnRegisterr_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text) && string.IsNullOrEmpty(txtLastName.Text) && string.IsNullOrEmpty(txtUsername.Text) && string.IsNullOrEmpty(txtPassword.Password) && string.IsNullOrEmpty(txtEmail.Text) && string.IsNullOrEmpty(txtPhoneNumber.Text) && string.IsNullOrEmpty(txtTcNo.Text))
            {
                var error = new MessageDialog("Eksik Veri Girdiniz.");
                await error.ShowAsync();
            }
            else
            {         
                var date = CdtDateBirth.Date;
                DateTime time = date.Value.DateTime;
                var formatedtime = time.ToString("dd.mm.yyyy");

                var username = txtUsername.Text;

                var control = client.UserControlAsync(username);
                var result = await control;
                if (result)
                {
                    var errormessage = new MessageDialog(username + " Böyle bir kullanıcı sistemde kayıtlıdır");
                    await errormessage.ShowAsync();
                }
                else
                {               
                await client.AddUserAsync(new User
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    UserName = txtUsername.Text,
                    Email = txtEmail.Text,
                    Phone = txtPhoneNumber.Text,
                    Password = txtPassword.Password,
                    DateOfBirth = Convert.ToDateTime(time.ToShortDateString()),
                    Gender = cmbGender.SelectedValue.ToString(),
                    TcNo = txtTcNo.Text,
                    City = cmbCity.SelectedValue.ToString(),
                    Job = cmbJob.SelectedValue.ToString()
                });
                var ms = new MessageDialog("Kayıt İşlemeniz Başarıyla Gerçekleşti.\n" + "Kullanıcı Adınız:" + txtUsername.Text + "\n Şifreniz: " + txtPassword.Password);
                await ms.ShowAsync();
                this.Frame.Navigate(typeof(Login));
            }
            }

        }
    
    }
}

