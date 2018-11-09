using healthfitness.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace healthfitness.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class register : ContentPage
	{
		public register ()
		{
			InitializeComponent ();
		}
        private async void goToLogin(object sender, System.EventArgs e)
        {
            ClientD clientD = new ClientD() {
                client_name = Entry_Name.Text,
                client_password = Entry_Password.Text,
                client_email = Entry_Email.Text,
                client_phone = Phone.Text,
                client_height = Convert.ToDouble(Entry_Height.Text),
                client_weight = Convert.ToDouble(Entry_Weight.Text),
                client_country = Country.Text,
                client_state = State.Text,
                client_city = City.Text,
                client_pincode = Pincode.Text
    };
            var json = JsonConvert.SerializeObject(clientD);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpClient clnt = new HttpClient();
            var result = await clnt.PostAsync("http://www.mad2code.com/fitness/Client_Registeration.php", content);
            if (result.StatusCode == HttpStatusCode.Created) ;
            {
                await DisplayAlert("Hey", "Your record hs been added", "Alright");
                await Navigation.PushAsync(new LoginPage());
            }
        }
    }
}