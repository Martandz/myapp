
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace healthfitness.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrainerView : ContentView
    {


        public TrainerView()
        {
            InitializeComponent();



        }
        async private void GoToChest(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new chest());
        }
    }
}