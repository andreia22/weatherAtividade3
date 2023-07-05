using Autofac;
using TinyNavigationHelper.Forms;
using Wheather.Services;
using Wheather.ViewModels;
using Wheather.Views;
using Xamarin.Forms;

namespace Wheather
{
    public class Bootstrapper
    {
        public static void Init()
        {
            var navigation = new FormsNavigationHelper();
            if (Device.Idiom == TargetIdiom.Phone)
            {
                navigation.RegisterView("MainView",
                typeof(MainView_Phone));
            }
            else
            {
                navigation.RegisterView("MainView", typeof(MainView));
            }




            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<OpenWeatherMapWeatherService>().As<IWeatherService>();
            containerBuilder.RegisterType<MainViewModel>();

            var container = containerBuilder.Build();
            Resolver.Initialize(container);
        }
    }
}


