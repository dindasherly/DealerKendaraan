#pragma checksum "C:\Users\User\Downloads\New folder (8)\DealerKendaraanMVC\DealerKendaraanMVC\Views\Admin\KendaraanDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "088aad9764da793c0657e38eab5eb5549ea8c560"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_KendaraanDetails), @"mvc.1.0.view", @"/Views/Admin/KendaraanDetails.cshtml")]
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
#line 1 "C:\Users\User\Downloads\New folder (8)\DealerKendaraanMVC\DealerKendaraanMVC\Views\_ViewImports.cshtml"
using DealerKendaraanMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Downloads\New folder (8)\DealerKendaraanMVC\DealerKendaraanMVC\Views\_ViewImports.cshtml"
using DealerKendaraanMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"088aad9764da793c0657e38eab5eb5549ea8c560", @"/Views/Admin/KendaraanDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31829d6210b1844228df9b2ae54d664f204646ce", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_KendaraanDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DealerKendaraanMVC.Models.Produk>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "KendaraanEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Kendaraan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Downloads\New folder (8)\DealerKendaraanMVC\DealerKendaraanMVC\Views\Admin\KendaraanDetails.cshtml"
  
    Layout = "./_Layout.cshtml";
    ViewData["Title"] = "MerkDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""py-3"">
        <span style=""border-radius: 20px; background-color: darkcyan; padding:10px 30px;"">
            Kendaraan
        </span>
    </h1>

    <h2 class=""text-light"">Detail Data Kendaraan</h2>
</div>

<div>
    <hr />
    <dl class=""row"">
        <dt class=""col-sm-2"">
            ");
#nullable restore
#line 22 "C:\Users\User\Downloads\New folder (8)\DealerKendaraanMVC\DealerKendaraanMVC\Views\Admin\KendaraanDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Gambar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 25 "C:\Users\User\Downloads\New folder (8)\DealerKendaraanMVC\DealerKendaraanMVC\Views\Admin\KendaraanDetails.cshtml"
             if (Model.Gambar != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img");
            BeginWriteAttribute("src", " src=\"", 637, "\"", 705, 2);
            WriteAttributeValue("", 643, "data:image/jpeg;base64,", 643, 23, true);
#nullable restore
#line 27 "C:\Users\User\Downloads\New folder (8)\DealerKendaraanMVC\DealerKendaraanMVC\Views\Admin\KendaraanDetails.cshtml"
WriteAttributeValue("", 666, Convert.ToBase64String(Model.Gambar), 666, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 28 "C:\Users\User\Downloads\New folder (8)\DealerKendaraanMVC\DealerKendaraanMVC\Views\Admin\KendaraanDetails.cshtml"
            } else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>No Image</span>\r\n");
#nullable restore
#line 31 "C:\Users\User\Downloads\New folder (8)\DealerKendaraanMVC\DealerKendaraanMVC\Views\Admin\KendaraanDetails.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "C:\Users\User\Downloads\New folder (8)\DealerKendaraanMVC\DealerKendaraanMVC\Views\Admin\KendaraanDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Nama));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "C:\Users\User\Downloads\New folder (8)\DealerKendaraanMVC\DealerKendaraanMVC\Views\Admin\KendaraanDetails.cshtml"
       Write(Html.DisplayFor(model => model.Nama));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "C:\Users\User\Downloads\New folder (8)\DealerKendaraanMVC\DealerKendaraanMVC\Views\Admin\KendaraanDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Warna));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "C:\Users\User\Downloads\New folder (8)\DealerKendaraanMVC\DealerKendaraanMVC\Views\Admin\KendaraanDetails.cshtml"
       Write(Html.DisplayFor(model => model.Warna));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "C:\Users\User\Downloads\New folder (8)\DealerKendaraanMVC\DealerKendaraanMVC\Views\Admin\KendaraanDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.HargaSatuan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "C:\Users\User\Downloads\New folder (8)\DealerKendaraanMVC\DealerKendaraanMVC\Views\Admin\KendaraanDetails.cshtml"
       Write(Html.DisplayFor(model => model.HargaSatuan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 52 "C:\Users\User\Downloads\New folder (8)\DealerKendaraanMVC\DealerKendaraanMVC\Views\Admin\KendaraanDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.StokBarang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 55 "C:\Users\User\Downloads\New folder (8)\DealerKendaraanMVC\DealerKendaraanMVC\Views\Admin\KendaraanDetails.cshtml"
       Write(Html.DisplayFor(model => model.StokBarang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 58 "C:\Users\User\Downloads\New folder (8)\DealerKendaraanMVC\DealerKendaraanMVC\Views\Admin\KendaraanDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Merk));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 61 "C:\Users\User\Downloads\New folder (8)\DealerKendaraanMVC\DealerKendaraanMVC\Views\Admin\KendaraanDetails.cshtml"
       Write(Html.DisplayFor(model => model.Merk.Nama));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 64 "C:\Users\User\Downloads\New folder (8)\DealerKendaraanMVC\DealerKendaraanMVC\Views\Admin\KendaraanDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Pemasok));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 67 "C:\Users\User\Downloads\New folder (8)\DealerKendaraanMVC\DealerKendaraanMVC\Views\Admin\KendaraanDetails.cshtml"
       Write(Html.DisplayFor(model => model.Pemasok.Alamat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "088aad9764da793c0657e38eab5eb5549ea8c56010520", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\User\Downloads\New folder (8)\DealerKendaraanMVC\DealerKendaraanMVC\Views\Admin\KendaraanDetails.cshtml"
                                    WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "088aad9764da793c0657e38eab5eb5549ea8c56012705", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DealerKendaraanMVC.Models.Produk> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591