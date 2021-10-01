using Newtonsoft.Json;
using RestSharp;
using WeatherApp.API.Models;

namespace WeatherApp.API.Handlers
{
    public class GeolocationHandler
    {
        public async static Task<GeolocationResponse> HandleVisitorGeolocation()
        {
            var client = new RestClient("https://find-any-ip-address-or-domain-location-world-wide.p.rapidapi.com/iplocation?apikey=873dbe322aea47f89dcf729dcc8f60e8");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "find-any-ip-address-or-domain-location-world-wide.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "e4632e026fmsh22c0771086f2801p1e355djsn8d166deec3dc");
            IRestResponse response = client.Execute(request);

            var geolocation = JsonConvert.DeserializeObject<GeolocationResponse>(response.Content);
            
            return geolocation;  
        }
    }
}
