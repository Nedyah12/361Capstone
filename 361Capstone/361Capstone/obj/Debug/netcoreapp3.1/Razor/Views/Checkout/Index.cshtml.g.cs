#pragma checksum "/Users/jettdurante/Desktop/361Capstone/361Capstone/361Capstone/Views/Checkout/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9588a2da1ead849aaba260fcb4f2e27fa43c2af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_Index), @"mvc.1.0.view", @"/Views/Checkout/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/jettdurante/Desktop/361Capstone/361Capstone/361Capstone/Views/_ViewImports.cshtml"
using _361Capstone;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/jettdurante/Desktop/361Capstone/361Capstone/361Capstone/Views/Checkout/Index.cshtml"
using _361Capstone.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/jettdurante/Desktop/361Capstone/361Capstone/361Capstone/Views/Checkout/Index.cshtml"
using System;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9588a2da1ead849aaba260fcb4f2e27fa43c2af", @"/Views/Checkout/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b977527a1e6a2594c4ef055e96ff5dae15e2c02", @"/Views/_ViewImports.cshtml")]
    public class Views_Checkout_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "/Users/jettdurante/Desktop/361Capstone/361Capstone/361Capstone/Views/Checkout/Index.cshtml"
  
    Layout = "_Layout";

    ViewBag.Title = ViewData["Title"];


