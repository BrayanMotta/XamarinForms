using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntroXamarin.App.Views.NewFolder
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        //private void Register_Clicked(object sender, EventArgs e)
        //{
        //    bool required = false;
        //    if (string.IsNullOrEmpty(FirstName.Text)) 
        //    { 
        //        required = true;
        //        FirstName.BackgroundColor = Color.Red;
        //        FirstName.Opacity = 30;
        //    }

        //    if (required) 
        //    {
        //        DisplayAlert("Notify", "Fields required", "Cancel");
        //        return;
        //    }

        //    var firstName = FirstName.Text;
        //    var lastName = LastName.Text;
        //    var email = Email.Text;
        //    var telephone = long.Parse(Telephone.Text);
        //    var enrollmentDate = EnrollmentDate.Date;

        //    var message = $"Register succesful {firstName} {lastName}.";
        //    DisplayAlert("Notify",message,"Cancel");

        //    Register.BackgroundColor = Color.Black;
        //}
    }
}