#pragma checksum "C:\Users\Owner\Source\Repos\361Capstone\361Capstone\361Capstone\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a82c5830bf4ee0604c69911774515f1733c4aff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Owner\Source\Repos\361Capstone\361Capstone\361Capstone\Views\_ViewImports.cshtml"
using _361Capstone;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Owner\Source\Repos\361Capstone\361Capstone\361Capstone\Views\Products\Index.cshtml"
using _361Capstone.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a82c5830bf4ee0604c69911774515f1733c4aff", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"951126843324e2aa577432d9ee3cb10c60289f20", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Owner\Source\Repos\361Capstone\361Capstone\361Capstone\Views\Products\Index.cshtml"
  
    Layout = "_Layout";



#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a82c5830bf4ee0604c69911774515f1733c4aff4307", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7a82c5830bf4ee0604c69911774515f1733c4aff4573", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 12 "C:\Users\Owner\Source\Repos\361Capstone\361Capstone\361Capstone\Views\Products\Index.cshtml"
    WriteLiteral(Url.Content("~/CSS/AccountList.css"));

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("href", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 12 "C:\Users\Owner\Source\Repos\361Capstone\361Capstone\361Capstone\Views\Products\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7a82c5830bf4ee0604c69911774515f1733c4aff6880", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "C:\Users\Owner\Source\Repos\361Capstone\361Capstone\361Capstone\Views\Products\Index.cshtml"
    WriteLiteral(Url.Content("~/CSS/List.css"));

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("href", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 14 "C:\Users\Owner\Source\Repos\361Capstone\361Capstone\361Capstone\Views\Products\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    \r\n\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a82c5830bf4ee0604c69911774515f1733c4aff9896", async() => {
                WriteLiteral("\r\n    <a style=\"float:right;margin-left:5px\" class=\"btn btn-danger\"");
                BeginWriteAttribute("href", " href=\"", 410, "\"", 447, 1);
#nullable restore
#line 20 "C:\Users\Owner\Source\Repos\361Capstone\361Capstone\361Capstone\Views\Products\Index.cshtml"
WriteAttributeValue("", 417, Url.Action("Logout", "Login"), 417, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" role=\"button\">Log out</a>\r\n    <a style=\"float:right\" class=\"btn btn-primary\"");
                BeginWriteAttribute("href", " href=\"", 526, "\"", 602, 1);
#nullable restore
#line 21 "C:\Users\Owner\Source\Repos\361Capstone\361Capstone\361Capstone\Views\Products\Index.cshtml"
WriteAttributeValue("", 533, Url.Action("Index", "UserCart", new { userId = ViewData["UserId"] }), 533, 69, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" role=\"button\">View Cart</a>\r\n\r\n    <div class=\"list\">\r\n\r\n        <h1>");
#nullable restore
#line 25 "C:\Users\Owner\Source\Repos\361Capstone\361Capstone\361Capstone\Views\Products\Index.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n\r\n        <!--Lists items-->\r\n");
#nullable restore
#line 28 "C:\Users\Owner\Source\Repos\361Capstone\361Capstone\361Capstone\Views\Products\Index.cshtml"
         foreach (Category category in (List<Category>)ViewData["Categories"]) {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <h2>");
#nullable restore
#line 29 "C:\Users\Owner\Source\Repos\361Capstone\361Capstone\361Capstone\Views\Products\Index.cshtml"
           Write(category.GetTitle());

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n            <ul style=\"list-style-type:none;\" class=\"item\">\r\n");
#nullable restore
#line 31 "C:\Users\Owner\Source\Repos\361Capstone\361Capstone\361Capstone\Views\Products\Index.cshtml"
                 foreach (Product item in (List<Product>)ViewData["Products"]) {
                    if (item.GetCategoryId() == category.GetCategoryId()) {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li>\r\n\r\n                            <a");
                BeginWriteAttribute("href", " href=\'", 1135, "\'", 1242, 5);
#nullable restore
#line 35 "C:\Users\Owner\Source\Repos\361Capstone\361Capstone\361Capstone\Views\Products\Index.cshtml"
WriteAttributeValue("", 1142, Url.Action("GoToProductPage", "Products"), 1142, 42, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1184, "?productId=", 1184, 11, true);
#nullable restore
#line 35 "C:\Users\Owner\Source\Repos\361Capstone\361Capstone\361Capstone\Views\Products\Index.cshtml"
WriteAttributeValue("", 1195, item.GetProductId(), 1195, 20, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1215, "&userId=", 1215, 8, true);
#nullable restore
#line 35 "C:\Users\Owner\Source\Repos\361Capstone\361Capstone\361Capstone\Views\Products\Index.cshtml"
WriteAttributeValue("", 1223, ViewData["UserId"], 1223, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><h4 style=\"display:inline-block\">");
#nullable restore
#line 35 "C:\Users\Owner\Source\Repos\361Capstone\361Capstone\361Capstone\Views\Products\Index.cshtml"
                                                                                                                                                                       Write(item.GetName());

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4></a>\r\n                            <!--<button style=\"display:inline-block\">View Product Page</button>-->\r\n\r\n                        </li>\r\n");
#nullable restore
#line 39 "C:\Users\Owner\Source\Repos\361Capstone\361Capstone\361Capstone\Views\Products\Index.cshtml"
                    }


                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </ul>\r\n");
#nullable restore
#line 44 "C:\Users\Owner\Source\Repos\361Capstone\361Capstone\361Capstone\Views\Products\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <!--For loop to add spaces-->\r\n        <ul style=\"list-style-type:none;\" class=\"space\">\r\n        </ul>\r\n    </div>\r\n\r\n\r\n");
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
            WriteLiteral("\r\n</html>\r\n\r\n<script>\r\n    function goToProductPage(productId) {\r\n        location.href = \'");
#nullable restore
#line 56 "C:\Users\Owner\Source\Repos\361Capstone\361Capstone\361Capstone\Views\Products\Index.cshtml"
                    Write(Url.Action("GoToProductPage", "Products"));

#line default
#line hidden
#nullable disable
            WriteLiteral("?productId=\' + productId;\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
