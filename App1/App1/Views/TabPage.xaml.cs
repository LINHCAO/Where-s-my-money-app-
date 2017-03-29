using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.Content.Res;
using App1.Views.Tab;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TabPage : TabbedPage
	{
		public TabPage ()
		{
			InitializeComponent ();
            
		}
	}
}
