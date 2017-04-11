using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.ViewModels;
using Xamarin.Forms;

namespace App1
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
		    InitializeComponent();
            NavigationPage.SetHasNavigationBar(this,false);
            BindingContext = new SignInViewModel(this.Navigation);
            
		}

	    private async void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
	    {
            await Navigation.PushAsync(new SignUpPage());
           
        }
	}
}
