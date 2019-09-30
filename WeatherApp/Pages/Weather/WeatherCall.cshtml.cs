using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WeatherApp.Model.WeatherModel;

namespace WeatherApp.Pages.Weather
{
    public class WeatherCallModel : PageModel
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly IConfiguration _configuration;

        public WeatherModel WeatherModel { get; set; }

        public string RequestContent { get; set; }

        public WeatherCallModel(IHttpClientFactory clientFactory, IConfiguration configuration)
        {
            _clientFactory = clientFactory;
            _configuration = configuration;
        }

        public void OnGet()
        {
            
        }

        public async Task OnGetDownload()
        {
            var apiKey = _configuration.GetSection("ApiKey").Value;

            string url = "https://api.openweathermap.org/data/2.5/weather?q=Warsaw,PL&units=metric&lang=pl";

            var uriBuilder = new UriBuilder(url);
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query["APPID"] = apiKey;
            uriBuilder.Query = query.ToString();
            url = uriBuilder.ToString();

            var client = _clientFactory.CreateClient();
            var response = await client.GetAsync(new Uri(url));


            if (response.IsSuccessStatusCode)
            {
                RequestContent = await response.Content.ReadAsStringAsync();

                JObject requestObject = JObject.Parse(RequestContent);
                var value = requestObject.ToString(Formatting.None);

                WeatherModel = JsonConvert.DeserializeObject<WeatherModel>(value);
            }
            else
            {
                Response.Redirect("../Shared/NotFound");
            }
        }
    }
}