#pragma checksum "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Weather\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c7deafdd7cb586872fe1e7b299f6eb56e61bd7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WeatherApp.Pages.Weather.Pages_Weather_Details), @"mvc.1.0.razor-page", @"/Pages/Weather/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Weather/Details.cshtml", typeof(WeatherApp.Pages.Weather.Pages_Weather_Details), @"{cityId:int}")]
namespace WeatherApp.Pages.Weather
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
#line 2 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Weather\Details.cshtml"
using WeatherApp.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{cityId:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c7deafdd7cb586872fe1e7b299f6eb56e61bd7a", @"/Pages/Weather/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cd955c26d134cedaf7e39989b096faf5ce966f9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Weather_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables/js/jquery.dataTables.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables/js/dataTables.bootstrap4.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables/css/dataTables.bootstrap4.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("include", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("exclude", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Weather\Details.cshtml"
  
	ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(133, 22, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n");
            EndContext();
#line 10 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Weather\Details.cshtml"
 if (Model.RequestContent != null)
{

#line default
#line hidden
            BeginContext(194, 47, true);
            WriteLiteral("\t<ul class=\"list-inline\">\r\n\t\t<li><b>Weather in ");
            EndContext();
            BeginContext(242, 23, false);
#line 13 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Weather\Details.cshtml"
                     Write(Model.WeatherModel.name);

#line default
#line hidden
            EndContext();
            BeginContext(265, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(268, 30, false);
#line 13 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Weather\Details.cshtml"
                                               Write(Model.WeatherModel.sys.country);

#line default
#line hidden
            EndContext();
            BeginContext(298, 31, true);
            WriteLiteral("</b></li>\r\n\t\t<li>Coordinates: [");
            EndContext();
            BeginContext(330, 28, false);
#line 14 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Weather\Details.cshtml"
                     Write(Model.WeatherModel.coord.lat);

#line default
#line hidden
            EndContext();
            BeginContext(358, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(361, 28, false);
#line 14 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Weather\Details.cshtml"
                                                    Write(Model.WeatherModel.coord.lon);

#line default
#line hidden
            EndContext();
            BeginContext(389, 14, true);
            WriteLiteral("]</li>\r\n\t\t<li>");
            EndContext();
            BeginContext(404, 54, false);
#line 15 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Weather\Details.cshtml"
       Write(Weather.UnixTimeStampToDateTime(Model.WeatherModel.dt));

#line default
#line hidden
            EndContext();
            BeginContext(458, 269, true);
            WriteLiteral(@"</li>
	</ul>
	<table id=""model"" class=""table table-striped table-bordered display"" style=""width:100%"">
		<thead>
			<tr>
				<th>Temperature</th>
				<th>Clouds</th>
				<th>Humidity</th>
				<th>Pressure</th>
			</tr>
		</thead>
		<tbody>
			<tr>
				<td>");
            EndContext();
            BeginContext(728, 28, false);
#line 28 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Weather\Details.cshtml"
               Write(Model.WeatherModel.main.temp);

#line default
#line hidden
            EndContext();
            BeginContext(756, 23, true);
            WriteLiteral(" &#8451;</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(780, 41, false);
#line 29 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Weather\Details.cshtml"
               Write(Model.WeatherModel.weather[0].description);

#line default
#line hidden
            EndContext();
            BeginContext(821, 15, true);
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(837, 32, false);
#line 30 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Weather\Details.cshtml"
               Write(Model.WeatherModel.main.humidity);

#line default
#line hidden
            EndContext();
            BeginContext(869, 17, true);
            WriteLiteral(" %</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(887, 32, false);
#line 31 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Weather\Details.cshtml"
               Write(Model.WeatherModel.main.pressure);

#line default
#line hidden
            EndContext();
            BeginContext(919, 44, true);
            WriteLiteral(" hPa</td>\r\n\t\t\t</tr>\r\n\t\t</tbody>\r\n\t</table>\r\n");
            EndContext();
#line 35 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Weather\Details.cshtml"
}

#line default
#line hidden
            BeginContext(966, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(988, 3, true);
                WriteLiteral("\r\n\t");
                EndContext();
                BeginContext(991, 275, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c7deafdd7cb586872fe1e7b299f6eb56e61bd7a10215", async() => {
                    BeginContext(1026, 4, true);
                    WriteLiteral("\r\n\t\t");
                    EndContext();
                    BeginContext(1030, 64, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c7deafdd7cb586872fe1e7b299f6eb56e61bd7a10630", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1094, 4, true);
                    WriteLiteral("\r\n\t\t");
                    EndContext();
                    BeginContext(1098, 68, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c7deafdd7cb586872fe1e7b299f6eb56e61bd7a11958", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1166, 4, true);
                    WriteLiteral("\r\n\t\t");
                    EndContext();
                    BeginContext(1170, 79, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6c7deafdd7cb586872fe1e7b299f6eb56e61bd7a13286", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1249, 3, true);
                    WriteLiteral("\r\n\t");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Include = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1266, 3, true);
                WriteLiteral("\r\n\t");
                EndContext();
                BeginContext(1269, 279, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c7deafdd7cb586872fe1e7b299f6eb56e61bd7a15777", async() => {
                    BeginContext(1304, 230, true);
                    WriteLiteral("\r\n\t\t<link rel=\"stylesheet\" type=\"text/css\" href=\"https://cdn.datatables.net/w/bs4/dt-1.10.18/datatables.min.css\" />\r\n\t\t<script type=\"text/javascript\" src=\"https://cdn.datatables.net/w/bs4/dt-1.10.18/datatables.min.js\"></script>\r\n\t");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Exclude = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1548, 246, true);
                WriteLiteral("\r\n\r\n\t<script>\r\n\t\t$(document).ready(function () {\r\n\t\t\t$(\'#model\').DataTable({\r\n\t\t\t\t\"processing\": true,\r\n\t\t\t\t\"searching\": false,\r\n\t\t\t\t\"scrollX\": true,\r\n\t\t\t\t\"paging\": false,\r\n\t\t\t\t\"info\": false,\r\n\t\t\t\t\"ordering\": false\r\n\t\t\t});\r\n\t\t}\r\n\t\t);\r\n\t</script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WeatherApp.Pages.Weather.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WeatherApp.Pages.Weather.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WeatherApp.Pages.Weather.DetailsModel>)PageContext?.ViewData;
        public WeatherApp.Pages.Weather.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
