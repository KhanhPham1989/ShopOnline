#pragma checksum "D:\Apteach2\ShopOnline\Project_Sem3_Final\Pro3_Sem3\Pro3_Sem3\Views\Home\DetailsCaterer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "082bbeba0eec5425b10870398c4bf312aeed3504"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DetailsCaterer), @"mvc.1.0.view", @"/Views/Home/DetailsCaterer.cshtml")]
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
#line 1 "D:\Apteach2\ShopOnline\Project_Sem3_Final\Pro3_Sem3\Pro3_Sem3\Views\_ViewImports.cshtml"
using Pro3_Sem3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Apteach2\ShopOnline\Project_Sem3_Final\Pro3_Sem3\Pro3_Sem3\Views\_ViewImports.cshtml"
using Pro3_Sem3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"082bbeba0eec5425b10870398c4bf312aeed3504", @"/Views/Home/DetailsCaterer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b26446643e76dab2b1714337323c173ebb6ec0d8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DetailsCaterer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pro3_Sem3.Models.CatererFoods>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width:100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "082bbeba0eec5425b10870398c4bf312aeed35045013", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "082bbeba0eec5425b10870398c4bf312aeed35045283", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 6 "D:\Apteach2\ShopOnline\Project_Sem3_Final\Pro3_Sem3\Pro3_Sem3\Views\Home\DetailsCaterer.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\">Name Caterer</label>\r\n                <input class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 345, "\"", 379, 1);
#nullable restore
#line 9 "D:\Apteach2\ShopOnline\Project_Sem3_Final\Pro3_Sem3\Pro3_Sem3\Views\Home\DetailsCaterer.cshtml"
WriteAttributeValue("", 353, Model.CaterersN.Catername, 353, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\">Address</label>\r\n                <input class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 550, "\"", 587, 1);
#nullable restore
#line 14 "D:\Apteach2\ShopOnline\Project_Sem3_Final\Pro3_Sem3\Pro3_Sem3\Views\Home\DetailsCaterer.cshtml"
WriteAttributeValue("", 558, Model.CaterersN.Cateraddress, 558, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\">Describe</label>\r\n                <input class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 759, "\"", 795, 1);
#nullable restore
#line 19 "D:\Apteach2\ShopOnline\Project_Sem3_Final\Pro3_Sem3\Pro3_Sem3\Views\Home\DetailsCaterer.cshtml"
WriteAttributeValue("", 767, Model.CaterersN.Caterstatus, 767, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\">Photo</label>\r\n                <input class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 964, "\"", 999, 1);
#nullable restore
#line 24 "D:\Apteach2\ShopOnline\Project_Sem3_Final\Pro3_Sem3\Pro3_Sem3\Views\Home\DetailsCaterer.cshtml"
WriteAttributeValue("", 972, Model.CaterersN.Caterphone, 972, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\">Phone</label>\r\n                <input class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1168, "\"", 1198, 1);
#nullable restore
#line 29 "D:\Apteach2\ShopOnline\Project_Sem3_Final\Pro3_Sem3\Pro3_Sem3\Views\Home\DetailsCaterer.cshtml"
WriteAttributeValue("", 1176, Model.CaterersN.Photo, 1176, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n            </div>\r\n");
                WriteLiteral("        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        <div class=\"btn btn-primary\">\r\n            <a");
            BeginWriteAttribute("href", " href=\'", 1805, "\'", 1899, 1);
#nullable restore
#line 48 "D:\Apteach2\ShopOnline\Project_Sem3_Final\Pro3_Sem3\Pro3_Sem3\Views\Home\DetailsCaterer.cshtml"
WriteAttributeValue("", 1812, Url.Action("ShowPaymentBeforeGetFood", "Cart",new { resid = Model.CaterersN.Caterid }), 1812, 87, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                Create order\r\n            </a>\r\n            \r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"features_items\">\r\n    <!--features_items-->\r\n    <h2 class=\"title text-center\">Foods</h2>\r\n\r\n \r\n");
#nullable restore
#line 60 "D:\Apteach2\ShopOnline\Project_Sem3_Final\Pro3_Sem3\Pro3_Sem3\Views\Home\DetailsCaterer.cshtml"
         foreach (var item in Model.FoodList)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-sm-4\">\r\n                <div class=\"product-image-wrapper\">\r\n                    <div class=\"single-products\">\r\n                        <div class=\"productinfo text-center\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\'", 2400, "\'", 2407, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "082bbeba0eec5425b10870398c4bf312aeed350412569", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2453, "~/images/food/", 2453, 14, true);
#nullable restore
#line 67 "D:\Apteach2\ShopOnline\Project_Sem3_Final\Pro3_Sem3\Pro3_Sem3\Views\Home\DetailsCaterer.cshtml"
AddHtmlAttributeValue("", 2467, item.Foodimage, 2467, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n                            </a>\r\n                            <h2>sdadsadsa+");
#nullable restore
#line 72 "D:\Apteach2\ShopOnline\Project_Sem3_Final\Pro3_Sem3\Pro3_Sem3\Views\Home\DetailsCaterer.cshtml"
                                     Write(item.Foodname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"choose\">\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 80 "D:\Apteach2\ShopOnline\Project_Sem3_Final\Pro3_Sem3\Pro3_Sem3\Views\Home\DetailsCaterer.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n</div>\r\n<!--San pham moi-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pro3_Sem3.Models.CatererFoods> Html { get; private set; }
    }
}
#pragma warning restore 1591