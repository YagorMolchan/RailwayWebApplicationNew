#pragma checksum "D:\Диплом\RailwayNew1\RailwayNew1\Views\Shared\_OnlineTablo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a13b932df0aad3e9a4bbac0b98973f359802ab7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__OnlineTablo), @"mvc.1.0.view", @"/Views/Shared/_OnlineTablo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_OnlineTablo.cshtml", typeof(AspNetCore.Views_Shared__OnlineTablo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a13b932df0aad3e9a4bbac0b98973f359802ab7", @"/Views/Shared/_OnlineTablo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f315709688e52fe90a0a5f59d6d608b94430609b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__OnlineTablo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RailwayNew1.Models.ViewModel.Route.IndexViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(71, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(133, 245, true);
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                <label>Номер маршрута</label>\r\n            </th>\r\n            <th>\r\n                <label>Маршрут</label>\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(379, 43, false);
#line 17 "D:\Диплом\RailwayNew1\RailwayNew1\Views\Shared\_OnlineTablo.cshtml"
           Write(Html.DisplayNameFor(model => model.Arrival));

#line default
#line hidden
            EndContext();
            BeginContext(422, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(478, 47, false);
#line 20 "D:\Диплом\RailwayNew1\RailwayNew1\Views\Shared\_OnlineTablo.cshtml"
           Write(Html.DisplayNameFor(model => model.ParkingTime));

#line default
#line hidden
            EndContext();
            BeginContext(525, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(581, 45, false);
#line 23 "D:\Диплом\RailwayNew1\RailwayNew1\Views\Shared\_OnlineTablo.cshtml"
           Write(Html.DisplayNameFor(model => model.Departure));

#line default
#line hidden
            EndContext();
            BeginContext(626, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "D:\Диплом\RailwayNew1\RailwayNew1\Views\Shared\_OnlineTablo.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(738, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(799, 7, false);
#line 32 "D:\Диплом\RailwayNew1\RailwayNew1\Views\Shared\_OnlineTablo.cshtml"
               Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(806, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(874, 9, false);
#line 35 "D:\Диплом\RailwayNew1\RailwayNew1\Views\Shared\_OnlineTablo.cshtml"
               Write(item.From);

#line default
#line hidden
            EndContext();
            BeginContext(883, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(887, 7, false);
#line 35 "D:\Диплом\RailwayNew1\RailwayNew1\Views\Shared\_OnlineTablo.cshtml"
                            Write(item.To);

#line default
#line hidden
            EndContext();
            BeginContext(894, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(962, 42, false);
#line 38 "D:\Диплом\RailwayNew1\RailwayNew1\Views\Shared\_OnlineTablo.cshtml"
               Write(Html.DisplayFor(modelItem => item.Arrival));

#line default
#line hidden
            EndContext();
            BeginContext(1004, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1072, 46, false);
#line 41 "D:\Диплом\RailwayNew1\RailwayNew1\Views\Shared\_OnlineTablo.cshtml"
               Write(Html.DisplayFor(modelItem => item.ParkingTime));

#line default
#line hidden
            EndContext();
            BeginContext(1118, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1186, 44, false);
#line 44 "D:\Диплом\RailwayNew1\RailwayNew1\Views\Shared\_OnlineTablo.cshtml"
               Write(Html.DisplayFor(modelItem => item.Departure));

#line default
#line hidden
            EndContext();
            BeginContext(1230, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
            BeginContext(1559, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 52 "D:\Диплом\RailwayNew1\RailwayNew1\Views\Shared\_OnlineTablo.cshtml"
        }

#line default
#line hidden
            BeginContext(1589, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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