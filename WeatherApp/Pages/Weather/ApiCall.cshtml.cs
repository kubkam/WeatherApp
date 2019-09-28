using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WeatherApp.Model.WeatherModel;

namespace WeatherApp.Pages.Weather
{
    public class ApiCallModel : PageModel
    {
        private readonly IHttpClientFactory _clientFactory;

        public WeatherModel WeatherModel { get; set; }

        public string RequestContent { get; set; }

        public ApiCallModel(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public void OnGet()
        {
            
        }

        public async Task OnGetDownload()
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?q=Warsaw,PL&units=metric&lang=pl";

            var uriBuilder = new UriBuilder(url);
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query["APPID"] = "ead3d5c8c59cc58d57e31a276b4b35c01";
            uriBuilder.Query = query.ToString();
            url = uriBuilder.ToString();

            var request = new HttpRequestMessage(HttpMethod.Get,
                url);

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);


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