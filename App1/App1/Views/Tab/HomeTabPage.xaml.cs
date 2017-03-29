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

	    //public async void Order_OnClicked(object sender, EventArgs e)
	    //{
     //       await Navigation.PushAsync(new OrderPage());
     //   }
	}
}
