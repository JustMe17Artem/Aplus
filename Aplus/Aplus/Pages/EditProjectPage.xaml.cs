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
    public partial class EditProjectPage : ContentPage
    {
        public EditProjectPage()
        {
            InitializeComponent();
        }

        private async void BtnEditProject_Clicked(object sender, EventArgs e)
        {
            var project = (Project)BindingContext;
            if (await DisplayAlert(" ", $"Вы хотите изменить {project.Name}?", "Изменить", "Отмена"))
            {
                if (!String.IsNullOrEmpty(project.Name))
                {
                    App.Db.SaveItem(project);
                }
                await this.Navigation.PopAsync();
            }
        }

        

        private async void DeleteProject_Clicked(object sender, EventArgs e)
        {
            var project = (Project)BindingContext;
            if (await DisplayAlert(" ", $"Вы хотите удалить {project.Name}?", "Удалить", "Отмена"))
            {
                App.Db.DeleteItem(project.Id);
                await Navigation.PushAsync(new ProjectsPage());
            }
        }

        private void BtnCancel_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}