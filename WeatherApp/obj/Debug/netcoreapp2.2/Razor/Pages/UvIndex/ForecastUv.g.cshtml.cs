#pragma checksum "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\UvIndex\ForecastUv.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c595521d05382cc35fc01e2f21b1a87ef787bd03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WeatherApp.Pages.UvIndex.Pages_UvIndex_ForecastUv), @"mvc.1.0.razor-page", @"/Pages/UvIndex/ForecastUv.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/UvIndex/ForecastUv.cshtml", typeof(WeatherApp.Pages.UvIndex.Pages_UvIndex_ForecastUv), @"{lat:float}/{lon:float}")]
namespace WeatherApp.Pages.UvIndex
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
#line 2 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\UvIndex\ForecastUv.cshtml"
using WeatherApp.Model.UvIndexModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{lat:float}/{lon:float}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c595521d05382cc35fc01e2f21b1a87ef787bd03", @"/Pages/UvIndex/ForecastUv.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cd955c26d134cedaf7e39989b096faf5ce966f9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_UvIndex_ForecastUv : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 4 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\UvIndex\ForecastUv.cshtml"
  
    ViewData["Title"] = "Forecast UV Index";

#line default
#line hidden
            BeginContext(173, 308, true);
            WriteLiteral(@"
<h1>Forecast UV Index</h1>

<ul class=""list-inline"">
		
</ul>
<table id=""model"" class=""table table-striped table-bordered display"" style=""width: 100%"">
	<thead>
	<tr>
		<th>Latitude</th>
		<th>Longitude</th>
		<th>Date</th>
		<th>Value</th>
		<th>Description</th>
	</tr>
	</thead>
	<tbody>
");
            EndContext();
#line 24 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\UvIndex\ForecastUv.cshtml"
         foreach (var uv in Model.ForecastUvIndex)
		{

#line default
#line hidden
            BeginContext(532, 17, true);
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(550, 6, false);
#line 27 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\UvIndex\ForecastUv.cshtml"
               Write(uv.lat);

#line default
#line hidden
            EndContext();
            BeginContext(556, 15, true);
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(572, 6, false);
#line 28 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\UvIndex\ForecastUv.cshtml"
               Write(uv.lon);

#line default
#line hidden
            EndContext();
            BeginContext(578, 15, true);
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(594, 11, false);
#line 29 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\UvIndex\ForecastUv.cshtml"
               Write(uv.date_iso);

#line default
#line hidden
            EndContext();
            BeginContext(605, 15, true);
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(621, 8, false);
#line 30 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\UvIndex\ForecastUv.cshtml"
               Write(uv.value);

#line default
#line hidden
            EndContext();
            BeginContext(629, 15, true);
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(645, 34, false);
#line 31 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\UvIndex\ForecastUv.cshtml"
               Write(UvIndexModel.Description(uv.value));

#line default
#line hidden
            EndContext();
            BeginContext(679, 17, true);
            WriteLiteral("</td>\r\n\t\t\t</tr>\r\n");
            EndContext();
#line 33 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\UvIndex\ForecastUv.cshtml"
		}

#line default
#line hidden
            BeginContext(701, 23, true);
            WriteLiteral("\t</tbody>\r\n</table>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(743, 3, true);
                WriteLiteral("\r\n\t");
                EndContext();
                BeginContext(746, 275, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c595521d05382cc35fc01e2f21b1a87ef787bd038694", async() => {
                    BeginContext(781, 4, true);
                    WriteLiteral("\r\n\t\t");
                    EndContext();
                    BeginContext(785, 64, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c595521d05382cc35fc01e2f21b1a87ef787bd039106", async() => {
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
                    BeginContext(849, 4, true);
                    WriteLiteral("\r\n\t\t");
                    EndContext();
                    BeginContext(853, 68, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c595521d05382cc35fc01e2f21b1a87ef787bd0310431", async() => {
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
                    BeginContext(921, 4, true);
                    WriteLiteral("\r\n\t\t");
                    EndContext();
                    BeginContext(925, 79, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c595521d05382cc35fc01e2f21b1a87ef787bd0311757", async() => {
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
                    BeginContext(1004, 3, true);
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
                BeginContext(1021, 3, true);
                WriteLiteral("\r\n\t");
                EndContext();
                BeginContext(1024, 279, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c595521d05382cc35fc01e2f21b1a87ef787bd0314248", async() => {
                    BeginContext(1059, 230, true);
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
                BeginContext(1303, 186, true);
                WriteLiteral("\r\n\r\n\t<script>\r\n\t\t$(document).ready(function () {\r\n\t\t\t\t$(\'#model\').DataTable({\r\n\t\t\t\t\t\"processing\": true,\r\n\t\t\t\t\t\"searching\": false,\r\n\t\t\t\t\t\"scrollX\": true\r\n\t\t\t\t});\r\n\t\t\t}\r\n\t\t);\r\n\t</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WeatherApp.Pages.UvIndex.ForecastUvModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WeatherApp.Pages.UvIndex.ForecastUvModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WeatherApp.Pages.UvIndex.ForecastUvModel>)PageContext?.ViewData;
        public WeatherApp.Pages.UvIndex.ForecastUvModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591