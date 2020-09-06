#pragma checksum "C:\Users\Sointu\source\repos\Movies\Views\Movies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13235945cacbb876f0b04cf0363ffa6c158356f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13235945cacbb876f0b04cf0363ffa6c158356f9", @"/Views/Movies/Index.cshtml")]
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movies.Models.ViewModels.MoviesIndexVM[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Sointu\source\repos\Movies\Views\Movies\Index.cshtml"
  
    ViewBag.Title = "Movies";
    ViewBag.Header = "Movies";

#line default
#line hidden
#nullable disable
            WriteLiteral("<ul>\r\n");
#nullable restore
#line 8 "C:\Users\Sointu\source\repos\Movies\Views\Movies\Index.cshtml"
     foreach (var movie in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            ");
#nullable restore
#line 11 "C:\Users\Sointu\source\repos\Movies\Views\Movies\Index.cshtml"
       Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("        </li>\r\n");
#nullable restore
#line 14 "C:\Users\Sointu\source\repos\Movies\Views\Movies\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n<button asp-controller=\"Movies\" asp-action=\"Create\">Add a movie to your list</button>\r\n<p>\r\n    <a href=\"create/\" class=\"button\">Add a movie to your list</a>\r\n");
            WriteLiteral("</p>\r\n\r\n\r\n<hr />\r\n\r\n");
            WriteLiteral("\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        // HTML
        $(""#btnGetHTML"").click(function () {
            // Make AJAX call
            $.ajax({
                url: ""/timebox"",
                type: ""GET"",
                success: function (result) {
                    // Call done - update DOM
                    $(""#divStuff"").html(result);
                }
            });
        });

        // JSON
        $(""#btnGetJSON"").click(function () {
            // Make AJAX call
            $.ajax({
                url: ""/timebox-data"",
                type: ""GET"",
                success: function (result) {
                    // Call done - update DOM
                    $(""#divStuff"").html(""<b>"" + result.time + ""</b>"");
                }
            });
        });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movies.Models.ViewModels.MoviesIndexVM[]> Html { get; private set; }
    }
}
#pragma warning restore 1591