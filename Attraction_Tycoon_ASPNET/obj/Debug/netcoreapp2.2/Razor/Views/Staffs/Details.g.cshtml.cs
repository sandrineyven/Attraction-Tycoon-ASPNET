#pragma checksum "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\Staffs\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "716ccd8ccb367e04bce2c79c1ad9869be4c36a5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staffs_Details), @"mvc.1.0.view", @"/Views/Staffs/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Staffs/Details.cshtml", typeof(AspNetCore.Views_Staffs_Details))]
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
#line 1 "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\_ViewImports.cshtml"
using Attraction_Tycoon_ASPNET;

#line default
#line hidden
#line 2 "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\_ViewImports.cshtml"
using Attraction_Tycoon_ASPNET.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"716ccd8ccb367e04bce2c79c1ad9869be4c36a5d", @"/Views/Staffs/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df9e7b4cfcd39c0e3286d2bec78e48f98a4fb3fb", @"/Views/_ViewImports.cshtml")]
    public class Views_Staffs_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Attraction_Tycoon_ASPNET.Models.Staff>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\Staffs\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(91, 128, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Staff</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(220, 43, false);
#line 14 "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\Staffs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.id_user));

#line default
#line hidden
            EndContext();
            BeginContext(263, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(327, 39, false);
#line 17 "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\Staffs\Details.cshtml"
       Write(Html.DisplayFor(model => model.id_user));

#line default
#line hidden
            EndContext();
            BeginContext(366, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(429, 40, false);
#line 20 "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\Staffs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
            EndContext();
            BeginContext(469, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(533, 36, false);
#line 23 "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\Staffs\Details.cshtml"
       Write(Html.DisplayFor(model => model.name));

#line default
#line hidden
            EndContext();
            BeginContext(569, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(632, 40, false);
#line 26 "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\Staffs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.type));

#line default
#line hidden
            EndContext();
            BeginContext(672, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(736, 36, false);
#line 29 "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\Staffs\Details.cshtml"
       Write(Html.DisplayFor(model => model.type));

#line default
#line hidden
            EndContext();
            BeginContext(772, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(835, 42, false);
#line 32 "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\Staffs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.salary));

#line default
#line hidden
            EndContext();
            BeginContext(877, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(941, 38, false);
#line 35 "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\Staffs\Details.cshtml"
       Write(Html.DisplayFor(model => model.salary));

#line default
#line hidden
            EndContext();
            BeginContext(979, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1042, 41, false);
#line 38 "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\Staffs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.hours));

#line default
#line hidden
            EndContext();
            BeginContext(1083, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1147, 37, false);
#line 41 "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\Staffs\Details.cshtml"
       Write(Html.DisplayFor(model => model.hours));

#line default
#line hidden
            EndContext();
            BeginContext(1184, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1247, 42, false);
#line 44 "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\Staffs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.status));

#line default
#line hidden
            EndContext();
            BeginContext(1289, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1353, 38, false);
#line 47 "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\Staffs\Details.cshtml"
       Write(Html.DisplayFor(model => model.status));

#line default
#line hidden
            EndContext();
            BeginContext(1391, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1438, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "716ccd8ccb367e04bce2c79c1ad9869be4c36a5d10138", async() => {
                BeginContext(1484, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\gigabyte\Documents\Informatique_2018-2019\Git\Attraction-Tycoon-ASPNET\Attraction_Tycoon_ASPNET\Views\Staffs\Details.cshtml"
                           WriteLiteral(Model.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1492, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1500, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "716ccd8ccb367e04bce2c79c1ad9869be4c36a5d12513", async() => {
                BeginContext(1522, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1538, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Attraction_Tycoon_ASPNET.Models.Staff> Html { get; private set; }
    }
}
#pragma warning restore 1591