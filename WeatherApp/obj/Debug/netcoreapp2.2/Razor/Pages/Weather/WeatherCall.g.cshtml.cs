#pragma checksum "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Weather\WeatherCall.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ba63771dfd0d28ae061966e8c0b8c8883d23092"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WeatherApp.Pages.Weather.Pages_Weather_WeatherCall), @"mvc.1.0.razor-page", @"/Pages/Weather/WeatherCall.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Weather/WeatherCall.cshtml", typeof(WeatherApp.Pages.Weather.Pages_Weather_WeatherCall), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ba63771dfd0d28ae061966e8c0b8c8883d23092", @"/Pages/Weather/WeatherCall.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cd955c26d134cedaf7e39989b096faf5ce966f9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Weather_WeatherCall : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Search by city name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Weather\WeatherCall.cshtml"
  
	ViewData["Title"] = "Weather";

#line default
#line hidden
            BeginContext(97, 22, true);
            WriteLiteral("\r\n<h1>Weather</h1>\r\n\r\n");
            EndContext();
            BeginContext(119, 317, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ba63771dfd0d28ae061966e8c0b8c8883d230925332", async() => {
                BeginContext(138, 61, true);
                WriteLiteral("\r\n\t<div class=\"form-group\">\r\n\t\t<div class=\"input-group\">\r\n\t\t\t");
                EndContext();
                BeginContext(199, 98, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0ba63771dfd0d28ae061966e8c0b8c8883d230925787", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 12 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Weather\WeatherCall.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchTerm);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(297, 132, true);
                WriteLiteral("\r\n\t\t\t<div class=\"input-group-append\">\r\n\t\t\t\t<button class=\"btn btn-outline-secondary\">Search</button>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(436, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 20 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Weather\WeatherCall.cshtml"
 if (Model.SearchTerm.Length < 3)
{

#line default
#line hidden
            BeginContext(478, 46, true);
            WriteLiteral("\t<b>City name should be min 3 characters</b>\r\n");
            EndContext();
#line 23 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Weather\WeatherCall.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(536, 194, true);
            WriteLiteral("\t<table class=\"table table-striped table-bordered\">\r\n\t\t<thead>\r\n\t\t<tr>\r\n\t\t\t<th>City name</th>\r\n\t\t\t<th>Country</th>\r\n\t\t\t<th>Coordinates</th>\r\n\t\t\t<th>Weather</th>\r\n\t\t</tr>\r\n\t\t</thead>\r\n\t\t<tbody>\r\n");
            EndContext();
#line 36 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Weather\WeatherCall.cshtml"
         foreach (var city in Model.Cities)
		{

#line default
#line hidden
            BeginContext(774, 17, true);
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(792, 9, false);
#line 39 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Weather\WeatherCall.cshtml"
               Write(city.name);

#line default
#line hidden
            EndContext();
            BeginContext(801, 15, true);
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(817, 12, false);
#line 40 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Weather\WeatherCall.cshtml"
               Write(city.country);

#line default
#line hidden
            EndContext();
            BeginContext(829, 16, true);
            WriteLiteral("</td>\r\n\t\t\t\t<td>[");
            EndContext();
            BeginContext(846, 14, false);
#line 41 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Weather\WeatherCall.cshtml"
                Write(city.coord.lat);

#line default
#line hidden
            EndContext();
            BeginContext(860, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(863, 14, false);
#line 41 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Weather\WeatherCall.cshtml"
                                 Write(city.coord.lon);

#line default
#line hidden
            EndContext();
            BeginContext(877, 16, true);
            WriteLiteral("]</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(893, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ba63771dfd0d28ae061966e8c0b8c8883d2309211714", async() => {
                BeginContext(943, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-cityId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 42 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Weather\WeatherCall.cshtml"
                                                 WriteLiteral(city.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cityId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-cityId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cityId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(954, 17, true);
            WriteLiteral("</td>\r\n\t\t\t</tr>\r\n");
            EndContext();
#line 44 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Weather\WeatherCall.cshtml"
		}

#line default
#line hidden
            BeginContext(976, 23, true);
            WriteLiteral("\t\t</tbody>\r\n\t</table>\r\n");
            EndContext();
#line 47 "C:\Users\Kuba\Desktop\WeatherApp_best\WeatherApp\Pages\Weather\WeatherCall.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WeatherApp.Pages.Weather.WeatherCallModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WeatherApp.Pages.Weather.WeatherCallModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WeatherApp.Pages.Weather.WeatherCallModel>)PageContext?.ViewData;
        public WeatherApp.Pages.Weather.WeatherCallModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
