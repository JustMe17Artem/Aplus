using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplus.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthoPage : ContentPage
    {
        public AuthoPage()
        {
            InitializeComponent();
        }
        private async void Login_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProjectsPage());
        }

        private async void Reg_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegPage());
        }
    }
}