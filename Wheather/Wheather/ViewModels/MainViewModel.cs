using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using static Wheather.Models.WeatherData;
using Wheather.Models;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Wheather.ViewModels
{
    internal class MainViewModel : ViewModel
    {
        private string city;
        public string City
        {
            get => city;
            set => Set(ref city, value);
        }
        private ObservableCollection<ForecastGroup> days;
        public ObservableCollection<ForecastGroup> Days
        {
            get => days;
            set => Set(ref days, value);
        }
        // Rest of the class is omitted for brevity

        private bool isRefreshing;
        public bool IsRefreshing
        {
            get => isRefreshing;
            set => Set(ref isRefreshing, value);
        }
        public async Task LoadData()
        {
            IsRefreshing = true;
            // The rest of the code is omitted for brevity
            IsRefreshing = false;
        }

        public ICommand Refresh => new Command(async () =>
        {
            await LoadData();
        })

    }
}