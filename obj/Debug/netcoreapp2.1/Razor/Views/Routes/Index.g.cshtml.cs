#pragma checksum "D:\Диплом\RailwayNew1\RailwayNew1\Views\Routes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e89029148054c6fa88550975b4d0d56b82a411b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Routes_Index), @"mvc.1.0.view", @"/Views/Routes/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Routes/Index.cshtml", typeof(AspNetCore.Views_Routes_Index))]
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
#line 1 "D:\Диплом\RailwayNew1\RailwayNew1\Views\_ViewImports.cshtml"
using RailwayNew1;

#line default
#line hidden
#line 2 "D:\Диплом\RailwayNew1\RailwayNew1\Views\_ViewImports.cshtml"
using RailwayNew1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e89029148054c6fa88550975b4d0d56b82a411b1", @"/Views/Routes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f315709688e52fe90a0a5f59d6d608b94430609b", @"/Views/_ViewImports.cshtml")]
    public class Views_Routes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RailwayNew1.Models.ViewModel.Route.IndexViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(71, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Диплом\RailwayNew1\RailwayNew1\Views\Routes\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(161, 42, true);
            WriteLiteral("\r\n<h2>Расписание движения поездов</h2>\r\n\r\n");
            EndContext();
            BeginContext(261, 257, true);
            WriteLiteral(@"<table class=""table"">
    <thead>
        <tr>            
            <th>
                <label>Номер маршрута</label>
            </th>
            <th>
                <label>Маршрут</label>
            </th>
            <th>
                ");
            EndContext();
            BeginContext(519, 43, false);
#line 23 "D:\Диплом\RailwayNew1\RailwayNew1\Views\Routes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Arrival));

#line default
#line hidden
            EndContext();
            BeginContext(562, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(618, 47, false);
#line 26 "D:\Диплом\RailwayNew1\RailwayNew1\Views\Routes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ParkingTime));

#line default
#line hidden
            EndContext();
            BeginContext(665, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(721, 45, false);
#line 29 "D:\Диплом\RailwayNew1\RailwayNew1\Views\Routes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Departure));

#line default
#line hidden
            EndContext();
            BeginContext(766, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 34 "D:\Диплом\RailwayNew1\RailwayNew1\Views\Routes\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(861, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(910, 7, false);
#line 37 "D:\Диплом\RailwayNew1\RailwayNew1\Views\Routes\Index.cshtml"
           Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(917, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(973, 9, false);
#line 40 "D:\Диплом\RailwayNew1\RailwayNew1\Views\Routes\Index.cshtml"
           Write(item.From);

#line default
#line hidden
            EndContext();
            BeginContext(982, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(986, 7, false);
#line 40 "D:\Диплом\RailwayNew1\RailwayNew1\Views\Routes\Index.cshtml"
                        Write(item.To);

#line default
#line hidden
            EndContext();
            BeginContext(993, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1049, 42, false);
#line 43 "D:\Диплом\RailwayNew1\RailwayNew1\Views\Routes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Arrival));

#line default
#line hidden
            EndContext();
            BeginContext(1091, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1147, 46, false);
#line 46 "D:\Диплом\RailwayNew1\RailwayNew1\Views\Routes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ParkingTime));

#line default
#line hidden
            EndContext();
            BeginContext(1193, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1249, 44, false);
#line 49 "D:\Диплом\RailwayNew1\RailwayNew1\Views\Routes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Departure));

#line default
#line hidden
            EndContext();
            BeginContext(1293, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
            BeginContext(1582, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 57 "D:\Диплом\RailwayNew1\RailwayNew1\Views\Routes\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1600, 81, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<button onclick=\"history.back()\">\r\n    Назад\r\n</button>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RailwayNew1.Models.ViewModel.Route.IndexViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
