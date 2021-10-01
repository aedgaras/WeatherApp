﻿namespace WeatherApp.API.Models
{
    public class GeolocationResponse
    {
        public string? Continent { get; set; }
        public string? Country { get; set; }
        public string? ZipCode { get; set; }
        public int accuracyRadius { get; set; }
        public string flag { get; set; }
        public string city { get; set; }
        public string timezone { get; set; }
        public float latitude { get; set; }
        public int countryGeoNameId { get; set; }
        public string gmt { get; set; }
        public string network { get; set; }
        public string currencyName { get; set; }
        public string countryNativeName { get; set; }
        public int stateGeoNameId { get; set; }
        public string phoneCode { get; set; }
        public string state { get; set; }
        public string continentCode { get; set; }
        public float longitude { get; set; }
        public string currencyNamePlural { get; set; }
        public int cityGeoNameId { get; set; }
        public string languages { get; set; }
        public int numOfCities { get; set; }
        public string org { get; set; }
        public string ip { get; set; }
        public string currencySymbol { get; set; }
        public string currencySymbolNative { get; set; }
        public string isEU { get; set; }
        public string? CountryTLD { get; set; }
        public string? CountryCapital { get; set; }
        public object? MetroCode { get; set; }
        public int continentGeoNameId { get; set; }
        public string stateCode { get; set; }
        public string countryISO2 { get; set; }
        public int numOfStates { get; set; }
        public string countryISO3 { get; set; }
        public string currencyCode { get; set; }
        public int asNo { get; set; }
        public int status { get; set; }
    }
}
