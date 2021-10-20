namespace WeatherApp.Data.CurrentInformation
{
    /// <summary>
    /// Data class for the location information of a city/Postcode.
    /// </summary>
    public class Location
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public float Lat { get; set; }
        public float Lon { get; set; }
        public string Tz_Id { get; set; } // TimeZone ID
        public string LocalTime { get; set; }
    }
}
