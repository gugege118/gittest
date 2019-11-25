using Plugin.BackgroundService;
using Plugin.Geolocator;
using Plugin.Geolocator.Abstractions;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public class BackgroundService : IService
    {
        public string Name => "GeolocationService";

        private IGeolocator _geolocatorService;

        public BackgroundService()
        {
            _geolocatorService = CrossGeolocator.Current;
            StartAsync();
        }

        public async Task StartAsync()
        {
            _geolocatorService.PositionChanged += GeolocatorServiceOnPositionChanged;
            try
            {
                if (_geolocatorService.IsListening)
                    return;
                await _geolocatorService.StartListeningAsync(TimeSpan.FromSeconds(1), 0, false, new ListenerSettings()
                {
                    ActivityType = ActivityType.Other,
                    AllowBackgroundUpdates = true,
                    DeferLocationUpdates = false,
                    ListenForSignificantChanges = false,
                    PauseLocationUpdatesAutomatically = false,
                    DeferralDistanceMeters = 100,
                    DeferralTime = TimeSpan.FromSeconds(1)
                })
                    .ConfigureAwait(false);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public async Task StopAsync()
        {
            _geolocatorService.PositionChanged -= GeolocatorServiceOnPositionChanged;
            await _geolocatorService.StopListeningAsync();
        }

        private void GeolocatorServiceOnPositionChanged(object sender, PositionEventArgs e)
        {
            //nothing 
            MessagingCenter.Send<object, Position>(this, "locationMC", new Position(3.33333, 5.55555));

        }
    }
}
