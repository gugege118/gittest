using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NPage1 : ContentPage
    {
        public NPage1()
        {
            InitializeComponent();
            TAsync();
        }
        public async Task TAsync()
        {
            await Task.Delay(3000);

            App.self.MainPage = new BeforPage1();

        }
    }
}