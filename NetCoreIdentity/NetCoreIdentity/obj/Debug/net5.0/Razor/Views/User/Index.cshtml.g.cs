#pragma checksum "C:\Users\FatihGunalp\Desktop\YZL3156\NetCore\14.06.2022\NetCoreIdentity\NetCoreIdentity\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8401f213460c41459402dbfb7e2b3bfaa9c53b14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#line 1 "C:\Users\FatihGunalp\Desktop\YZL3156\NetCore\14.06.2022\NetCoreIdentity\NetCoreIdentity\Views\_ViewImports.cshtml"
using NetCoreIdentity.Models.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FatihGunalp\Desktop\YZL3156\NetCore\14.06.2022\NetCoreIdentity\NetCoreIdentity\Views\_ViewImports.cshtml"
using NetCoreIdentity.Models.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8401f213460c41459402dbfb7e2b3bfaa9c53b14", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db05c36b404973e3d1af5c348646735211d10327", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\FatihGunalp\Desktop\YZL3156\NetCore\14.06.2022\NetCoreIdentity\NetCoreIdentity\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>#</th>\r\n            <th>Email</th>\r\n            <th>Username</th>\r\n            <th>Birthdate</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 18 "C:\Users\FatihGunalp\Desktop\YZL3156\NetCore\14.06.2022\NetCoreIdentity\NetCoreIdentity\Views\User\Index.cshtml"
         foreach (var user in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\FatihGunalp\Desktop\YZL3156\NetCore\14.06.2022\NetCoreIdentity\NetCoreIdentity\Views\User\Index.cshtml"
               Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\FatihGunalp\Desktop\YZL3156\NetCore\14.06.2022\NetCoreIdentity\NetCoreIdentity\Views\User\Index.cshtml"
               Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\FatihGunalp\Desktop\YZL3156\NetCore\14.06.2022\NetCoreIdentity\NetCoreIdentity\Views\User\Index.cshtml"
               Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\FatihGunalp\Desktop\YZL3156\NetCore\14.06.2022\NetCoreIdentity\NetCoreIdentity\Views\User\Index.cshtml"
               Write(user.BirthDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td></td>\r\n            </tr>\r\n");
#nullable restore
#line 27 "C:\Users\FatihGunalp\Desktop\YZL3156\NetCore\14.06.2022\NetCoreIdentity\NetCoreIdentity\Views\User\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
