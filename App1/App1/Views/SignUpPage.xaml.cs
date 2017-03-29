using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SignUpPage : ContentPage
	{
		public SignUpPage ()
		{
			InitializeComponent ();

            Login.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(OnTap)
            });
		}

	    public async void OnTap()
	    {
            await Navigation.PushAsync(new MainPage());
        }
	}
}
