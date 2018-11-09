using healthfitness.Models;
using Newtonsoft.Json;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace healthfitness.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
        public static int client_id;
		public LoginPage ()
		{
			InitializeComponent ();
            Init();

		}
        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            Lbl_Username.TextColor = Constants.MainTextColor;
            Lbl_Password.TextColor = Constants.MainTextColor;
            ActivitySpinner.IsVisible = false;
            LoginIcon.HeightRequest = Constants.LoginIconHeight;

            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => SignInProcedure(s, e);

            //MySqlConnection con = new MySqlConnection("server=localhost;port=3306;database=carrentaldatabase;userid=root;password=;");
        }
        

        private async void SignInProcedure(object sender, EventArgs e)
        {
            User user = new User(Entry_Username.Text, Entry_Password.Text);

            int count = 0;
            
            if (user.CheckInFormation())
            {
                HttpClient clnt = new HttpClient();
                var result = await clnt.GetStringAsync("http://www.mad2code.com/fitness/client_login.php");
                var clientlogindata = JsonConvert.DeserializeObject<List<clientLogin>>(result);
                foreach (clientLogin c in clientlogindata)
                {
                    if(c.client_username.Equals(Entry_Username.Text) && c.client_password.Equals(Entry_Password.Text))
                    {
                        count = 1;
                        client_id = c.client_id;
                        break;

                    }

                }
                if(count==1)
                    await Navigation.PushAsync(new MainPage());
                else
                    await DisplayAlert("login", "Login not done", "oka");

            }
            //DisplayAlert("login", "Login succesfull", "oka");
            else
                await DisplayAlert("login", "Login not done", "oka");

          
            
            
            
            

           
        }
        private async void RegisterProcedure(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new register());
        }
    }
}