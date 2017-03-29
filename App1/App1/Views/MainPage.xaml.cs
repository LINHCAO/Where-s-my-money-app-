using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
		    InitializeComponent();
            
            Register.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(OnTap)
            });
		}

	    public async void OnTap()
	    {
	        await Navigation.PushAsync(new SignUpPage());
	    }

	    
	}
}
