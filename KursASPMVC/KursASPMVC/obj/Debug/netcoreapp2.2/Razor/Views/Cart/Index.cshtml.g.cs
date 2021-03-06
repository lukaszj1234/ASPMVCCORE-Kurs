#pragma checksum "C:\Users\Moje\Documents\GitHub\ASPMVCCORE-Kurs\KursASPMVC\KursASPMVC\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fa379313e4903ae0d3d744bcce064f2919dfb0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Index.cshtml", typeof(AspNetCore.Views_Cart_Index))]
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
#line 1 "C:\Users\Moje\Documents\GitHub\ASPMVCCORE-Kurs\KursASPMVC\KursASPMVC\Views\_ViewImports.cshtml"
using KursASPMVC.Models;

#line default
#line hidden
#line 2 "C:\Users\Moje\Documents\GitHub\ASPMVCCORE-Kurs\KursASPMVC\KursASPMVC\Views\_ViewImports.cshtml"
using KursASPMVC.Models.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\Moje\Documents\GitHub\ASPMVCCORE-Kurs\KursASPMVC\KursASPMVC\Views\_ViewImports.cshtml"
using KursASPMVC.Components;

#line default
#line hidden
#line 4 "C:\Users\Moje\Documents\GitHub\ASPMVCCORE-Kurs\KursASPMVC\KursASPMVC\Views\_ViewImports.cshtml"
using KursASPMVC.Infrastructure;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fa379313e4903ae0d3d744bcce064f2919dfb0a", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35ff93a7b55c7740722ce4dc0cdb208ee4433f61", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CartIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveFromCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 307, true);
            WriteLiteral(@"
<h2>Twój koszyk</h2>

<table class=""table-bordered table-striped"" width=""100%"">
    <thead>
        <tr>
            <th>Ilość</th>
            <th>Produkt</th>
            <th class=""text-right"">Cena</th>
            <th class=""text-right"">Wartość</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 15 "C:\Users\Moje\Documents\GitHub\ASPMVCCORE-Kurs\KursASPMVC\KursASPMVC\Views\Cart\Index.cshtml"
         foreach (var item in Model.Cart.Lines)
        {

#line default
#line hidden
            BeginContext(394, 58, true);
            WriteLiteral("            <tr>\r\n                <td class=\"text-center\">");
            EndContext();
            BeginContext(453, 13, false);
#line 18 "C:\Users\Moje\Documents\GitHub\ASPMVCCORE-Kurs\KursASPMVC\KursASPMVC\Views\Cart\Index.cshtml"
                                   Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(466, 45, true);
            WriteLiteral("</td>\r\n                <td class=\"text-left\">");
            EndContext();
            BeginContext(512, 17, false);
#line 19 "C:\Users\Moje\Documents\GitHub\ASPMVCCORE-Kurs\KursASPMVC\KursASPMVC\Views\Cart\Index.cshtml"
                                 Write(item.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(529, 46, true);
            WriteLiteral("</td>\r\n                <td class=\"text-right\">");
            EndContext();
            BeginContext(576, 32, false);
#line 20 "C:\Users\Moje\Documents\GitHub\ASPMVCCORE-Kurs\KursASPMVC\KursASPMVC\Views\Cart\Index.cshtml"
                                  Write(item.Product.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(608, 68, true);
            WriteLiteral("</td>\r\n                <td class=\"text-right\">\r\n                    ");
            EndContext();
            BeginContext(678, 50, false);
#line 22 "C:\Users\Moje\Documents\GitHub\ASPMVCCORE-Kurs\KursASPMVC\KursASPMVC\Views\Cart\Index.cshtml"
                Write((item.Quantity * item.Product.Price).ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(729, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(796, 526, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fa379313e4903ae0d3d744bcce064f2919dfb0a8143", async() => {
                BeginContext(893, 46, true);
                WriteLiteral("\r\n                        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 939, "\"", 970, 1);
#line 27 "C:\Users\Moje\Documents\GitHub\ASPMVCCORE-Kurs\KursASPMVC\KursASPMVC\Views\Cart\Index.cshtml"
WriteAttributeValue("", 947, item.Product.ProductID, 947, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(971, 115, true);
                WriteLiteral(" \r\n                               name=\"ProductId\"/>\r\n                        <input type=\"hidden\" name=\"reutrnUrl\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n                               value=\"", 1086, "\"", 1142, 1);
#line 30 "C:\Users\Moje\Documents\GitHub\ASPMVCCORE-Kurs\KursASPMVC\KursASPMVC\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1126, Model.ReturnUrl, 1126, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1143, 172, true);
                WriteLiteral(" />\r\n                        <button type=\"submit\" class=\"btn btn-sm btn-danger\">\r\n                            Usuń\r\n                        </button>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1322, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 37 "C:\Users\Moje\Documents\GitHub\ASPMVCCORE-Kurs\KursASPMVC\KursASPMVC\Views\Cart\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1377, 153, true);
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n        <tr>\r\n            <td colspan=\"3\" class=\"text-right\">Razem</td>\r\n            <td class=\"text-right\">\r\n                ");
            EndContext();
            BeginContext(1532, 46, false);
#line 43 "C:\Users\Moje\Documents\GitHub\ASPMVCCORE-Kurs\KursASPMVC\KursASPMVC\Views\Cart\Index.cshtml"
            Write((Model.Cart.ComputeTotalValue()).ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(1579, 119, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </tfoot>\r\n</table>\r\n\r\n<div class=\"text-center\">\r\n    <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1698, "\"", 1721, 1);
#line 50 "C:\Users\Moje\Documents\GitHub\ASPMVCCORE-Kurs\KursASPMVC\KursASPMVC\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1705, Model.ReturnUrl, 1705, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1722, 27, true);
            WriteLiteral(">Kontynuuj zakupy</a>\r\n    ");
            EndContext();
            BeginContext(1749, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fa379313e4903ae0d3d744bcce064f2919dfb0a12877", async() => {
                BeginContext(1821, 27, true);
                WriteLiteral("\r\n    Złóż zamówienie\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1852, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CartIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
