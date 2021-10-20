using System;
using System.Net.Http;
using WeatherApp.Data;
using WeatherApp.Data.CurrentInformation;
using WeatherApp.Data.WeatherForecastInformation;

namespace WeatherApp.Pages
{
    public partial class CallAPI
    {
        static HttpClient client = new HttpClient();
        private CityInformation CityLocationInfo { get; set; } = new CityInformation();
        private ForecastInformation CityForecastInfo { get; set; } = new ForecastInformation();

        public string CityName { get; set; }

        /// <summary>
        /// Make a call to the API after a city name has been entered.
        /// </summary>
        private async void CallAPIMethod()
        {
            string key = "f74e3fef175c44e3879104750211910";
            client = new HttpClient
            {
                BaseAddress = new System.Uri("http://api.weatherapi.com/v1/")
            };

            try
            {
                // Get the location info
                CityLocationInfo = await APICalls.GetCityInfoAsync($"{client.BaseAddress}current.json?key={key}&q={CityName}&aqi=no", client);

                // Get the forecast info
                CityForecastInfo = await APICalls.GetForecastInfoAsync($"{client.BaseAddress}forecast.json?key={key}&q={CityName}&days=1&aqi=no&alerts=no", client);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            StateHasChanged();
        }
    }
}
