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
	public partial class homeworkout : ContentPage
	{
		public homeworkout ()
		{
			InitializeComponent ();
		}
        private async void goToPushup(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new pushups());
        }
        private async void goToBurpee(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new burpees());
        }
        private async void goToMountain(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new mountainclimber());
        }
        private async void goToSquat(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new squats());
        }
        
    }
}