using StageCrew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace StageCrew.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateAccountPage : ContentPage
    {
        public CreateAccountPage()
        {
            InitializeComponent();
        }

        private void SubmitButtonClicked(object sender, EventArgs e)
        {
            if (username.Text == null)
            {
                DisplayAlert("Error", "Username field not completed", "Okay");
             
                return;
            }
            else if (password.Text == null)
            {
                DisplayAlert("Error", "Password field not completed", "Okay");
              
                return;

            }

            //if all the info works
            User user = new User(username.Text, password.Text);


           // App.UserDatabase.SaveUser(user);


             Navigation.PopAsync(); // pop this page off the stack
            Navigation.PopAsync(); // pop the main sign in page off the stack


            Navigation.PushAsync(new HomeScreen()); //push a new homescreen onto the stack

        }







    }
}