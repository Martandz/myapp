using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace healthfitness.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class mountainclimber : ContentPage
	{
		public mountainclimber ()
		{
			InitializeComponent ();
		}
        private async void getCount(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                MyLabel.Text = " " + i + " ";
                await Task.Delay(2000);
            }
        }
    }
}