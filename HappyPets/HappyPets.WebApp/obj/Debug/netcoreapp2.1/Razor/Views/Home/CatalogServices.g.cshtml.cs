#pragma checksum "/Volumes/MacExtraStorage/HappyPets/HappyPets/HappyPets.WebApp/Views/Home/CatalogServices.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbfc74204889cd1c1142f577f06ddd3223217c92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CatalogServices), @"mvc.1.0.view", @"/Views/Home/CatalogServices.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CatalogServices.cshtml", typeof(AspNetCore.Views_Home_CatalogServices))]
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
#line 1 "/Volumes/MacExtraStorage/HappyPets/HappyPets/HappyPets.WebApp/Views/_ViewImports.cshtml"
using HappyPets.WebApp;

#line default
#line hidden
#line 2 "/Volumes/MacExtraStorage/HappyPets/HappyPets/HappyPets.WebApp/Views/_ViewImports.cshtml"
using HappyPets.WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbfc74204889cd1c1142f577f06ddd3223217c92", @"/Views/Home/CatalogServices.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb110666c54e9bdef34a39961dd5e051ff70fcc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CatalogServices : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline HP-SearchForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Volumes/MacExtraStorage/HappyPets/HappyPets/HappyPets.WebApp/Views/Home/CatalogServices.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 229, true);
            WriteLiteral("\r\n<!-- Main Content -->\r\n<!-- TODO check responsive on mobile, After fix footer section -->\r\n<main class=\"row\">\r\n    <section class=\"col-4\">\r\n        <div class=\"row col-12 my-3\">\r\n            <h2>Find Services</h2>\r\n            ");
            EndContext();
            BeginContext(274, 375, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6d38e5b2ea2465a82275d7963bef8e1", async() => {
                BeginContext(324, 318, true);
                WriteLiteral(@"
                <input class=""HP-SearchForm_input text-right"" type=""search"" placeholder=""Search"" aria-label=""Search"">
                <button class=""HP-SearchForm_button justify-content-end"" type=""submit"">
                    <i class=""fa fa-search text-primary"">&nbsp;</i>
                </button>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            BeginContext(649, 185, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"row col-12 my-3\">\r\n            <p>\r\n                Order By Price:\r\n                <span>\r\n                    <select>\r\n                        ");
            EndContext();
            BeginContext(834, 27, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e86a900f95f9447e80fa2bdde13c462b", async() => {
                BeginContext(842, 10, true);
                WriteLiteral("Low Price ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(861, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(887, 29, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "338310970cfa4c9db0ced2242f84198e", async() => {
                BeginContext(895, 12, true);
                WriteLiteral("Hight Price ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(916, 207, true);
            WriteLiteral("\r\n                    </select>\r\n                </span>\r\n            </p>\r\n            <p>\r\n                Order By Pet Type:\r\n                <span>\r\n                    <select>\r\n                        ");
            EndContext();
            BeginContext(1123, 20, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79e0d39ff1674344ad91b1e97c05265e", async() => {
                BeginContext(1131, 3, true);
                WriteLiteral("Cat");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1143, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1169, 20, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df256e0ab2824821955f120568a93257", async() => {
                BeginContext(1177, 3, true);
                WriteLiteral("Dog");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1189, 3599, true);
            WriteLiteral(@"
                    </select>
                </span>
            </p>
        </div>
    </section>
    <section class=""col-8"">
        <section class=""my-3"">
            <div class=""row col-12"">
                <h2>Services</h2>
            </div>
        </section>
        <section class=""row my-3"">
            <div class=""col-12 col-sm-6 col-md-4 col-lg-3 mb-3"">
                <div class=""card"">
                    <img class=""card-img-top"" src=""http://via.placeholder.com/240"" alt=""Third slide"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Product Name</h5>
                        <p class=""card-text text-secondary"">$19.00</p>
                        <a href=""#"" class=""btn btn-primary"">View More</a>
                    </div>
                </div>
            </div>
            <div class=""col-12 col-sm-6 col-md-4 col-lg-3 mb-3"">
                <div class=""card"">
                    <img class=""card-img-top"" src=""http://via.placeho");
            WriteLiteral(@"lder.com/240"" alt=""Third slide"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Product Name</h5>
                        <p class=""card-text text-secondary"">$19.00</p>
                        <a href=""#"" class=""btn btn-primary"">View More</a>
                    </div>
                </div>
            </div>
            <div class=""col-12 col-sm-6 col-md-4 col-lg-3 mb-3"">
                <div class=""card"">
                    <img class=""card-img-top"" src=""http://via.placeholder.com/240"" alt=""Third slide"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Product Name</h5>
                        <p class=""card-text text-secondary"">$19.00</p>
                        <a href=""#"" class=""btn btn-primary"">View More</a>
                    </div>
                </div>
            </div>
            <div class=""col-12 col-sm-6 col-md-4 col-lg-3 mb-3"">
                <div class=""card"">
                    <im");
            WriteLiteral(@"g class=""card-img-top"" src=""http://via.placeholder.com/240"" alt=""Third slide"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Product Name</h5>
                        <p class=""card-text text-secondary"">$19.00</p>
                        <a href=""#"" class=""btn btn-primary"">View More</a>
                    </div>
                </div>
            </div>
            <div class=""col-12 col-sm-6 col-md-4 col-lg-3 mb-3"">
                <div class=""card"">
                    <img class=""card-img-top"" src=""http://via.placeholder.com/240"" alt=""Third slide"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Product Name</h5>
                        <p class=""card-text text-secondary"">$19.00</p>
                        <a href=""#"" class=""btn btn-primary"">View More</a>
                    </div>
                </div>
            </div>
            <div class=""col-12 col-sm-6 col-md-4 col-lg-3 mb-3"">
             ");
            WriteLiteral(@"   <div class=""card"">
                    <img class=""card-img-top"" src=""http://via.placeholder.com/240"" alt=""Third slide"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Product Name</h5>
                        <p class=""card-text text-secondary"">$19.00</p>
                        <a href=""#"" class=""btn btn-primary"">View More</a>
                    </div>
                </div>
            </div>
        </section>
    </section>

</main>
<!-- End Main Content --");
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