using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace App3
{
    public partial class App : Application
    {
        public static App self;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage()); //new TabbedPage1();
           
        }

        protected override void OnStart()
        {
            self = this;
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            var l2k = 1;
        }

        protected override void OnResume()
        {
            var lk = 1;
            // Handle when your app resumes
        }
        public async Task GetMsg(bool isFrist = false)
        {
            //判断当前导航是否是HomeTabbedPage(如果是则说明app当前显示页面是登录后的页面)
 
                    MainPage = new NavigationPage(new MainPage());
               

        }
    }
    public interface IBatteryInfo
    {
        void StartSetting();

        bool CheckIsEnableBatteryOptimizations();
    }

}
