using System;
using System.Collections.Generic;
using System.Text;
using Wheather.Services;
using Wheather.ViewModels;
using Wheather.Views;

namespace Wheather
{
    internal class Bootstrapper
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
            containerBuilder.RegisterType
            <OpenWeatherMapWeatherService>().As
            <IWeatherService>();
            containerBuilder.RegisterType<MainViewModel>();
            var container = containerBuilder.Build();
            Resolver.Initialize(container);
        }
    }

}
