using FFImageLoading.Forms;
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
    public partial class gymworkout : ContentPage
    {
        public gymworkout()
        {
            InitializeComponent();

        }

        private async void goToChest(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new chest());
        }
        private async void goToShoulder(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new shoulder());
        }
        private async void goToArms(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new arms());
        }
        private async void goToAbdomen(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new abdomen());
        }
        private async void goToLegs(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new legs());
        }
        private async void goToBack(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new back());
        }
    }
}