using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using App3.Droid;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(BatteryImplementation))]
namespace App3.Droid
{
    public class BatteryImplementation : IBatteryInfo
    {
        public bool CheckIsEnableBatteryOptimizations()
        {

            PowerManager pm = (PowerManager)Android.App.Application.Context.GetSystemService(Context.PowerService);
            //enter you package name of your application
            bool result = pm.IsIgnoringBatteryOptimizations("com.companyname.OpenBatteryDemo");
            return result;
        }

        public void StartSetting()
        {
            Intent intent = new Intent();

            intent.SetAction(Android.Provider.Settings.ActionIgnoreBatteryOptimizationSettings);
            Forms.Context.StartActivity(intent);
            // StartActivity(intent);
        }
    }
}