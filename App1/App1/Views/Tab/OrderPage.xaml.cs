using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views.Tab
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OrderPage : ContentPage
	{
		public OrderPage ()
		{
			InitializeComponent ();
           

            MainPicker.Items.Add("Shopping");
            MainPicker.Items.Add("Travel");
            MainPicker.Items.Add("Food");
		}

	   private void VisualElement_OnFocused(object sender, FocusEventArgs e)
	    {
	        BView.BackgroundColor = Color.Blue;
	    }

	    
	}
}
