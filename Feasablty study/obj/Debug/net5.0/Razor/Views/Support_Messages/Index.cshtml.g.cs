#pragma checksum "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\vsproject\Feasablty study\Feasablty study\Views\Support_Messages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8e041610128f72f86625c89301f70971ef7c2be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Support_Messages_Index), @"mvc.1.0.view", @"/Views/Support_Messages/Index.cshtml")]
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
#line 1 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\vsproject\Feasablty study\Feasablty study\Views\_ViewImports.cshtml"
using Feasablty_study;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\vsproject\Feasablty study\Feasablty study\Views\_ViewImports.cshtml"
using Feasablty_study.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\vsproject\Feasablty study\Feasablty study\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8e041610128f72f86625c89301f70971ef7c2be", @"/Views/Support_Messages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34f8f78b09a0e14c77f08661eda7af36e6972da1", @"/Views/_ViewImports.cshtml")]
    public class Views_Support_Messages_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Feasablty_study.Models.Support_Messages>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item text-success Details-record"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Support_Messages", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item text-danger delete-record"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\vsproject\Feasablty study\Feasablty study\Views\Support_Messages\Index.cshtml"
      
    ViewData["Title"] = "عرض الرسائل";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""card"">
    <h4 class=""card-header""> الرسائل</h4>
    <div class=""card-body"">
        <div class=""table-responsive text-nowrap"">
                <meta name=""viewport"" content=""width=device-width"" />
            <table id=""dataTable""  class=""table table-bordered"">
                     <thead>
                         <tr>
                        <th> تسلسل </th>
                        <th> عنوان الرسالة</th>
                        <th>البريد الالكتروني</th>
                        <th> تاريخ الاسال</th>
                        <th>اسم المرسل</th>
                        <th>  الاجراءات</th> 
                       </tr>
                  </thead>

                <tbody>
");
#nullable restore
#line 27 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\vsproject\Feasablty study\Feasablty study\Views\Support_Messages\Index.cshtml"
                     if (Model.Count() == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td colspan=\"3\" style=\"color:red\">\r\n                                لا يوجد نتائج\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 34 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\vsproject\Feasablty study\Feasablty study\Views\Support_Messages\Index.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\vsproject\Feasablty study\Feasablty study\Views\Support_Messages\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                 \r\n                                  <td>");
#nullable restore
#line 41 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\vsproject\Feasablty study\Feasablty study\Views\Support_Messages\Index.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>  ");
#nullable restore
#line 42 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\vsproject\Feasablty study\Feasablty study\Views\Support_Messages\Index.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 43 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\vsproject\Feasablty study\Feasablty study\Views\Support_Messages\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td> ");
#nullable restore
#line 44 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\vsproject\Feasablty study\Feasablty study\Views\Support_Messages\Index.cshtml"
                                Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td> ");
#nullable restore
#line 45 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\vsproject\Feasablty study\Feasablty study\Views\Support_Messages\Index.cshtml"
                                Write(Html.DisplayFor(modelItem => item.user.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                
                            <td>
                            <div class=""dropdown"">
                              <button type=""button"" class=""btn dropdown-toggle hide-arrow p-0"" data-bs-toggle=""dropdown"">
                                <i class=""bx bx-dots-vertical-rounded""></i>
                              </button>
                              <div class=""dropdown-menu"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8e041610128f72f86625c89301f70971ef7c2be9631", async() => {
                WriteLiteral("<i class=\"bx bx-info-circle bx-xs\"></i> عر ض");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-Route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\vsproject\Feasablty study\Feasablty study\Views\Support_Messages\Index.cshtml"
                                                                                                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-Route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8e041610128f72f86625c89301f70971ef7c2be12282", async() => {
                WriteLiteral("<i class=\"bx bx-trash me-1\"></i> حذف");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-Route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\vsproject\Feasablty study\Feasablty study\Views\Support_Messages\Index.cshtml"
                                                                                                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-Route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                              </div>\r\n                            </div>\r\n                          </td>\r\n                            </tr>\r\n");
#nullable restore
#line 59 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\vsproject\Feasablty study\Feasablty study\Views\Support_Messages\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\vsproject\Feasablty study\Feasablty study\Views\Support_Messages\Index.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </tbody>
            </table>
        </div>
    </div>
</div>


<script>
    

    $(document).ready(function () {
        $('#dataTable').DataTable({
            ""language"": {
                ""lengthMenu"": ""عرض _MENU_ سجلات  "",

                ""info"": ""عرض صفحة _PAGE_ من _PAGES_"",
                ""infoEmpty"": ""  لاتوجد بيانات مطابقة للبحث"",
                ""infoFiltered"": ""(الصافي من  _MAX_ اجمالي الصفوف)"",
                ""search"": ""بحث""
            }


        });
    });

</script>
                      ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Feasablty_study.Models.Support_Messages>> Html { get; private set; }
    }
}
#pragma warning restore 1591
