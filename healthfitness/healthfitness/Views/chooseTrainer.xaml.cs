using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http;
using Newtonsoft.Json;
using healthfitness.Models;
using System.Net;
using Newtonsoft.Json.Linq;

namespace healthfitness.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class chooseTrainer : ContentPage
	{
        int trainerid;
		public chooseTrainer ()
		{
			InitializeComponent ();
		}

        async public void AddTrainertoDB(object sender, EventArgs e)
        {
            //string trainer_client = "\"client_id\" : " + LoginPage.client_id + "," +
            //    "\"trainer_id\" : " + trainer_id;
            //trainer_client = "[{" + trainer_client + "}]";

            //Console.Write(trainer_client);
            //await DisplayAlert("Hey", trainer_client, "Alright");
            //var json=JObject.Parse(trainer_client);

            detailTable dt = new detailTable()
            {
                client_id = LoginPage.client_id,
                trainer_id = trainerid
            };
            var json= JsonConvert.SerializeObject(dt);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpClient clnt = new HttpClient();
            
            var result = await clnt.PostAsync("http://www.mad2code.com/fitness/tp.php", content);
            if (result.StatusCode != HttpStatusCode.Created)
            {
                await DisplayAlert("Hey", "Your trainer is updated", "Alright");
            }

            else
             await DisplayAlert("Hey", "Your trainer is not updated", "Alright");


        }


        async public void selectTrainer(object sender, EventArgs e)
        {
            await DisplayAlert("alert", Choose_Trainer.SelectedItem + " ", "oka");

            HttpClient train = new HttpClient();
            var result = await train.GetStringAsync("http://www.mad2code.com/fitness/Trainer.php");
            var trainerdata = JsonConvert.DeserializeObject<List<ExtractTrainer>>(result);
            
            string trainer_name="";
            string trainer_qualification="";
            int trainer_noc=0;
            string trainer_achivements="";
            string photo="";
            string description="";
            foreach (ExtractTrainer t in trainerdata)
            {
                if (t.trainer_name.Equals(Convert.ToString(Choose_Trainer.SelectedItem)))
                {
                    trainerid = Convert.ToInt32(t.trainer_id);
                    trainer_name = t.trainer_name;
                    photo = t.photo;
                    trainer_noc = Convert.ToInt32(t.trainer_noc);
                    trainer_qualification = t.trainer_qualification;
                    trainer_achivements = t.trainer_achivements;
                    description = t.description;

                    break;
                }

            }
            Trainer_Name.Text = trainer_name;
            Trainer_Clients.Text = Convert.ToString(trainer_noc);
            Trainer_Qualification.Text = trainer_qualification;
            Trainer_Description.Text = description;
            Trainer_Achievements.Text = trainer_achivements;
            Trainer_Description.Text = description;
            Profile.Source = photo;


        }
    }
}