using healthfitness.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace healthfitness
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class dietplan : ContentPage
	{
		public dietplan ()
		{
			InitializeComponent ();
		}
        public async void myDietPlan(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new mydietPlan());
        }
        public async void allDietPlan(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new mydietPlan());
        }

    }
}