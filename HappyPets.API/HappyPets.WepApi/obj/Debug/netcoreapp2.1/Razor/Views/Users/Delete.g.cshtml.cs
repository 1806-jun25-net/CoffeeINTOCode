#pragma checksum "/Volumes/MacExtraStorage/HappyPets/HappyPets.API/HappyPets.WepApi/Views/Users/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1a683cb1bd26c5263c563ac431dda9915463ebd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Delete), @"mvc.1.0.view", @"/Views/Users/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Delete.cshtml", typeof(AspNetCore.Views_Users_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1a683cb1bd26c5263c563ac431dda9915463ebd", @"/Views/Users/Delete.cshtml")]
    public class Views_Users_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HappyPets.Data.Users>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Volumes/MacExtraStorage/HappyPets/HappyPets.API/HappyPets.WepApi/Views/Users/Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(68, 157, true);
            WriteLiteral("\n<h2>Delete</h2>\n\n<h3>Are you sure you want to delete this?</h3>\n<div>\n    <h4>Users</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(226, 45, false);
#line 15 "/Volumes/MacExtraStorage/HappyPets/HappyPets.API/HappyPets.WepApi/Views/Users/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(271, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(312, 41, false);
#line 18 "/Volumes/MacExtraStorage/HappyPets/HappyPets.API/HappyPets.WepApi/Views/Users/Delete.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(353, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(394, 44, false);
#line 21 "/Volumes/MacExtraStorage/HappyPets/HappyPets.API/HappyPets.WepApi/Views/Users/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(438, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(479, 40, false);
#line 24 "/Volumes/MacExtraStorage/HappyPets/HappyPets.API/HappyPets.WepApi/Views/Users/Delete.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(519, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(560, 41, false);
#line 27 "/Volumes/MacExtraStorage/HappyPets/HappyPets.API/HappyPets.WepApi/Views/Users/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(601, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(642, 37, false);
#line 30 "/Volumes/MacExtraStorage/HappyPets/HappyPets.API/HappyPets.WepApi/Views/Users/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(679, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(720, 45, false);
#line 33 "/Volumes/MacExtraStorage/HappyPets/HappyPets.API/HappyPets.WepApi/Views/Users/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Passwords));

#line default
#line hidden
            EndContext();
            BeginContext(765, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(806, 41, false);
#line 36 "/Volumes/MacExtraStorage/HappyPets/HappyPets.API/HappyPets.WepApi/Views/Users/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Passwords));

#line default
#line hidden
            EndContext();
            BeginContext(847, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(888, 49, false);
#line 39 "/Volumes/MacExtraStorage/HappyPets/HappyPets.API/HappyPets.WepApi/Views/Users/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.StreetAddress));

#line default
#line hidden
            EndContext();
            BeginContext(937, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(978, 45, false);
#line 42 "/Volumes/MacExtraStorage/HappyPets/HappyPets.API/HappyPets.WepApi/Views/Users/Delete.cshtml"
       Write(Html.DisplayFor(model => model.StreetAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1023, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1064, 44, false);
#line 45 "/Volumes/MacExtraStorage/HappyPets/HappyPets.API/HappyPets.WepApi/Views/Users/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee));

#line default
#line hidden
            EndContext();
            BeginContext(1108, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1149, 51, false);
#line 48 "/Volumes/MacExtraStorage/HappyPets/HappyPets.API/HappyPets.WepApi/Views/Users/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.EmployeeId));

#line default
#line hidden
            EndContext();
            BeginContext(1200, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1241, 44, false);
#line 51 "/Volumes/MacExtraStorage/HappyPets/HappyPets.API/HappyPets.WepApi/Views/Users/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(1285, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1326, 51, false);
#line 54 "/Volumes/MacExtraStorage/HappyPets/HappyPets.API/HappyPets.WepApi/Views/Users/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Location.LocationId));

#line default
#line hidden
            EndContext();
            BeginContext(1377, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1418, 54, false);
#line 57 "/Volumes/MacExtraStorage/HappyPets/HappyPets.API/HappyPets.WepApi/Views/Users/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UserTypeNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1472, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1513, 58, false);
#line 60 "/Volumes/MacExtraStorage/HappyPets/HappyPets.API/HappyPets.WepApi/Views/Users/Delete.cshtml"
       Write(Html.DisplayFor(model => model.UserTypeNavigation.TypesId));

#line default
#line hidden
            EndContext();
            BeginContext(1571, 250, true);
            WriteLiteral("\n        </dd>\n    </dl>\n    \n    <form asp-action=\"Delete\">\n        <input type=\"hidden\" asp-for=\"UsersId\" />\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\n        <a asp-action=\"Index\">Back to List</a>\n    </form>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HappyPets.Data.Users> Html { get; private set; }
    }
}
#pragma warning restore 1591