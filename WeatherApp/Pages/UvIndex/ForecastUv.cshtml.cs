using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WeatherApp.Model.UvIndexModel;

namespace WeatherApp.Pages.UvIndex
{
    public class ForecastUvModel : PageModel
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpClientFactory _clientFactory;

        public List<UvIndexModel> ForecastUvIndex { get; set; }
        public string RequestContent { get; set; }

        public ForecastUvModel(IConfiguration configuration, IHttpClientFactory clientFactory)
        {
            _configuration = configuration;
            _clientFactory = clientFactory;
        }

        public async Task<IActionResult> OnGet(float lat, float lon)
        {
            var apiKey = _configuration.GetSection("ApiKey").Value;

            string url = $"http://api.openweathermap.org/data/2.5/uvi/forecast?";

            var uriBuilder = new UriBuilder(url);
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query["lat"] = lat.ToString("F");
            query["lon"] = lon.ToString("F");
            query["appid"] = apiKey;
            uriBuilder.Query = query.ToString();
            url = uriBuilder.ToString();

            var client = _clientFactory.CreateClient();
            var response = await client.GetAsync(new Uri(url));


            if (response.IsSuccessStatusCode)
            {
                RequestContent = await response.Content.ReadAsStringAsync();

                JArray requestObject = JArray.Parse(RequestContent);
                var value = requestObject.ToString(Formatting.None);

                ForecastUvIndex = JsonConvert.DeserializeObject<List<UvIndexModel>>(value);

                return Page();
            }
            else
            {
                return RedirectToPage("../Shared/NotFound");
            }

        }
    }
}