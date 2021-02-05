using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Model;
using WebApp.Service;

namespace WebApp.Pages
{
    public class GetApiDataModel : PageModel
    {
        public IEnumerable<WeatherDataModel> Data { get; private set; } = new List<WeatherDataModel>();

        IWeatherDataService Service { get; }

        public GetApiDataModel(IWeatherDataService service)
        {
            Service = service;
        }
        public async Task OnGet()
        {
            Data = await Service.GetWeatherData();
        }
    }
}
