#pragma checksum "C:\Users\Michał\source\repos\WebApplication7\WebApplication7\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cae8f1e884a30be1c291ae22cbd529ecdcb2f68a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Michał\source\repos\WebApplication7\WebApplication7\Views\_ViewImports.cshtml"
using WebApplication7;

#line default
#line hidden
#line 2 "C:\Users\Michał\source\repos\WebApplication7\WebApplication7\Views\_ViewImports.cshtml"
using WebApplication7.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cae8f1e884a30be1c291ae22cbd529ecdcb2f68a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7dc31cafed32aad956e8e002afa406e7283b5ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 3 "C:\Users\Michał\source\repos\WebApplication7\WebApplication7\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "witaj";

#line default
#line hidden
            BeginContext(45, 189, true);
            WriteLiteral("Dzien dobry!\r\nPodaj Login i Haslo\r\n<br/>\r\n<input type=\"text\" id=\"log\" value=\"Login\"> <br /> <br/>\r\n<input type=\"text\" id=\"has\" value=\"Haslo\" /> <br/>\r\n\r\n<input type=\"button\" value=\"Zaloguj\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 234, "\"", 408, 9);
            WriteAttributeValue("", 244, "location.href=\'", 244, 15, true);
#line 12 "C:\Users\Michał\source\repos\WebApplication7\WebApplication7\Views\Home\Index.cshtml"
WriteAttributeValue("", 259, Url.Action("Zaloguj_admin", "Pracownicy"), 259, 42, false);

#line default
#line hidden
            WriteAttributeValue("", 301, "?login=\'", 301, 8, true);
            WriteAttributeValue(" ", 309, "+", 310, 2, true);
            WriteAttributeValue(" ", 311, "document.getElementById(\'log\').value", 312, 37, true);
            WriteAttributeValue(" ", 348, "+", 349, 2, true);
            WriteAttributeValue(" ", 350, "\'&haslo=\'", 351, 10, true);
            WriteAttributeValue(" \r\n       ", 360, "+", 370, 11, true);
            WriteAttributeValue(" ", 371, "document.getElementById(\'has\').value", 372, 37, true);
            EndWriteAttribute();
            BeginContext(409, 13, true);
            WriteLiteral(" />\r\n\r\n\r\n\r\n\r\n");
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
