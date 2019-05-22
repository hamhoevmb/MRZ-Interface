using MrzApp.Data;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MrzApp.View
{
    public partial class App : Application
    {
        static MrzItemDatabase database;

        public App()
        {
            // Initialize Live Reload.
#if DEBUG
            HotReloader.Current.Start(this);
#endif

            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public static MrzItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new MrzItemDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TodoSQLite.db3"));
                }
                return database;
            }
        }

        public int ResumeAtTodoId { get; set; }
    }
}
