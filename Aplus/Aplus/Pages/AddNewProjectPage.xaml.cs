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
    public partial class AddNewProjectPage : ContentPage
    {
        public AddNewProjectPage()
        {
            InitializeComponent();
        }

        private async void BtnAddProject_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Подтвердить действие", $"Вы точно хотите добавить {ProjectName.Text}?", "Да", "Нет");
            if (result == true)
            {
                Project project = new Project();
                project.Name = ProjectName.Text;
                project.Description = EDDescription.Text;
                project.Email = EEmail.Text;
                project.Phone = EPhoneOne.Text;
                project.Address = EAddress.Text;
                App.Db.SaveItem(project);
                await Navigation.PopAsync();
            }
        }

        private async void BtnCancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}