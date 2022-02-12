using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Aplus;
using Aplus.Pages;
using Aplus.DataBase;


namespace Aplus.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjectsPage : ContentPage
    {
        public ProjectsPage()
        {
            InitializeComponent();
        }

        private async void Selected_Project_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Project selectedProject = (Project)e.SelectedItem;
            SelectedProjectPage selectedProjectPage = new SelectedProjectPage();
            selectedProjectPage.BindingContext = selectedProject;
            await Navigation.PushAsync(selectedProjectPage);
        }
        
        private async void AddNewProject_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddNewProjectPage());
        }
        protected override void OnAppearing()
        {
            LVProjects.ItemsSource = App.Db.GetItems();
            base.OnAppearing();
        }
        
    }
}