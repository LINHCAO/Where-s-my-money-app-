using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SignUpPage : ContentPage
	{
		public SignUpPage ()
		{
		    InitializeComponent();
            BindingContext = new SignUpViewModel();
            NavigationPage.SetHasNavigationBar(this,false);
            
		}

	    private async void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
	    {
            await Navigation.PopAsync();
        }
	}
}
