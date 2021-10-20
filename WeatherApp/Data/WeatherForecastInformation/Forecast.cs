using System.Collections.Generic;

namespace WeatherApp.Data.WeatherForecastInformation
{
    public class Forecast
    {
        public List<ForecastDay> ForecastDay { get; set; } = new List<ForecastDay>();
    }

    public class ForecastDay
    {
        public List<Hour> Hour { get; set; } = new List<Hour>();
    }

    public class Hour
    {
        public string Time { get; set; }
        public Condition Condition { get; set; }
    }

    public class Condition
    {
        public string Text { get; set; }
    }
}
