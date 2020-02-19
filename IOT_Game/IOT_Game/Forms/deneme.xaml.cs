using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
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
    public sealed partial class deneme : Page
    {
        public deneme()
        {
            this.InitializeComponent();
        }
		DispatcherTimer dt = new DispatcherTimer();
	

		private void Page_Loaded(object sender, RoutedEventArgs e)
		{
			dt.Interval = TimeSpan.FromSeconds(1);
			dt.Tick += Dt_Tick;
			dt.Start();
		}
		private int increment = 10;

		private void Dt_Tick(object sender, object e)
		{
			increment--;
			saniye.Text = increment.ToString();
			if (increment < 5)
			{
				saniye.Foreground = new SolidColorBrush(Colors.Red);

			}
			if (increment == 0)
			{
				dt.Stop();
			}
		}

		private void Btndeneme_Click(object sender, RoutedEventArgs e)
		{
			dt.Stop();
			
		}

		private void BtnOyna_Click(object sender, RoutedEventArgs e)
		{
			
		}
	}
}
