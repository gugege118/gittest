using Plugin.Geolocator.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<string> Items = new ObservableCollection<string>();
        public MainPage()
        {
            InitializeComponent();
            listv.ItemsSource = Items;
            MessagingCenter.Subscribe<object, Position>(this, "locationMC", (sender, item) =>
            {
                Items.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                var lk = 12l;

            });
            T();
        }
        public async Task T()
        {
            if (Device.Android == Device.RuntimePlatform)
            {
               
            } 
    }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BeforPage1());
        }
    }
}
