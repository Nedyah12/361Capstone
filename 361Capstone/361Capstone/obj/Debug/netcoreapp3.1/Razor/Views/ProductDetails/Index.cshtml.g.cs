#pragma checksum "C:\Users\Isa\Source\Repos\361Capstone\361Capstone\361Capstone\Views\ProductDetails\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4aa02d71f5c2d15f5b17e729f8d8ad47ccbb1dfb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductDetails_Index), @"mvc.1.0.view", @"/Views/ProductDetails/Index.cshtml")]
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
#line 1 "C:\Users\Isa\Source\Repos\361Capstone\361Capstone\361Capstone\Views\_ViewImports.cshtml"
using _361Capstone;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Isa\Source\Repos\361Capstone\361Capstone\361Capstone\Views\ProductDetails\Index.cshtml"
using _361Capstone.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4aa02d71f5c2d15f5b17e729f8d8ad47ccbb1dfb", @"/Views/ProductDetails/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"951126843324e2aa577432d9ee3cb10c60289f20", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductDetails_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Isa\Source\Repos\361Capstone\361Capstone\361Capstone\Views\ProductDetails\Index.cshtml"
  
    Layout = "_Layout";

    ViewBag.Title = ViewData["Title"];


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4aa02d71f5c2d15f5b17e729f8d8ad47ccbb1dfb5013", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4aa02d71f5c2d15f5b17e729f8d8ad47ccbb1dfb5279", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "C:\Users\Isa\Source\Repos\361Capstone\361Capstone\361Capstone\Views\ProductDetails\Index.cshtml"
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
#line 13 "C:\Users\Isa\Source\Repos\361Capstone\361Capstone\361Capstone\Views\ProductDetails\Index.cshtml"
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
                WriteLiteral("\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 249, "\"", 308, 1);
