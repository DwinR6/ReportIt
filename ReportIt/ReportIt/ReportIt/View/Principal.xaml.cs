using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReportIt.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Principal : ContentPage
	{
		public Principal ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
		}
        private void BtnViolencia_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViolenciaView());
        }

        private void IbtnViolencia_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViolenciaView());

        }

        private void IbtnRobo_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnRobo_Clicked(object sender, EventArgs e)
        {

        }

        private void IbtnNarco_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnCorrupcion_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnNarco_Clicked(object sender, EventArgs e)
        {

        }

        private void IbtnCorrupcion_Clicked(object sender, EventArgs e)
        {

        }
    }
}