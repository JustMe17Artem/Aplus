using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Aplus.DataBase;

namespace Aplus.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectedProjectPage : TabbedPage
    {
        public SelectedProjectPage()
        {
            InitializeComponent();
        }

        private async void BtnEdit_Clicked(object sender, EventArgs e)
        {
            var project = (Project)BindingContext;
            EditProjectPage projectPage = new EditProjectPage();
            projectPage.BindingContext = project;
            await Navigation.PushAsync(projectPage);
        }
    }
}