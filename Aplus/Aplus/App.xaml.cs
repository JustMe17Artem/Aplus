using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Aplus.DataBase;
using System.IO;

namespace Aplus
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "Project.db";
        internal static ProjectsStorage db;
        internal static ProjectsStorage Db
        {
            get
            {
                if (db == null)
                {
                    db = new ProjectsStorage(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return db;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Pages.AuthoPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
