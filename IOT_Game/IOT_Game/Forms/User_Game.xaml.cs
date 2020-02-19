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
    public sealed partial class User_Game : Page
    {

		public User_Game()
        {
            this.InitializeComponent();
        }

		private void TxtQuestion_TextChanged(object sender, TextChangedEventArgs e)
		{

		}

		private async void BtnA_Click(object sender, RoutedEventArgs e)
		{
			var msg = new MessageDialog("A Şıkkı Seçildi!");
			await msg.ShowAsync();


		}

		private async void BtnB_Click(object sender, RoutedEventArgs e)
		{
			var msg = new MessageDialog("B Şıkkı Seçildi!");
			await msg.ShowAsync();
		}

		private async void BtnC_Click(object sender, RoutedEventArgs e)
		{
			var msg = new MessageDialog("C Şıkkı Seçildi!");
			await msg.ShowAsync();
		}

		private async void BtnD_Click(object sender, RoutedEventArgs e)
		{
			var msg = new MessageDialog("D Şıkkı Seçildi!");
			await msg.ShowAsync();
		}

		private void Page_Loaded(object sender, RoutedEventArgs e)
		{

		}
	}
}
