using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wheather
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Bootstrapper.Init();
            NavigationHelper.Current.SetRootView("MainView", true);

            MainPage = new NavigationPage(new MainView());

            MainPage = new MainPage();
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
