#pragma checksum "C:\Revature\CoffeeINTOCode\HappyPets.API\HappyPets.WepApi\Views\Users\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "474de9478f5e291facccead933b0225f3990dd80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Create), @"mvc.1.0.view", @"/Views/Users/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Create.cshtml", typeof(AspNetCore.Views_Users_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"474de9478f5e291facccead933b0225f3990dd80", @"/Views/Users/Create.cshtml")]
    public class Views_Users_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HappyPets.Data.Users>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Revature\CoffeeINTOCode\HappyPets.API\HappyPets.WepApi\Views\Users\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
            BeginContext(73, 2581, true);
            WriteLiteral(@"
<h2>Create</h2>

<h4>Users</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""FirstName"" class=""control-label""></label>
                <input asp-for=""FirstName"" class=""form-control"" />
                <span asp-validation-for=""FirstName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""LastName"" class=""control-label""></label>
                <input asp-for=""LastName"" class=""form-control"" />
                <span asp-validation-for=""LastName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Email"" class=""control-label""></label>
                <input asp-for=""Email"" class=""form-control"" />
                <span asp-validation-for=""Email"" class=""text-danger""></span>
  ");
            WriteLiteral(@"          </div>
            <div class=""form-group"">
                <label asp-for=""Passwords"" class=""control-label""></label>
                <input asp-for=""Passwords"" class=""form-control"" />
                <span asp-validation-for=""Passwords"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""StreetAddress"" class=""control-label""></label>
                <input asp-for=""StreetAddress"" class=""form-control"" />
                <span asp-validation-for=""StreetAddress"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""LocationId"" class=""control-label""></label>
                <select asp-for=""LocationId"" class =""form-control"" asp-items=""ViewBag.LocationId""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""EmployeeId"" class=""control-label""></label>
                <select asp-for=""EmployeeId"" class =""form-control"" asp-");
            WriteLiteral(@"items=""ViewBag.EmployeeId""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""UserType"" class=""control-label""></label>
                <select asp-for=""UserType"" class =""form-control"" asp-items=""ViewBag.UserType""></select>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-default"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2672, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 64 "C:\Revature\CoffeeINTOCode\HappyPets.API\HappyPets.WepApi\Views\Users\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HappyPets.Data.Users> Html { get; private set; }
    }
}
#pragma warning restore 1591
