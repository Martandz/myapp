using healthfitness.Views;
using healthfitness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace healthfitness
{
    public partial class MainPage : MasterDetailPage
    {
        public List<MenuPageItem> MenuList { get; set; }
        public MainPage()
        {
            InitializeComponent();
            MenuList = new List<MenuPageItem>();

            var Page1 = new MenuPageItem() { Title = "Home", Icon = "home.png", TargetType = typeof(MainPage) };
            var Page2 = new MenuPageItem() { Title = "Gym Workout", Icon = "gym.png", TargetType = typeof(gymworkout) };
            var Page3 = new MenuPageItem() { Title = "Home Workout", Icon = "homew.png", TargetType = typeof(homeworkout) };
            var Page4 = new MenuPageItem() { Title = "Trainers", Icon = "trainer.png", TargetType = typeof(chooseTrainer) };
            var Page5 = new MenuPageItem() { Title = "BMI Calculator", Icon = "bmi.png", TargetType = typeof(bmicalc) };
            var Page6 = new MenuPageItem() { Title = "User Stories", Icon = "userStories.png", TargetType = typeof(TrainerPage) };
            var Page7 = new MenuPageItem() { Title = "User Diet", Icon = "diet.png", TargetType = typeof(dietplan) };

            MenuList.Add(Page1);
            MenuList.Add(Page2);
            MenuList.Add(Page3);
            MenuList.Add(Page4);
            MenuList.Add(Page5);
            MenuList.Add(Page6);
            MenuList.Add(Page7);


            navigationDrawerList.ItemsSource = MenuList;
            //Detail= new NavigationPage((Page) Activator.CreateInstance(typeof(gymworkout)));

            this.BindingContext = new
            {
                Header = "",
                Image = "p.jpg",
                Footer = "Welcome to Fitness4U"
            };
            //IsPresented = false;
        }
        void onMenuItemSelected (object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MenuPageItem)e.SelectedItem;
            Type page = item.TargetType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
        void goToGymWorkout(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new gymworkout());
            IsPresented = false;
        }
        void goToHomeWorkout(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new gymworkout());
            IsPresented = false;
        }
        void goToDietplan(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new dietplan());
            IsPresented = false;
        }
        void goToProfile(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new profile());
            IsPresented = false;
        }
        private async void  goToLogout(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
        void OnTappedSelect(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new gymworkout());
            IsPresented = false;
        }
    }
}
