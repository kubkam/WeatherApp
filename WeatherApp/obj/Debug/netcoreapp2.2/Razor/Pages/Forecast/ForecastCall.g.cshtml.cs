#pragma checksum "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Forecast\ForecastCall.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b0819fb0d2020c4e3a1743c26a584e69bdbf4e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WeatherApp.Pages.Forecast.Pages_Forecast_ForecastCall), @"mvc.1.0.razor-page", @"/Pages/Forecast/ForecastCall.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Forecast/ForecastCall.cshtml", typeof(WeatherApp.Pages.Forecast.Pages_Forecast_ForecastCall), null)]
namespace WeatherApp.Pages.Forecast
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\_ViewImports.cshtml"
using WeatherApp;

#line default
#line hidden
#line 2 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Forecast\ForecastCall.cshtml"
using WeatherApp.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b0819fb0d2020c4e3a1743c26a584e69bdbf4e5", @"/Pages/Forecast/ForecastCall.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cd955c26d134cedaf7e39989b096faf5ce966f9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Forecast_ForecastCall : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "ForecastCall", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Download", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Forecast\ForecastCall.cshtml"
  
	ViewData["Title"] = "Forecast";

#line default
#line hidden
            BeginContext(125, 23, true);
            WriteLiteral("\r\n<h1>Forecast</h1>\r\n\r\n");
            EndContext();
            BeginContext(148, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b0819fb0d2020c4e3a1743c26a584e69bdbf4e54453", async() => {
                BeginContext(227, 13, true);
                WriteLiteral("Download Data");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(244, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 12 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Forecast\ForecastCall.cshtml"
 if (Model.RequestContent != null)
{

#line default
#line hidden
            BeginContext(287, 48, true);
            WriteLiteral("\t<ul class=\"list-inline\">\r\n\t\t<li><b>Forecast in ");
            EndContext();
            BeginContext(336, 29, false);
#line 15 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Forecast\ForecastCall.cshtml"
                      Write(Model.ForecastModel.city.name);

#line default
#line hidden
            EndContext();
            BeginContext(365, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(368, 32, false);
#line 15 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Forecast\ForecastCall.cshtml"
                                                      Write(Model.ForecastModel.city.country);

#line default
#line hidden
            EndContext();
            BeginContext(400, 30, true);
            WriteLiteral("</b></li>\r\n\t\t<li>Coordinate: [");
            EndContext();
            BeginContext(431, 34, false);
#line 16 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Forecast\ForecastCall.cshtml"
                    Write(Model.ForecastModel.city.coord.lon);

#line default
#line hidden
            EndContext();
            BeginContext(465, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(468, 34, false);
#line 16 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Forecast\ForecastCall.cshtml"
                                                         Write(Model.ForecastModel.city.coord.lat);

#line default
#line hidden
            EndContext();
            BeginContext(502, 36, true);
            WriteLiteral("]</li>\r\n\t\t<li>Time of last refresh: ");
            EndContext();
            BeginContext(539, 34, false);
#line 17 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Forecast\ForecastCall.cshtml"
                             Write(Model.ForecastModel.list[0].dt_txt);

#line default
#line hidden
            EndContext();
            BeginContext(573, 200, true);
            WriteLiteral("</li>\r\n\t</ul>\r\n\t<table class=\"table table-striped table-bordered\">\r\n\t\t<thead>\r\n\t\t\t<tr>\r\n\t\t\t\t<th>Date</th>\r\n\t\t\t\t<th>Temperature</th>\r\n\t\t\t\t<th>Weather description</th>\r\n\t\t\t</tr>\r\n\t\t</thead>\r\n\t\t<tbody>\r\n");
            EndContext();
#line 28 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Forecast\ForecastCall.cshtml"
             foreach (var f in Model.ForecastModel.list)
			{
				foreach (var w in f.weather)
				{

#line default
#line hidden
            BeginContext(869, 30, true);
            WriteLiteral("\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<th>\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(900, 47, false);
#line 34 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Forecast\ForecastCall.cshtml"
                       Write(Weather.UnixTimeStampToDateTime(f.dt).DayOfWeek);

#line default
#line hidden
            EndContext();
            BeginContext(947, 8, true);
            WriteLiteral("\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(956, 41, false);
#line 35 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Forecast\ForecastCall.cshtml"
                   Write(Weather.UnixTimeStampToDateTime(f.dt).Day);

#line default
#line hidden
            EndContext();
            BeginContext(997, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(999, 43, false);
#line 35 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Forecast\ForecastCall.cshtml"
                                                              Write(Weather.UnixTimeStampToDateTime(f.dt).Month);

#line default
#line hidden
            EndContext();
            BeginContext(1042, 8, true);
            WriteLiteral("\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(1051, 42, false);
#line 36 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Forecast\ForecastCall.cshtml"
                   Write(Weather.UnixTimeStampToDateTime(f.dt).Hour);

#line default
#line hidden
            EndContext();
            BeginContext(1093, 26, true);
            WriteLiteral(":00\r\n\t\t\t\t\t</th>\r\n\t\t\t\t\t<th>");
            EndContext();
            BeginContext(1120, 11, false);
#line 38 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Forecast\ForecastCall.cshtml"
                   Write(f.main.temp);

#line default
#line hidden
            EndContext();
            BeginContext(1131, 24, true);
            WriteLiteral(" &#8451;</th>\r\n\t\t\t\t\t<th>");
            EndContext();
            BeginContext(1156, 13, false);
#line 39 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Forecast\ForecastCall.cshtml"
                   Write(w.description);

#line default
#line hidden
            EndContext();
            BeginContext(1169, 18, true);
            WriteLiteral("</th>\r\n\t\t\t\t</tr>\r\n");
            EndContext();
#line 41 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Forecast\ForecastCall.cshtml"
			}

		}

#line default
#line hidden
            BeginContext(1200, 23, true);
            WriteLiteral("\t\t</tbody>\r\n\t</table>\r\n");
            EndContext();
#line 46 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Forecast\ForecastCall.cshtml"
}

#line default
#line hidden
            BeginContext(1226, 2, true);
            WriteLiteral("\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WeatherApp.Pages.Forecast.ForecastCallModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WeatherApp.Pages.Forecast.ForecastCallModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WeatherApp.Pages.Forecast.ForecastCallModel>)PageContext?.ViewData;
        public WeatherApp.Pages.Forecast.ForecastCallModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
