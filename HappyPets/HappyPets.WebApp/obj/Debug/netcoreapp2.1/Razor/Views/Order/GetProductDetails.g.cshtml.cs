#pragma checksum "C:\Revature\CoffeeINTOCode\HappyPets\HappyPets.WebApp\Views\Order\GetProductDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f312648bdf95cece7be6bcf143f9a1bd9fd276b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_GetProductDetails), @"mvc.1.0.view", @"/Views/Order/GetProductDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/GetProductDetails.cshtml", typeof(AspNetCore.Views_Order_GetProductDetails))]
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
#line 1 "C:\Revature\CoffeeINTOCode\HappyPets\HappyPets.WebApp\Views\_ViewImports.cshtml"
using HappyPets.WebApp;

#line default
#line hidden
#line 2 "C:\Revature\CoffeeINTOCode\HappyPets\HappyPets.WebApp\Views\_ViewImports.cshtml"
using HappyPets.WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f312648bdf95cece7be6bcf143f9a1bd9fd276b", @"/Views/Order/GetProductDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b5e0bd1e18c7b851c0c41fdf41cc90bf0e9a029", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_GetProductDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddProductsToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Revature\CoffeeINTOCode\HappyPets\HappyPets.WebApp\Views\Order\GetProductDetails.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 294, true);
            WriteLiteral(@"<!-- Main Content -->
<main class=""row"">
    <section class=""col-12 col-md-8 my-3"">
        <div>
            <img class=""img-fluid"" src=""http://via.placeholder.com/932x567"" alt=""product"" />
        </div>
        <div>
            <H3>Description</H3>
            <p>
                ");
            EndContext();
            BeginContext(340, 24, false);
#line 13 "C:\Revature\CoffeeINTOCode\HappyPets\HappyPets.WebApp\Views\Order\GetProductDetails.cshtml"
           Write(Model.ProductDescription);

#line default
#line hidden
            EndContext();
            BeginContext(364, 105, true);
            WriteLiteral(";\r\n            </p>\r\n        </div>\r\n    </section>\r\n    <section class=\"col-12 col-md-4 my-3\">\r\n        ");
            EndContext();
            BeginContext(469, 866, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7938fe5701a447b1a7dfab0eb60d4ff2", async() => {
                BeginContext(543, 140, true);
                WriteLiteral("\r\n            <button type=\"submit\" class=\"btn btn-outline-primary btn-lg\"> Add to Cart </button>\r\n            <H3 class=\"font-weight-bold\">");
                EndContext();
                BeginContext(684, 18, false);
#line 20 "C:\Revature\CoffeeINTOCode\HappyPets\HappyPets.WebApp\Views\Order\GetProductDetails.cshtml"
                                    Write(Model.ProductNames);

#line default
#line hidden
                EndContext();
                BeginContext(702, 64, true);
                WriteLiteral("</H3>\r\n            <H3 class=\"font-weight-bold text-secondary\">$");
                EndContext();
                BeginContext(767, 18, false);
#line 21 "C:\Revature\CoffeeINTOCode\HappyPets\HappyPets.WebApp\Views\Order\GetProductDetails.cshtml"
                                                    Write(Model.ProductPrice);

#line default
#line hidden
                EndContext();
                BeginContext(785, 52, true);
                WriteLiteral("</H3>\r\n            <label>QTY:</label>\r\n            ");
                EndContext();
                BeginContext(838, 405, false);
#line 23 "C:\Revature\CoffeeINTOCode\HappyPets\HappyPets.WebApp\Views\Order\GetProductDetails.cshtml"
       Write(Html.DropDownList("selectedQuantity", new List<SelectListItem> {
                new SelectListItem() { Text= "1", Value = "1"},
                new SelectListItem() { Text= "2", Value = "2"},
                new SelectListItem() { Text= "3", Value = "3"},
                new SelectListItem() { Text= "4", Value = "4"},
                new SelectListItem() { Text= "5", Value = "5"},
            }));

#line default
#line hidden
                EndContext();
                BeginContext(1243, 47, true);
                WriteLiteral("\r\n\r\n            <input hidden name=\"selectedId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1290, "\"", 1314, 1);
#line 31 "C:\Revature\CoffeeINTOCode\HappyPets\HappyPets.WebApp\Views\Order\GetProductDetails.cshtml"
WriteAttributeValue("", 1298, Model.ProductId, 1298, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1315, 13, true);
                WriteLiteral(" />\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
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
            BeginContext(1335, 54, true);
            WriteLiteral("\r\n    </section>\r\n</main>\r\n<!-- End Main Content -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
