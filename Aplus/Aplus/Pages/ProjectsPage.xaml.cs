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
    public partial class ProjectsPage : ContentPage
    {
        public List<string> ProjectsList { get; set; }
        public ProjectsPage()
        {
            InitializeComponent();
            ProjectsList = new List<string>();
            FillList();
            BindingContext = this;
        }

        private void Selected_Project_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
        public void FillList()
        {
            for (int i = 0; i < 18; i++)
            {
                ProjectsList.Add($"Проект {i + 1}");
            }
        }

        private void AddNewProject_Clicked(object sender, EventArgs e)
        {

        }
    }
}