#pragma checksum "C:\Users\Khanh\Desktop\IT\ShopOnline\Pro3_Sem3\Pro3_Sem3\Views\User\MenuDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7540e48eac17d090c7ad70e7690a04480b62eaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_MenuDetails), @"mvc.1.0.view", @"/Views/User/MenuDetails.cshtml")]
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
#line 1 "C:\Users\Khanh\Desktop\IT\ShopOnline\Pro3_Sem3\Pro3_Sem3\Views\_ViewImports.cshtml"
using Pro3_Sem3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Khanh\Desktop\IT\ShopOnline\Pro3_Sem3\Pro3_Sem3\Views\_ViewImports.cshtml"
using Pro3_Sem3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7540e48eac17d090c7ad70e7690a04480b62eaf", @"/Views/User/MenuDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b26446643e76dab2b1714337323c173ebb6ec0d8", @"/Views/_ViewImports.cshtml")]
    public class Views_User_MenuDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Pro3_Sem3.Models.PaymentDetail>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Khanh\Desktop\IT\ShopOnline\Pro3_Sem3\Pro3_Sem3\Views\User\MenuDetails.cshtml"
  
    ViewBag.Title = "Giỏ hàng của bạn";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>");
#nullable restore
#line 8 "C:\Users\Khanh\Desktop\IT\ShopOnline\Pro3_Sem3\Pro3_Sem3\Views\User\MenuDetails.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Khanh\Desktop\IT\ShopOnline\Pro3_Sem3\Pro3_Sem3\Views\User\MenuDetails.cshtml"
 if (Model == null 

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Khanh\Desktop\IT\ShopOnline\Pro3_Sem3\Pro3_Sem3\Views\User\MenuDetails.cshtml"
                                          )
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"text-info text-center\">\r\n        Giỏ hàng của bạn rỗng!\r\n    </p>\r\n");
#nullable restore
#line 15 "C:\Users\Khanh\Desktop\IT\ShopOnline\Pro3_Sem3\Pro3_Sem3\Views\User\MenuDetails.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-sm-12"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"">
                    <tr>
                        <th>Hình</th>
                        <th>Tên sản phẩm</th>
                        <th>Số lượng</th>
                        <th>Đơn giá</th>
                        <th>Thành tiền</th>
                        <th></th>
                    </tr>
");
#nullable restore
#line 30 "C:\Users\Khanh\Desktop\IT\ShopOnline\Pro3_Sem3\Pro3_Sem3\Views\User\MenuDetails.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n");
            WriteLiteral("                            <td><a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\'", 1059, "\'", 1128, 1);
#nullable restore
#line 34 "C:\Users\Khanh\Desktop\IT\ShopOnline\Pro3_Sem3\Pro3_Sem3\Views\User\MenuDetails.cshtml"
WriteAttributeValue("", 1066, Url.Action("ShowFood", "Cart", new { food_id = item.Foodid }), 1066, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 34 "C:\Users\Khanh\Desktop\IT\ShopOnline\Pro3_Sem3\Pro3_Sem3\Views\User\MenuDetails.cshtml"
                                                                                                                     Write(item.Food.Foodname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a> </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7540e48eac17d090c7ad70e7690a04480b62eaf6511", async() => {
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"food_id\"");
                BeginWriteAttribute("value", " value=\"", 1403, "\"", 1423, 1);
#nullable restore
#line 37 "C:\Users\Khanh\Desktop\IT\ShopOnline\Pro3_Sem3\Pro3_Sem3\Views\User\MenuDetails.cshtml"
WriteAttributeValue("", 1411, item.Foodid, 1411, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    <input type=\"number\" min=\"1\" step=\"1\" name=\"soluongmoi\"");
                BeginWriteAttribute("value", " value=\"", 1520, "\"", 1542, 1);
#nullable restore
#line 38 "C:\Users\Khanh\Desktop\IT\ShopOnline\Pro3_Sem3\Pro3_Sem3\Views\User\MenuDetails.cshtml"
WriteAttributeValue("", 1528, item.Quantity, 1528, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    <button type=\"submit\" class=\"btn btn-primary btn-sm\"> Cập nhật </button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 36 "C:\Users\Khanh\Desktop\IT\ShopOnline\Pro3_Sem3\Pro3_Sem3\Views\User\MenuDetails.cshtml"
AddHtmlAttributeValue("", 1243, Url.Action("UpdateQuantity","Cart", new { soluongmoi = item.Quantity }), 1243, 72, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                            <td> ");
#nullable restore
#line 42 "C:\Users\Khanh\Desktop\IT\ShopOnline\Pro3_Sem3\Pro3_Sem3\Views\User\MenuDetails.cshtml"
                            Write(item.Food.Foodprice.ToString("#,##0").Replace(',', '.'));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ </td>\r\n                            <td> ");
#nullable restore
#line 43 "C:\Users\Khanh\Desktop\IT\ShopOnline\Pro3_Sem3\Pro3_Sem3\Views\User\MenuDetails.cshtml"
                            Write(item.Total.ToString("#,##0").Replace(',', '.'));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ </td>\r\n\r\n                            <td> <a");
            BeginWriteAttribute("href", " href=\'", 1964, "\'", 2027, 1);
#nullable restore
#line 45 "C:\Users\Khanh\Desktop\IT\ShopOnline\Pro3_Sem3\Pro3_Sem3\Views\User\MenuDetails.cshtml"
WriteAttributeValue("", 1971, Url.Action("DeleteItem", new { food_id = item.Foodid }), 1971, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Bạn có chắc muốn xóa sản phẩm này?\');\" class=\"btn btn-danger btn-sm\">Xóa</a> </td>\r\n                        </tr>\r\n");
#nullable restore
#line 47 "C:\Users\Khanh\Desktop\IT\ShopOnline\Pro3_Sem3\Pro3_Sem3\Views\User\MenuDetails.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td></td>\r\n                        <td class=\"text-right\">Tổng số lượng:</td>\r\n                        <td> ");
#nullable restore
#line 51 "C:\Users\Khanh\Desktop\IT\ShopOnline\Pro3_Sem3\Pro3_Sem3\Views\User\MenuDetails.cshtml"
                        Write(Model.Sum(m => m.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td class=\"text-right\">Tổng thành tiền:</td>\r\n                        <td>");
#nullable restore
#line 53 "C:\Users\Khanh\Desktop\IT\ShopOnline\Pro3_Sem3\Pro3_Sem3\Views\User\MenuDetails.cshtml"
                       Write(Model.Sum(m => m.Total).ToString("#,##0").Replace(',', '.'));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ </td>\r\n                    </tr>\r\n                </table>\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n");
#nullable restore
#line 61 "C:\Users\Khanh\Desktop\IT\ShopOnline\Pro3_Sem3\Pro3_Sem3\Views\User\MenuDetails.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Pro3_Sem3.Models.PaymentDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
