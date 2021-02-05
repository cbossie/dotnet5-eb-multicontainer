using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApp.Model;

namespace WebApp.Service
{
    public class WeatherDataService : IWeatherDataService
    {
        private ApiConfig Config { get; }

        public WeatherDataService(ApiConfig config)
        {
            Config = config;                
        }

        public async Task<IEnumerable<WeatherDataModel>> GetWeatherData()
        {
            List<WeatherDataModel> data;
            using HttpClient httpClient = new();
            var response = await httpClient.GetAsync($"{Config.ApiUrl}/WeatherForecast");
            string responseBody = await response.Content.ReadAsStringAsync();
            data = JsonConvert.DeserializeObject<List<WeatherDataModel>>(responseBody);

            return data ?? new List<WeatherDataModel>();
        }
    }
}
