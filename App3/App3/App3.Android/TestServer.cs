using System;
using System.Threading;
using System.Threading.Tasks;
using Plugin.BackgroundService;
using Xamarin.Forms;

namespace App3.Droid
{
    internal class TestServer : IPeriodicService
    {
        public TestServer()
        {
            StartAsync();
        }
        public string Name => "test";

        public Task PeriodicActionAsync(CancellationToken cancellationToken)
        {
            T();
            return Task.CompletedTask;
        }

        public Task StartAsync()
        {
            CrossBackgroundService.Current.StartService();
            return Task.CompletedTask;
        }

        public Task StopAsync()
        {
            return Task.CompletedTask;
        }
        public void T()
        {
            Device.StartTimer(new TimeSpan(0,0,3),()=> {
                CrossBackgroundService.Current.UpdateNotificationMessage(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                return true;
            });
        }
    }
}