#pragma checksum "D:\zhaoxi\OpenCourse\20200214微服务架构之网关Gateway\Zhaoxi.MicroService.ClientDemo\Zhaoxi.MicroService.ClientDemo\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a08da87d40fce8bae54795d45413602f3a3a57a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\zhaoxi\OpenCourse\20200214微服务架构之网关Gateway\Zhaoxi.MicroService.ClientDemo\Zhaoxi.MicroService.ClientDemo\Views\_ViewImports.cshtml"
using Zhaoxi.MicroService.ClientDemo;

#line default
#line hidden
#line 2 "D:\zhaoxi\OpenCourse\20200214微服务架构之网关Gateway\Zhaoxi.MicroService.ClientDemo\Zhaoxi.MicroService.ClientDemo\Views\_ViewImports.cshtml"
using Zhaoxi.MicroService.ClientDemo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a08da87d40fce8bae54795d45413602f3a3a57a6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a9f4f32d4f551c87884998420ba6f33c00d214e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\zhaoxi\OpenCourse\20200214微服务架构之网关Gateway\Zhaoxi.MicroService.ClientDemo\Zhaoxi.MicroService.ClientDemo\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <h2>当前的学员们：</h2>\r\n");
#line 8 "D:\zhaoxi\OpenCourse\20200214微服务架构之网关Gateway\Zhaoxi.MicroService.ClientDemo\Zhaoxi.MicroService.ClientDemo\Views\Home\Index.cshtml"
     foreach (var user in base.ViewBag.Users)
    {

#line default
#line hidden
            WriteLiteral("        <p>");
#line 10 "D:\zhaoxi\OpenCourse\20200214微服务架构之网关Gateway\Zhaoxi.MicroService.ClientDemo\Zhaoxi.MicroService.ClientDemo\Views\Home\Index.cshtml"
      Write(user.Name);

#line default
#line hidden
            WriteLiteral("</p>\r\n");
#line 11 "D:\zhaoxi\OpenCourse\20200214微服务架构之网关Gateway\Zhaoxi.MicroService.ClientDemo\Zhaoxi.MicroService.ClientDemo\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            WriteLiteral("    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n");
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
