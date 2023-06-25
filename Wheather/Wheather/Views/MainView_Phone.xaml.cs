using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wheather.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wheather.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView_Phone : ContentPage
    {
        public MainView_Phone()
        {
            InitializeComponent();
            BindingContext = Resolver.Resolve<MainViewModel>();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (BindingContext is MainViewModel viewModel)
            {
                MainThread.BeginInvokeOnMainThread(async () =>
                {
                    await viewModel.LoadData();
                });
            }
        }
    }
}