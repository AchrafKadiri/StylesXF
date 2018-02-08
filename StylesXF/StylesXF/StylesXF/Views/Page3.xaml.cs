using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StylesXF.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page3 : ContentPage
	{
        bool originalStyle = true;

        public Page3 ()
		{
			InitializeComponent ();
            btn_global.Clicked += Btn_Clicked;
            btn_test.Clicked += OnButtonTestClicked;
            Resources["searchBarStyle"] = Resources["blueSearchBarStyle"];
        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }

        void OnButtonTestClicked(object sender, EventArgs e)
        {
            if (originalStyle)
            {
                Resources["searchBarStyle"] = Resources["greenSearchBarStyle"];
                originalStyle = false;
            }
            else
            {
                Resources["searchBarStyle"] = Resources["blueSearchBarStyle"];
                originalStyle = true;
            }
        }
    }
}