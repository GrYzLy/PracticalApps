#pragma checksum "/Users/barrze/Dev/cs9dotnet5-master/PracticalApps/PracticalApps/NorthwindEmployees/Areas/PacktFeatures/Pages/Shared/_Employee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c81babd727b6d8af6d0ec5b8696aa9f67c446266"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_PacktFeatures_Pages_Shared__Employee), @"mvc.1.0.view", @"/Areas/PacktFeatures/Pages/Shared/_Employee.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c81babd727b6d8af6d0ec5b8696aa9f67c446266", @"/Areas/PacktFeatures/Pages/Shared/_Employee.cshtml")]
    #nullable restore
    public class Areas_PacktFeatures_Pages_Shared__Employee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Packt.Shared.Employee>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"card border-dark mb-3\" style=\"max-width: 18rem;\">\n  <div class=\"card-header\">");
#nullable restore
#line 3 "/Users/barrze/Dev/cs9dotnet5-master/PracticalApps/PracticalApps/NorthwindEmployees/Areas/PacktFeatures/Pages/Shared/_Employee.cshtml"
                      Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \n    ");
#nullable restore
#line 4 "/Users/barrze/Dev/cs9dotnet5-master/PracticalApps/PracticalApps/NorthwindEmployees/Areas/PacktFeatures/Pages/Shared/_Employee.cshtml"
Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n  <div class=\"card-body text-dark\">\n    <h5 class=\"card-title\">");
#nullable restore
#line 6 "/Users/barrze/Dev/cs9dotnet5-master/PracticalApps/PracticalApps/NorthwindEmployees/Areas/PacktFeatures/Pages/Shared/_Employee.cshtml"
                      Write(Model.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n    <p class=\"card-text\">");
#nullable restore
#line 7 "/Users/barrze/Dev/cs9dotnet5-master/PracticalApps/PracticalApps/NorthwindEmployees/Areas/PacktFeatures/Pages/Shared/_Employee.cshtml"
                    Write(Model.Notes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n  </div>\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Packt.Shared.Employee> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
