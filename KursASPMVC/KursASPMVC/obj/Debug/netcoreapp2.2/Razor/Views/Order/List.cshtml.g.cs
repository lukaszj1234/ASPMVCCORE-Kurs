#pragma checksum "C:\Users\Moje\Documents\GitHub\ASPMVCCORE-Kurs\KursASPMVC\KursASPMVC\Views\Order\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84355e8d50560fd9e16689f0dc1bb624eb42cfa8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_List), @"mvc.1.0.view", @"/Views/Order/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/List.cshtml", typeof(AspNetCore.Views_Order_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84355e8d50560fd9e16689f0dc1bb624eb42cfa8", @"/Views/Order/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35ff93a7b55c7740722ce4dc0cdb208ee4433f61", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MarkShipped", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Moje\Documents\GitHub\ASPMVCCORE-Kurs\KursASPMVC\KursASPMVC\Views\Order\List.cshtml"
   
    ViewBag.Title = "Zamówienia";
    Layout = "_AdminLayout";

#line default
#line hidden
            BeginContext(102, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\Moje\Documents\GitHub\ASPMVCCORE-Kurs\KursASPMVC\KursASPMVC\Views\Order\List.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
            BeginContext(132, 192, true);
            WriteLiteral("    <table class=\"table-bordered table-striped text-center\" width=\"90%\" align=\"center\">\r\n        <tr><th>Klient</th><th>Kod pocztowy</th>\r\n            <th colspan=\"2\">Opis</th><th></th></tr>\r\n");
            EndContext();
#line 13 "C:\Users\Moje\Documents\GitHub\ASPMVCCORE-Kurs\KursASPMVC\KursASPMVC\Views\Order\List.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(373, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(412, 9, false);
#line 16 "C:\Users\Moje\Documents\GitHub\ASPMVCCORE-Kurs\KursASPMVC\KursASPMVC\Views\Order\List.cshtml"
               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(421, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(449, 8, false);
#line 17 "C:\Users\Moje\Documents\GitHub\ASPMVCCORE-Kurs\KursASPMVC\KursASPMVC\Views\Order\List.cshtml"
               Write(item.Zip);

#line default
#line hidden
            EndContext();
            BeginContext(457, 115, true);
            WriteLiteral("</td>\r\n                <th>Produkt</th>\r\n                <th>Ilość</th>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(572, 366, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84355e8d50560fd9e16689f0dc1bb624eb42cfa86568", async() => {
                BeginContext(668, 61, true);
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"orderId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 729, "\"", 750, 1);
#line 23 "C:\Users\Moje\Documents\GitHub\ASPMVCCORE-Kurs\KursASPMVC\KursASPMVC\Views\Order\List.cshtml"
WriteAttributeValue("", 737, item.OrderId, 737, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(751, 180, true);
                WriteLiteral(" />\r\n                        <button class=\"btn btn-sm btn-danger\" type=\"submit\">\r\n                            Zrealizowane\r\n                        </button>\r\n                    ");
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
            BeginContext(938, 45, true);
            WriteLiteral(" \r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 30 "C:\Users\Moje\Documents\GitHub\ASPMVCCORE-Kurs\KursASPMVC\KursASPMVC\Views\Order\List.cshtml"
             foreach (CartLine line in item.Lines)
            {

#line default
#line hidden
            BeginContext(1050, 89, true);
            WriteLiteral("                <tr>\r\n                    <td colspan=\"2\"></td>\r\n                    <td>");
            EndContext();
            BeginContext(1140, 17, false);
#line 34 "C:\Users\Moje\Documents\GitHub\ASPMVCCORE-Kurs\KursASPMVC\KursASPMVC\Views\Order\List.cshtml"
                   Write(line.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1157, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1189, 13, false);
#line 35 "C:\Users\Moje\Documents\GitHub\ASPMVCCORE-Kurs\KursASPMVC\KursASPMVC\Views\Order\List.cshtml"
                   Write(line.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1202, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 37 "C:\Users\Moje\Documents\GitHub\ASPMVCCORE-Kurs\KursASPMVC\KursASPMVC\Views\Order\List.cshtml"
            }

#line default
#line hidden
#line 37 "C:\Users\Moje\Documents\GitHub\ASPMVCCORE-Kurs\KursASPMVC\KursASPMVC\Views\Order\List.cshtml"
             
        }

#line default
#line hidden
            BeginContext(1258, 14, true);
            WriteLiteral("    </table>\r\n");
            EndContext();
#line 40 "C:\Users\Moje\Documents\GitHub\ASPMVCCORE-Kurs\KursASPMVC\KursASPMVC\Views\Order\List.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1284, 68, true);
            WriteLiteral("    <div class=\"text-center\">Brak niezrealizowanych zamówień</div>\r\n");
            EndContext();
#line 44 "C:\Users\Moje\Documents\GitHub\ASPMVCCORE-Kurs\KursASPMVC\KursASPMVC\Views\Order\List.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
