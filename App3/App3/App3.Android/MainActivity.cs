using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Plugin.BackgroundService;
using Plugin.BackgroundService.Platforms.Android;
using Xamarin.Forms;

namespace App3.Droid
{
    [Activity(Label = "App3", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : ActivityWithBackgroundService //global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity// 
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            //if (DependencyService.Get<IBatteryInfo>().CheckIsEnableBatteryOptimizations())
            //{


            //}
            //else
            //{

            //    Android.App.AlertDialog.Builder dialog = new AlertDialog.Builder(this);
            //    AlertDialog alert = dialog.Create();
            //    alert.SetTitle("Title");
            //    alert.SetMessage("Complex Alert"); 
            //    alert.SetButton("OK", (c, ev) =>
            //    {
            //        // Ok button click task  
            //        DependencyService.Get<IBatteryInfo>().StartSetting();
            //    });
            //   // alert.SetButton2("CANCEL", (c, ev) => { });
            //    alert.Show();
 

            //}


            var builder = new AndroidBackgroundServiceHostBuilder();
            builder
                .WithAndroidServiceName("YOUR_SERVICE_NAME")
                .WithNotification(
                    $"{Application.PackageName}.YOUR_SERVICE_NAME",
                    $"{Application.PackageName}.YOUR_SERVICE_NAME",
                    NotificationImportance.Low,
                    NotificationVisibility.Public,
                    Resource.Drawable.ic_media_play_light, // replace with your own icon. This is mandatory, otherwise the notification is not displayed correctly
                    "SERVICE NOTIFICATION TITLE",
                    "SERVICE NOTIFICATION CONTENT")
                .WithAppContext(this)
                .WithIntentLaunchType<MainActivity>()
                //.WithPeriodicBackgroundService(new TestServer(),new TimeSpan(0,0,3))
                .WithBackgroundService(new BackgroundService());

            NativeBackgroundServiceHost.Init(builder);


            LoadApplication(new App());
        }
        protected override bool AskForBatteryOptimizations
        {
            get
            {
#if DEBUG
                return false;
#else
                return true;
#endif
            }
        }
    }

}
