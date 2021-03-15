
using Xamarin.Forms;

namespace ItauClone.Views
{
    public class LoginView : ContentPage
    {
        public LoginView()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to Xamarin.Forms!" }
                }
            };
        }
    }
}