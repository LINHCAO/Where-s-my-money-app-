using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views.Tab
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomeTabPage : ContentPage
    { 
		public HomeTabPage ()
		{
			InitializeComponent ();
           
		}


        private async void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new OrderPage());
        }
    }
}
