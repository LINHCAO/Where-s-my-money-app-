using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App1.Views;
using App1.Views.Tab;
using Xamarin.Forms;

namespace App1
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new TabPage();

		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