#nullable restore
#line 14 "C:\Users\Isa\Source\Repos\361Capstone\361Capstone\361Capstone\Views\ProductDetails\Index.cshtml"
WriteAttributeValue("", 255, Url.Content("~/Content/Scripts/jquery-3.6.0.min.js"), 255, 53, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\r\n\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4aa02d71f5c2d15f5b17e729f8d8ad47ccbb1dfb8750", async() => {
                WriteLiteral(@"

    <div style=""display:none"" id=""addSuccess"" class=""alert alert-success"" role=""alert"">
        This item was successfully added to your cart.
    </div>
    <div style=""display:none"" id=""addFail"" class=""alert alert-danger"" role=""alert"">
        Error: There was a problem adding this item to your cart.
    </div>
    <a style=""float:right;margin-left:5px"" class=""btn btn-danger""");
                BeginWriteAttribute("href", " href=\"", 732, "\"", 769, 1);
#nullable restore
#line 27 "C:\Users\Isa\Source\Repos\361Capstone\361Capstone\361Capstone\Views\ProductDetails\Index.cshtml"
WriteAttributeValue("", 739, Url.Action("Logout", "Login"), 739, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" role=\"button\">Log out</a>\r\n    <a style=\"float:right\" class=\"btn btn-primary\"");
                BeginWriteAttribute("href", " href=\"", 848, "\"", 924, 1);
#nullable restore
#line 28 "C:\Users\Isa\Source\Repos\361Capstone\361Capstone\361Capstone\Views\ProductDetails\Index.cshtml"
WriteAttributeValue("", 855, Url.Action("Index", "UserCart", new { userId = ViewData["UserId"] }), 855, 69, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" role=\"button\">View Cart</a>\r\n    <div class=\"grid-container\">\r\n\r\n\r\n        <div class=\"list\">\r\n\r\n            <h1>");
#nullable restore
#line 34 "C:\Users\Isa\Source\Repos\361Capstone\361Capstone\361Capstone\Views\ProductDetails\Index.cshtml"
           Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n            <h4><strong>Price:</strong> $");
#nullable restore
#line 35 "C:\Users\Isa\Source\Repos\361Capstone\361Capstone\361Capstone\Views\ProductDetails\Index.cshtml"
                                    Write(ViewData["Price"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n            <p><strong>Description:</strong> ");
#nullable restore
#line 36 "C:\Users\Isa\Source\Repos\361Capstone\361Capstone\361Capstone\Views\ProductDetails\Index.cshtml"
                                        Write(ViewData["Description"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <p><strong>Manufacturer Info:</strong> ");
#nullable restore
#line 37 "C:\Users\Isa\Source\Repos\361Capstone\361Capstone\361Capstone\Views\ProductDetails\Index.cshtml"
                                              Write(ViewData["ManInfo"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <p><strong>Dimensions:</strong> ");
#nullable restore
#line 38 "C:\Users\Isa\Source\Repos\361Capstone\361Capstone\361Capstone\Views\ProductDetails\Index.cshtml"
                                       Write(ViewData["Dimensions"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <p><strong>Weight:</strong> ");
#nullable restore
#line 39 "C:\Users\Isa\Source\Repos\361Capstone\361Capstone\361Capstone\Views\ProductDetails\Index.cshtml"
                                   Write(ViewData["Weight"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("lbs</p>\r\n            <p><strong>Rating:</strong> ");
#nullable restore
#line 40 "C:\Users\Isa\Source\Repos\361Capstone\361Capstone\361Capstone\Views\ProductDetails\Index.cshtml"
                                   Write(ViewData["Rating"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <p><strong>Amount in Stock:</strong> ");
#nullable restore
#line 41 "C:\Users\Isa\Source\Repos\361Capstone\361Capstone\361Capstone\Views\ProductDetails\Index.cshtml"
                                            Write(ViewData["StockCount"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n            <!--Lists items-->\r\n            <!--For loop to add spaces-->\r\n            <ul style=\"list-style-type:none;\" class=\"space\">\r\n            </ul>\r\n        </div>\r\n\r\n        <div class=\"addToCart\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4aa02d71f5c2d15f5b17e729f8d8ad47ccbb1dfb13322", async() => {
                    WriteLiteral(@"
                <hr />
                <!--<label for=""username""><b>Username</b></label>
                <input type=""text"" class=""txtInput"" id=""username"" placeholder=""Enter Username""><br>

                <label for=""password""><b>Password</b></label>
                <input type=""password"" class=""txtInput"" id=""password"" placeholder=""Enter Password""><br>-->
                <!--<label for=""itemQuantity"">Add items to cart: </label>-->
                <input type=""number"" id=""quantity"" name=""itemQuantity"" min=""1""");
                    BeginWriteAttribute("max", " max=\'", 2335, "\'", 2364, 1);
#nullable restore
#line 58 "C:\Users\Isa\Source\Repos\361Capstone\361Capstone\361Capstone\Views\ProductDetails\Index.cshtml"
WriteAttributeValue("", 2341, ViewData["StockCount"], 2341, 23, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" value=\"1\" />\r\n                <input type=\"button\" class=\"submitBtn\" id=\"submitBtn\" value=\"Add to Cart\"");
                    BeginWriteAttribute("onclick", " onclick=\"", 2469, "\"", 2580, 6);
                    WriteAttributeValue("", 2479, "addItemToCart(", 2479, 14, true);
#nullable restore
#line 59 "C:\Users\Isa\Source\Repos\361Capstone\361Capstone\361Capstone\Views\ProductDetails\Index.cshtml"
WriteAttributeValue("", 2493, ViewData["UserId"], 2493, 19, false);

#line default
#line hidden
#nullable disable
                    WriteAttributeValue("", 2512, ",", 2512, 1, true);
#nullable restore
#line 59 "C:\Users\Isa\Source\Repos\361Capstone\361Capstone\361Capstone\Views\ProductDetails\Index.cshtml"
WriteAttributeValue(" ", 2513, ViewData["ProductId"], 2514, 22, false);

#line default
#line hidden
#nullable disable
                    WriteAttributeValue("", 2536, ",", 2536, 1, true);
                    WriteAttributeValue(" ", 2537, "document.getElementById(\'quantity\').value)", 2538, 43, true);
                    EndWriteAttribute();
                    WriteLiteral("><br>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <br /><br />\r\n            <a class=\"btn btn-primary\"");
                BeginWriteAttribute("href", " href=\'", 2673, "\'", 2739, 3);
#nullable restore
#line 62 "C:\Users\Isa\Source\Repos\361Capstone\361Capstone\361Capstone\Views\ProductDetails\Index.cshtml"
WriteAttributeValue("", 2680, Url.Action("Index", "Products"), 2680, 32, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2712, "?userId=", 2712, 8, true);
#nullable restore
#line 62 "C:\Users\Isa\Source\Repos\361Capstone\361Capstone\361Capstone\Views\ProductDetails\Index.cshtml"
WriteAttributeValue("", 2720, ViewData["UserId"], 2720, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" role=\"button\">Go To Products Page</a>\r\n        </div>\r\n\r\n    </div>\r\n");
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
            WriteLiteral("\r\n</html>\r\n\r\n<script>\r\n\r\n    function checkForAddedItem() {\r\n        var addedItemBool = ");
#nullable restore
#line 72 "C:\Users\Isa\Source\Repos\361Capstone\361Capstone\361Capstone\Views\ProductDetails\Index.cshtml"
                       Write(ViewData["AddedItem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
        if (addedItemBool == 1) {
            $('#addSuccess').show();
        } else if(addedItemBool == -1) {
            $('#addFail').show();
        }
    }

    $(document).ready(function () {
        $('#addSuccess', '#addFail').hide();

        checkForAddedItem();
    })



    function addItemToCart(userId, productId, count) {
        location.href = '");
#nullable restore
#line 89 "C:\Users\Isa\Source\Repos\361Capstone\361Capstone\361Capstone\Views\ProductDetails\Index.cshtml"
                    Write(Url.Action("AddItemToCart", "ProductDetails"));

#line default
#line hidden
#nullable disable
            WriteLiteral("?userId=\' + userId + \'&productId=\' + productId + \"&count=\" + count;\r\n    }\r\n</script>");
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
