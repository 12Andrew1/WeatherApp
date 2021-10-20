using System.Net.Http;
using System.Threading.Tasks;
using WeatherApp.Data.CurrentInformation;
using WeatherApp.Data.WeatherForecastInformation;

namespace WeatherApp.Data
{
    /// <summary>
    /// Class to use when calling the API.
    /// </summary>
    public class APICalls
    {

        /// <summary>
        /// Get the required information regarding the city.
        /// </summary>
        /// <param name="path">The path for the API to use.</param>
        /// <returns></returns>
        public static async Task<CityInformation> GetCityInfoAsync(string path, HttpClient client)
        {
            CityInformation cityInformation = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                cityInformation = await response.Content.ReadAsAsync<CityInformation>();
            }
            return cityInformation;
        }

        /// <summary>
        /// Get the required information regarding the cities forecast.
        /// </summary>
        /// <param name="path">The path for the API to use.</param>
        /// <returns></returns>
        public static async Task<ForecastInformation> GetForecastInfoAsync(string path, HttpClient client)
        {
            ForecastInformation forecastInfo = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                forecastInfo = await response.Content.ReadAsAsync<ForecastInformation>();
            }
            return forecastInfo;
        }
    }
}
