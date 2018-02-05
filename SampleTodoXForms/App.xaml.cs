using System;

using Xamarin.Forms;

namespace SampleTodoXForms
{
    public partial class App : Application
    {
        public static bool UseMockDataStore = true;
        public static string BackendUrl = "https://localhost:5000";

        public App()
        {
            InitializeComponent();

            SetMainPage();
            /*
                        if (UseMockDataStore)
                            DependencyService.Register<MockDataStore>();
                        else
                            DependencyService.Register<CloudDataStore>();

                        if (Device.RuntimePlatform == Device.iOS)
                            MainPage = new MainPage();
                        else
                            MainPage = new NavigationPage(new MainPage());
            */
        }

        /// <summary>
        /// aaaaaaaaaa
        /// </summary>
        public static void SetMainPage()
        {
            Current.MainPage = new NavigationPage(new Views.MainPage());
        }
    }
}
