#pragma checksum "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "169b1df3d9e78081461b35f617dc23e2b96d91cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Sidebar), @"mvc.1.0.view", @"/Views/Shared/_Sidebar.cshtml")]
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
#line 1 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/_ViewImports.cshtml"
using studio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/_ViewImports.cshtml"
using studio.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"169b1df3d9e78081461b35f617dc23e2b96d91cd", @"/Views/Shared/_Sidebar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17bd241ee090bd8b39c0cf55b12cb73c6c44cc0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Sidebar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("menu-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
  
    var menuController = ViewContext.RouteData.Values["controller"].ToString();
    var menuAction = ViewContext.RouteData.Values["action"].ToString();
    var sidebarMenu = Configuration.GetSection("sidebarMenu").GetChildren().ToArray();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- BEGIN #sidebar -->\r\n<div id=\"sidebar\" class=\"app-sidebar\">\r\n    <!-- BEGIN scrollbar -->\r\n    <div class=\"app-sidebar-content\" data-scrollbar=\"true\" data-height=\"100%\">\r\n        <!-- BEGIN menu -->\r\n        <div class=\"menu\">\r\n");
#nullable restore
#line 15 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
             foreach (var menu in sidebarMenu)
            {
                var menuChildren = menu.GetSection("children").GetChildren().ToArray();

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
                 if (menu["is_header"] != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"menu-header\">\r\n                        ");
#nullable restore
#line 22 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
                   Write(menu["text"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 24 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
                }else if(menu["is_divider"] != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"menu-divider\"></div>\r\n");
#nullable restore
#line 27 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("class", " class=\"", 1111, "\"", 1229, 3);
            WriteAttributeValue("", 1119, "menu-item", 1119, 9, true);
#nullable restore
#line 30 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
WriteAttributeValue(" ", 1128, menuController == @menu["controller"] ? "active" : "", 1129, 56, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
WriteAttributeValue(" ", 1185, menuChildren.Length > 0 ? "has-sub" : "", 1186, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 31 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
                         if (menu["action"] != null && menu["controller"] != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "169b1df3d9e78081461b35f617dc23e2b96d91cd6806", async() => {
                WriteLiteral("\r\n                                <span class=\"menu-icon\">\r\n");
#nullable restore
#line 35 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
                                     if (menu["icon"] != null)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <i");
                BeginWriteAttribute("class", " class=\"", 1664, "\"", 1685, 1);
#nullable restore
#line 37 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
WriteAttributeValue("", 1672, menu["icon"], 1672, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i>\r\n");
#nullable restore
#line 38 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
                                     if (menu["label"] != null)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <span class=\"menu-icon-label\">");
#nullable restore
#line 41 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
                                                                 Write(menu["label"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
#nullable restore
#line 42 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </span>\r\n                                <span class=\"menu-text\">");
#nullable restore
#line 44 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
                                                   Write(menu["text"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
                                   WriteLiteral(menu["controller"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
                                                                    WriteLiteral(menu["action"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 46 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a href=\"#\" class=\"menu-link\">\r\n                                <span class=\"menu-icon\">\r\n");
#nullable restore
#line 51 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
                                     if (menu["icon"] != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i");
            BeginWriteAttribute("class", " class=\"", 2468, "\"", 2489, 1);
#nullable restore
#line 53 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
WriteAttributeValue("", 2476, menu["icon"], 2476, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n");
#nullable restore
#line 54 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
                                     if (menu["label"] != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"menu-icon-label\">");
#nullable restore
#line 57 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
                                                                 Write(menu["label"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 58 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </span>\r\n                                <span class=\"menu-text\">");
#nullable restore
#line 60 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
                                                   Write(menu["text"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 61 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
                                 if (menuChildren.Length > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"menu-caret\"><b class=\"caret\"></b></span>\r\n");
#nullable restore
#line 64 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </a>\r\n");
#nullable restore
#line 66 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
                         if (menuChildren.Length > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"menu-submenu\">\r\n");
#nullable restore
#line 70 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
                                 foreach (var submenu in menuChildren)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div");
            BeginWriteAttribute("class", " class=\"", 3461, "\"", 3530, 2);
            WriteAttributeValue("", 3469, "menu-item", 3469, 9, true);
#nullable restore
#line 72 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
WriteAttributeValue(" ", 3478, menuAction == @submenu["action"] ? "active" : "", 3479, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "169b1df3d9e78081461b35f617dc23e2b96d91cd16053", async() => {
                WriteLiteral("\r\n                                            <span class=\"menu-text\">");
#nullable restore
#line 74 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
                                                               Write(submenu["text"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
                                               WriteLiteral(submenu["controller"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
                                                                                   WriteLiteral(submenu["action"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n");
#nullable restore
#line 77 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n");
#nullable restore
#line 79 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n");
#nullable restore
#line 81 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "/Users/amejia/qa/Proy Temperatura/fhir_panel/AspStudio/Views/Shared/_Sidebar.cshtml"
                 

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <!-- END menu -->
    </div>
    <!-- END scrollbar -->
    <!-- BEGIN mobile-sidebar-backdrop -->
    <button class=""app-sidebar-mobile-backdrop"" data-dismiss=""sidebar-mobile""></button>
    <!-- END mobile-sidebar-backdrop -->
</div>
<!-- END #sidebar -->");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration Configuration { get; private set; }
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
