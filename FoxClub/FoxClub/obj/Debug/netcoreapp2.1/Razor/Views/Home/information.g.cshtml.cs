#pragma checksum "C:\Users\Lojka\Desktop\greenfox\Lojkys\week-07\day-5\FoxClub\FoxClub\Views\Home\information.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91346d173895d188330505022b8d956ada3c94fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_information), @"mvc.1.0.view", @"/Views/Home/information.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/information.cshtml", typeof(AspNetCore.Views_Home_information))]
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
#line 1 "C:\Users\Lojka\Desktop\greenfox\Lojkys\week-07\day-5\FoxClub\FoxClub\Views\Home\information.cshtml"
using FoxClub.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91346d173895d188330505022b8d956ada3c94fc", @"/Views/Home/information.cshtml")]
    public class Views_Home_information : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Fox>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(38, 51, true);
            WriteLiteral("\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n    ");
            EndContext();
            BeginContext(89, 107, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ea66814cfee499e972475e572aee023", async() => {
                BeginContext(95, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(105, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "347318ab999a48a5989b4f0b8b015055", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(149, 40, true);
                WriteLiteral("\r\n        <title>Home Page</title>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(196, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(202, 1061, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b94bb1886e5436ba257a592d7739dcd", async() => {
                BeginContext(208, 165, true);
                WriteLiteral("\r\n        <nav>\r\n            <ul>\r\n                <li><a href=\"/\">Main page</a></li>\r\n                <li><a href=\"/login\">Login page</a></li>\r\n                <li>");
                EndContext();
                BeginContext(374, 52, false);
#line 15 "C:\Users\Lojka\Desktop\greenfox\Lojkys\week-07\day-5\FoxClub\FoxClub\Views\Home\information.cshtml"
               Write(Html.ActionLink("Information", "information", Model));

#line default
#line hidden
                EndContext();
                BeginContext(426, 27, true);
                WriteLiteral("</li>\r\n                <li>");
                EndContext();
                BeginContext(454, 59, false);
#line 16 "C:\Users\Lojka\Desktop\greenfox\Lojkys\week-07\day-5\FoxClub\FoxClub\Views\Home\information.cshtml"
               Write(Html.ActionLink("Nutrition Store", "nutritionStore", Model));

#line default
#line hidden
                EndContext();
                BeginContext(513, 27, true);
                WriteLiteral("</li>\r\n                <li>");
                EndContext();
                BeginContext(541, 53, false);
#line 17 "C:\Users\Lojka\Desktop\greenfox\Lojkys\week-07\day-5\FoxClub\FoxClub\Views\Home\information.cshtml"
               Write(Html.ActionLink("Trick Center", "trickCenter", Model));

#line default
#line hidden
                EndContext();
                BeginContext(594, 149, true);
                WriteLiteral("</li>\r\n            </ul>\r\n        </nav>\r\n        <main>\r\n            <img src=\"./assets/greenfox.png\" alt=\"greenfox\" />\r\n            <p>This is Mr. ");
                EndContext();
                BeginContext(744, 10, false);
#line 22 "C:\Users\Lojka\Desktop\greenfox\Lojkys\week-07\day-5\FoxClub\FoxClub\Views\Home\information.cshtml"
                      Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(754, 22, true);
                WriteLiteral(". Currently living on ");
                EndContext();
                BeginContext(777, 10, false);
#line 22 "C:\Users\Lojka\Desktop\greenfox\Lojkys\week-07\day-5\FoxClub\FoxClub\Views\Home\information.cshtml"
                                                       Write(Model.Food);

#line default
#line hidden
                EndContext();
                BeginContext(787, 14, true);
                WriteLiteral(" and drinking ");
                EndContext();
                BeginContext(802, 11, false);
#line 22 "C:\Users\Lojka\Desktop\greenfox\Lojkys\week-07\day-5\FoxClub\FoxClub\Views\Home\information.cshtml"
                                                                                Write(Model.Drink);

#line default
#line hidden
                EndContext();
                BeginContext(813, 11, true);
                WriteLiteral(". He knows ");
                EndContext();
                BeginContext(825, 24, false);
#line 22 "C:\Users\Lojka\Desktop\greenfox\Lojkys\week-07\day-5\FoxClub\FoxClub\Views\Home\information.cshtml"
                                                                                                       Write(Model.ListOfTricks.Count);

#line default
#line hidden
                EndContext();
                BeginContext(849, 67, true);
                WriteLiteral(" tricks.</p>\r\n            <h1>Known tricks</h1>\r\n            <ul>\r\n");
                EndContext();
#line 25 "C:\Users\Lojka\Desktop\greenfox\Lojkys\week-07\day-5\FoxClub\FoxClub\Views\Home\information.cshtml"
                 if (Model.ListOfTricks.Count == 0)
                {
                    

#line default
#line hidden
                BeginContext(1009, 51, false);
#line 27 "C:\Users\Lojka\Desktop\greenfox\Lojkys\week-07\day-5\FoxClub\FoxClub\Views\Home\information.cshtml"
               Write(Html.ActionLink("Add tricks", "trickCenter", Model));

#line default
#line hidden
                EndContext();
#line 27 "C:\Users\Lojka\Desktop\greenfox\Lojkys\week-07\day-5\FoxClub\FoxClub\Views\Home\information.cshtml"
                                                                        
                }

#line default
#line hidden
                BeginContext(1081, 16, true);
                WriteLiteral("                ");
                EndContext();
#line 29 "C:\Users\Lojka\Desktop\greenfox\Lojkys\week-07\day-5\FoxClub\FoxClub\Views\Home\information.cshtml"
                 foreach (var trick in Model.ListOfTricks)
                {

#line default
#line hidden
                BeginContext(1160, 24, true);
                WriteLiteral("                    <li>");
                EndContext();
                BeginContext(1185, 5, false);
#line 31 "C:\Users\Lojka\Desktop\greenfox\Lojkys\week-07\day-5\FoxClub\FoxClub\Views\Home\information.cshtml"
                   Write(trick);

#line default
#line hidden
                EndContext();
                BeginContext(1190, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 32 "C:\Users\Lojka\Desktop\greenfox\Lojkys\week-07\day-5\FoxClub\FoxClub\Views\Home\information.cshtml"
                }

#line default
#line hidden
                BeginContext(1216, 40, true);
                WriteLiteral("            </ul>\r\n        </main>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1263, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Fox> Html { get; private set; }
    }
}
#pragma warning restore 1591
