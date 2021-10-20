using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Http;

namespace WeatherApp.Data.Tests
{
    [TestClass]
    public class APICallsTests
    {
        /// <summary>
        /// Checks that the <see cref="APICalls.GetCityInfoAsync(string, HttpClient)"/> returns the expected values.
        /// </summary>
        [TestMethod]
        public void GetCityInfoAsyncTest()
        {
            var client = new HttpClient()
            {
                BaseAddress = new Uri("http://api.weatherapi.com/v1/")
            };

            var result = APICalls.GetCityInfoAsync("http://api.weatherapi.com/v1/current.json?key=f74e3fef175c44e3879104750211910&q=London&aqi=no", client);

            Assert.AreEqual("United Kingdom", result.Result.Location.Country);
            Assert.AreEqual("51.52", result.Result.Location.Lat.ToString());
            Assert.AreEqual("-0.11", result.Result.Location.Lon.ToString());
            Assert.AreEqual("London", result.Result.Location.Name);
            Assert.AreEqual("Europe/London", result.Result.Location.Tz_Id);
            Assert.AreEqual("City of London, Greater London", result.Result.Location.Region);
        }
    }
}