#line default
#line hidden
#nullable disable
            WriteLiteral("\n<html>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9588a2da1ead849aaba260fcb4f2e27fa43c2af4426", async() => {
                WriteLiteral("\n\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c9588a2da1ead849aaba260fcb4f2e27fa43c2af4686", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "/Users/jettdurante/Desktop/361Capstone/361Capstone/361Capstone/Views/Checkout/Index.cshtml"
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
#line 14 "/Users/jettdurante/Desktop/361Capstone/361Capstone/361Capstone/Views/Checkout/Index.cshtml"
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
                WriteLiteral("\n    <script");
                BeginWriteAttribute("src", " src=\"", 251, "\"", 310, 1);
#nullable restore
#line 15 "/Users/jettdurante/Desktop/361Capstone/361Capstone/361Capstone/Views/Checkout/Index.cshtml"
WriteAttributeValue("", 257, Url.Content("~/Content/Scripts/jquery-3.6.0.min.js"), 257, 53, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\n\n\n");
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
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9588a2da1ead849aaba260fcb4f2e27fa43c2af8074", async() => {
                WriteLiteral("\n    <a style=\"float:right;margin-left:5px\" class=\"btn btn-danger\"");
                BeginWriteAttribute("href", " href=\"", 405, "\"", 442, 1);
#nullable restore
#line 21 "/Users/jettdurante/Desktop/361Capstone/361Capstone/361Capstone/Views/Checkout/Index.cshtml"
WriteAttributeValue("", 412, Url.Action("Logout", "Login"), 412, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" role=\"button\">Log out</a>\n    <a style=\"float:right\" class=\"btn btn-primary\"");
                BeginWriteAttribute("href", " href=\"", 520, "\"", 596, 1);
#nullable restore
#line 22 "/Users/jettdurante/Desktop/361Capstone/361Capstone/361Capstone/Views/Checkout/Index.cshtml"
WriteAttributeValue("", 527, Url.Action("Index", "UserCart", new { userId = ViewData["UserId"] }), 527, 69, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" role=\"button\">View Cart</a>\n    <div class=\"grid-container\">\n\n\n        <div class=\"list\">\n\n            <h1>Checkout</h1>\n            <h3>Cart Items</h3>\n\n            <ul class=\"list-group\">\n");
#nullable restore
#line 32 "/Users/jettdurante/Desktop/361Capstone/361Capstone/361Capstone/Views/Checkout/Index.cshtml"
                 foreach (Product item in (List<Product>)ViewData["Products"]) {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <li class=\"list-group-item\">\n                        ");
#nullable restore
#line 34 "/Users/jettdurante/Desktop/361Capstone/361Capstone/361Capstone/Views/Checkout/Index.cshtml"
                   Write(item.GetName());

#line default
#line hidden
#nullable disable
                WriteLiteral(" (");
#nullable restore
#line 34 "/Users/jettdurante/Desktop/361Capstone/361Capstone/361Capstone/Views/Checkout/Index.cshtml"
                                    Write(item.GetStockCount());

#line default
#line hidden
#nullable disable
                WriteLiteral("x)\n                        <p style=\"float:right\">$");
#nullable restore
#line 35 "/Users/jettdurante/Desktop/361Capstone/361Capstone/361Capstone/Views/Checkout/Index.cshtml"
                                           Write(Decimal.Round((decimal)(item.GetPrice() * item.GetStockCount()), 2));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n                    </li>\n");
#nullable restore
#line 37 "/Users/jettdurante/Desktop/361Capstone/361Capstone/361Capstone/Views/Checkout/Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </ul>\n            <h5 style=\"float:right\">Subtotal: $");
#nullable restore
#line 40 "/Users/jettdurante/Desktop/361Capstone/361Capstone/361Capstone/Views/Checkout/Index.cshtml"
                                          Write(ViewData["Subtotal"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\n            <br />\n\n            <ul style=\"list-style-type:none;\" class=\"space\">\n            </ul>\n        </div>\n        <hr />\n        <div class=\"paymentInfo\">\n            <h3>Payment Information</h3>\n            <p>Credit Card Number: ");
#nullable restore
#line 49 "/Users/jettdurante/Desktop/361Capstone/361Capstone/361Capstone/Views/Checkout/Index.cshtml"
                              Write(ViewData["CreditCardNumber"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n            <p>Expiration Month/Year: ");
#nullable restore
#line 50 "/Users/jettdurante/Desktop/361Capstone/361Capstone/361Capstone/Views/Checkout/Index.cshtml"
                                 Write(ViewData["ExpirationMonth"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("/");
#nullable restore
#line 50 "/Users/jettdurante/Desktop/361Capstone/361Capstone/361Capstone/Views/Checkout/Index.cshtml"
                                                              Write(ViewData["ExpirationYear"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n            <p>CVV Code: ");
#nullable restore
#line 51 "/Users/jettdurante/Desktop/361Capstone/361Capstone/361Capstone/Views/Checkout/Index.cshtml"
                    Write(ViewData["CVVCode"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n        </div>\n        <hr />\n        <div class=\"addressInfo\">\n            <h3>Address Information</h3>\n            <p>Street: ");
#nullable restore
#line 56 "/Users/jettdurante/Desktop/361Capstone/361Capstone/361Capstone/Views/Checkout/Index.cshtml"
                  Write(ViewData["Street"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n            <p>City: ");
#nullable restore
#line 57 "/Users/jettdurante/Desktop/361Capstone/361Capstone/361Capstone/Views/Checkout/Index.cshtml"
                Write(ViewData["City"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n            <p>State: ");
#nullable restore
#line 58 "/Users/jettdurante/Desktop/361Capstone/361Capstone/361Capstone/Views/Checkout/Index.cshtml"
                 Write(ViewData["State"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n            <p>Zip Code: ");
#nullable restore
#line 59 "/Users/jettdurante/Desktop/361Capstone/361Capstone/361Capstone/Views/Checkout/Index.cshtml"
                    Write(ViewData["ZipCode"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n            <p>Country: ");
#nullable restore
#line 60 "/Users/jettdurante/Desktop/361Capstone/361Capstone/361Capstone/Views/Checkout/Index.cshtml"
                   Write(ViewData["Country"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n        </div>\n\n        <a class=\"btn btn-success\" id=\"transactionButton\"");
                BeginWriteAttribute("href", " href=\'", 2075, "\'", 2165, 1);
#nullable restore
#line 63 "/Users/jettdurante/Desktop/361Capstone/361Capstone/361Capstone/Views/Checkout/Index.cshtml"
WriteAttributeValue("", 2082, Url.Action("CompleteTransaction", "Checkout", new { userId = ViewData["UserId"] }), 2082, 83, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" role=\"button\">Complete Transaction</a>\n\n    </div>\n");
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
            WriteLiteral("\n</html>\n\n<script>\n    $(document).ready(function () {\n        if (");
#nullable restore
#line 71 "/Users/jettdurante/Desktop/361Capstone/361Capstone/361Capstone/Views/Checkout/Index.cshtml"
       Write(ViewData["TotalProducts"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" == 0) {\n            $(\'#transactionButton\').hide();\n        }\n    })\n\n\n    function addItemToCart(userId, productId, count) {\n        location.href = \'");
#nullable restore
#line 78 "/Users/jettdurante/Desktop/361Capstone/361Capstone/361Capstone/Views/Checkout/Index.cshtml"
                    Write(Url.Action("AddItemToCart", "ProductDetails"));

#line default
#line hidden
#nullable disable
            WriteLiteral("?userId=\' + userId + \'&productId=\' + productId + \"&count=\" + count;\n    }\n</script>");
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
