#pragma checksum "C:\Users\Ginger\source\repos\GRUD\GRUD\Views\Contact\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b96a21fb9cc5599c1ad1b5707746432d07795f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Details), @"mvc.1.0.view", @"/Views/Contact/Details.cshtml")]
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
#line 1 "C:\Users\Ginger\source\repos\GRUD\GRUD\Views\_ViewImports.cshtml"
using GRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ginger\source\repos\GRUD\GRUD\Views\_ViewImports.cshtml"
using GRUD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b96a21fb9cc5599c1ad1b5707746432d07795f0", @"/Views/Contact/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dec4c9bd5b58b511842419376538c49ee7b0afb", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GRUD.Models.ContactDetailViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<label>Vooraam</label>\r\n<p><strong>");
#nullable restore
#line 4 "C:\Users\Ginger\source\repos\GRUD\GRUD\Views\Contact\Details.cshtml"
      Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n\r\n<label>Famillienaam</label>\r\n<p><strong>");
#nullable restore
#line 7 "C:\Users\Ginger\source\repos\GRUD\GRUD\Views\Contact\Details.cshtml"
      Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n\r\n<label>Leeftijd</label>\r\n<p><strong>");
#nullable restore
#line 10 "C:\Users\Ginger\source\repos\GRUD\GRUD\Views\Contact\Details.cshtml"
      Write(ageCalculator(Model.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n\r\n<label>Email adres</label>\r\n<p><strong>");
#nullable restore
#line 13 "C:\Users\Ginger\source\repos\GRUD\GRUD\Views\Contact\Details.cshtml"
      Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n\r\n<label>Telefoon nummer</label>\r\n<p><strong>");
#nullable restore
#line 16 "C:\Users\Ginger\source\repos\GRUD\GRUD\Views\Contact\Details.cshtml"
      Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n\r\n<label>Adres</label>\r\n<p><strong>");
#nullable restore
#line 19 "C:\Users\Ginger\source\repos\GRUD\GRUD\Views\Contact\Details.cshtml"
      Write(Model.Adress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n\r\n<label>Beschrijving</label>\r\n<p><strong>");
#nullable restore
#line 22 "C:\Users\Ginger\source\repos\GRUD\GRUD\Views\Contact\Details.cshtml"
      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n<label>Categorie</label>\r\n<p><strong>");
#nullable restore
#line 24 "C:\Users\Ginger\source\repos\GRUD\GRUD\Views\Contact\Details.cshtml"
      Write(Model.C);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n\r\n<label>Foto</label>\r\n<img");
            BeginWriteAttribute("src", " src=\"", 640, "\"", 681, 1);
#nullable restore
#line 27 "C:\Users\Ginger\source\repos\GRUD\GRUD\Views\Contact\Details.cshtml"
WriteAttributeValue("", 646, ConvertBytesToImg(Model.ImageName), 646, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display:block\" />\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\Ginger\source\repos\GRUD\GRUD\Views\Contact\Details.cshtml"
           
    string ageCalculator(DateTime DateOfBirth)
    {
        int age = DateTime.Today.Year - DateOfBirth.Year;

        if (DateOfBirth.Date > DateTime.Today.AddYears(-age)) age--;
        return age.ToString();
    }

    string ConvertBytesToImg(Byte[] image)
    {
        string imreBase64Data = Convert.ToBase64String(image);

        return $"data:image/png;base64,{imreBase64Data}";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GRUD.Models.ContactDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
