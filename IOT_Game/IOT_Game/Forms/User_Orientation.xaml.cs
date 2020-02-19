using IOT_Game.GameServiceReference;
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



namespace IOT_Game.Forms
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class User_Orientation : Page
	{
        User _user;
		public User_Orientation(User user)
		{
			this.InitializeComponent();
            _user = user;
		}

		private void MenuBtn_Click(object sender, RoutedEventArgs e)
		{
			this.MySplitView.IsPaneOpen = this.MySplitView.IsPaneOpen ? false : true;
		}
		private void RdBtnItem_Click(object sender, RoutedEventArgs e)
		{
			var radioButton = sender as RadioButton;
			if (radioButton!=null)
			{
				switch (radioButton.Tag.ToString())
				{
					case "KullaniciBilgileri":
						MainFrame.Navigate(typeof(User_information),_user); 
						break;

					case "Oyna":
						MainFrame.Navigate(typeof(User_Game));
						break;
					case "Siralamalar":
						MainFrame.Navigate(typeof(UserRank));
						break;

				}
			}
		}

		private void btnQuestion(object sender, RoutedEventArgs e)
		{
			MainFrame.Navigate(typeof(Questions));
		}

		private void RadioButton_Click(object sender, RoutedEventArgs e)
		{

		}

		private void RdBtnGuvenliCikis_Click(object sender, RoutedEventArgs e)
		{
		   
		}
	}
}
