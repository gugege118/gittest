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
    public partial class BeforPage1 : ContentPage
    {
        public BeforPage1()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.self.GetMsg();//.Current.MainPage = new NavigationPage(new MainPage());
            //Navigation.PushAsync(new BeforPage2());
        }
    }
}