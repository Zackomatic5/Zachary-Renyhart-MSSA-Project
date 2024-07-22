//using Android.Media;
using System.Net.Security;
using System.Reflection;
using System.Reflection.Metadata;
using Zachary_Renyhart_MSSA_Project.NewFolder;
using Zachary_Renyhart_MSSA_Project.NewFolder2;

namespace Zachary_Renyhart_MSSA_Project
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {

            string enteredEmail = Username.Text;
            string enteredPassword = Password.Text;
            

            var user = await App.Database.LoginUserAsync(enteredEmail, enteredPassword);
            if (user != null) 
            {
                
                await Navigation.PushAsync(new BaseballStats());
                LogInText.Text = "Please log in below!";
            }
            else
            {
                LogInText.Text = "You entered the wrong Username or Password!!";
                await DisplayAlert(LogInText.Text, StyleId, "Please try again!");
                
                
               
            }


        }
        private async void RegisterButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Register());
        }
    }

}
