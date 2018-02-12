using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace StylesXF
{
	public partial class App : Application
	{
		public App ()
		{
            //Resources = new ResourceDictionary();

            //SetColors(Resources);

			InitializeComponent();

			MainPage = new NavigationPage(new MainPage());
		}

        private void SetColors(ResourceDictionary resources)
        {
            //resources.
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
