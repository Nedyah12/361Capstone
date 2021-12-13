#pragma checksum "C:\Users\Owner\Source\Repos\361Capstone\361Capstone\361Capstone\Views\InsertData\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d16e1148fe0f39149aef09d61c140a284af2297"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_InsertData_Index), @"mvc.1.0.view", @"/Views/InsertData/Index.cshtml")]
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
#line 2 "C:\Users\Owner\Source\Repos\361Capstone\361Capstone\361Capstone\Views\_ViewImports.cshtml"
using _361Capstone.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Owner\Source\Repos\361Capstone\361Capstone\361Capstone\Views\InsertData\Index.cshtml"
using _361Capstone.Managers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Owner\Source\Repos\361Capstone\361Capstone\361Capstone\Views\InsertData\Index.cshtml"
using System.Web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d16e1148fe0f39149aef09d61c140a284af2297", @"/Views/InsertData/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"951126843324e2aa577432d9ee3cb10c60289f20", @"/Views/_ViewImports.cshtml")]
    public class Views_InsertData_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d16e1148fe0f39149aef09d61c140a284af22973956", async() => {
                WriteLiteral("\n    \n       <title>Insert Data</title>\n");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d16e1148fe0f39149aef09d61c140a284af22974959", async() => {
                WriteLiteral("\n    <div class=\"alert alert-info\" role=\"alert\">\n        Our records show that you do not have any address/payment information! Please input the needed information to continue to check ot.\n    </div>\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d16e1148fe0f39149aef09d61c140a284af22975425", async() => {
                    WriteLiteral(@"
        <div class=""paymentInfo"">
            <h3>Payment Information</h3>
            <label for=""creditCardNumber""><b>Credit Card Number: </b></label>
            <input type=""number"" id=""creditCardNumber"" name=""creditCardNumber"" />
            <br />
            <label for=""expMonth""><b>Expiration Month: </b></label>
            <input type=""number"" id=""expMonth"" min=""1"" max=""12"" name=""expMonth"" />
            <br />
            <label for=""expYear""><b>Expiration Year: </b></label>
            <input type=""number"" id=""expYear"" min=""2020"" max=""2999"" name=""expYear"" />
            <br />
            <label for=""cvvCode""><b>CVV Code: </b></label>
            <input type=""number"" id=""cvvCode"" min=""1"" max=""999"" name=""cvvCode"" />
        </div>
        <hr />
        <div class=""addressInfo"">
            <h3>Address Information</h3>
            <label for=""street""><b>Street: </b></label>
            <input type=""text"" name=""street"" />
            <br />
            <label for=""city""><b>City: </b></label>
       ");
                    WriteLiteral(@"     <input type=""text"" name=""city"" />
            <br />
            <label for=""state""><b>State: </b></label>
            <input type=""text"" name=""state"" />
            <br />
            <label for=""zipCode""><b>Zip Code: </b></label>
            <input type=""text"" name=""zipCode"" />
            <br />
            <label for=""country""><b>Country: </b></label>
            <input type=""text"" name=""country"" />
        </div>
    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    <br />\n    <a class=\"btn btn-success\"");
                BeginWriteAttribute("href", " href=\'", 1950, "\'", 1957, 0);
                EndWriteAttribute();
                WriteLiteral(" role=\"button\">Save & Continue</a>\n\n\n\n");
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
            WriteLiteral("\n</html>\n\n<script>\n   \n\n</script>\n\n");
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