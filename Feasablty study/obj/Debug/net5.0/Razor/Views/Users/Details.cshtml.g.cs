#pragma checksum "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\vsproject\Feasablty study\Feasablty study\Views\Users\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b233b4ff0032a0e5ab71c8319e04d0fa3355fe63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Details), @"mvc.1.0.view", @"/Views/Users/Details.cshtml")]
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
#line 1 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\vsproject\Feasablty study\Feasablty study\Views\Users\Details.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b233b4ff0032a0e5ab71c8319e04d0fa3355fe63", @"/Views/Users/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34f8f78b09a0e14c77f08661eda7af36e6972da1", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Feasablty_study.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning me-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-label-success suspend-user"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\vsproject\Feasablty study\Feasablty study\Views\Users\Details.cshtml"
  
    ViewData["Title"] = "عرض التفاصيل للمستخدم";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <h1>عرض التفاصيل للمستخدم</h1> 
            <div class=""row"">
              <div class=""authentication-wrapper authentication-basic container-p-y"">
                  <!-- User Card -->
               <div class=""authentication-inner py-4"">
                  <div class=""card"">
                    <div class=""card-body"">
                      <div class=""user-avatar-section"">
                        <div class=""d-flex flex-column align-items-center"">
                          <img class=""img-fluid rounded my-4"" src=""../../assets/img/avatars/adminuser.png"" height=""110"" width=""110"" alt=""User avatar"">
                          <div class=""user-info text-center"">
                            <h5 class=""mb-2"">");
#nullable restore
#line 20 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\vsproject\Feasablty study\Feasablty study\Views\Users\Details.cshtml"
                                        Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                          </div>
                        </div>
                      </div>
                      <h5 class=""border-bottom pb-2 mb-4"">التفاصيل</h5>
                      <div class=""info-container"">
                        <ul class=""list-unstyled"">
                          <li class=""mb-3"">
                            <span class=""fw-bold me-2"">اسم المستخدم:</span>
                            <span>");
#nullable restore
#line 29 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\vsproject\Feasablty study\Feasablty study\Views\Users\Details.cshtml"
                             Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                          </li>\r\n                          <li class=\"mb-3\">\r\n                            <span class=\"fw-bold me-2\">الأيمل :</span>\r\n                            <span>");
#nullable restore
#line 33 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\vsproject\Feasablty study\Feasablty study\Views\Users\Details.cshtml"
                             Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                          </li>
                          <li class=""mb-3"">
                            <span class=""fw-bold me-2"">الحالة:</span>
                            <span class=""badge bg-label-success"">نشط</span>
                          </li>
                          <li class=""mb-3"">
                            <span class=""fw-bold me-2"">الايميل:</span>
                            <span>");
#nullable restore
#line 41 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\vsproject\Feasablty study\Feasablty study\Views\Users\Details.cshtml"
                             Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                          </li>\r\n                          <li class=\"mb-3\">\r\n                            <span class=\"fw-bold me-2\">رقم الهاتف:</span>\r\n                            <span>");
#nullable restore
#line 45 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\vsproject\Feasablty study\Feasablty study\Views\Users\Details.cshtml"
                             Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                          </li>\r\n                          <li class=\"mb-3\">\r\n                            <span class=\"fw-bold me-2\">تاريخ الانشاء</span>\r\n                            <span>");
#nullable restore
#line 49 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\vsproject\Feasablty study\Feasablty study\Views\Users\Details.cshtml"
                             Write(Html.DisplayFor(model => model.CreationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                          </li>\r\n                            <li class=\"mb-3\">\r\n                            <span class=\"fw-bold me-2\">نوع المستخدم:</span>\r\n                            \r\n");
#nullable restore
#line 54 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\vsproject\Feasablty study\Feasablty study\Views\Users\Details.cshtml"
                             if(await UserManager.IsInRoleAsync(Model,"Admin"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span> ادمن</span>\r\n");
#nullable restore
#line 57 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\vsproject\Feasablty study\Feasablty study\Views\Users\Details.cshtml"
                                
                                }
                                else 
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                      <span> مستخدم عادي</span>\r\n");
#nullable restore
#line 62 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\vsproject\Feasablty study\Feasablty study\Views\Users\Details.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                           \r\n                          </li>\r\n                        </ul>\r\n\r\n                       <hr/>\r\n                <div class=\"d-flex justify-content-center pt-3\">\r\n                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b233b4ff0032a0e5ab71c8319e04d0fa3355fe6310577", async() => {
                WriteLiteral("تعديل");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "D:\كلية الحاسوب\مستوى رابع\مشروع التخرج\vsproject\Feasablty study\Feasablty study\Views\Users\Details.cshtml"
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
            WriteLiteral("\r\n                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b233b4ff0032a0e5ab71c8319e04d0fa3355fe6312904", async() => {
                WriteLiteral("عودة للقائمة ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>         \r\n                 </div>\r\n                   </div>\r\n                    </div>\r\n                  </div>\r\n                </div>\r\n               </div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Feasablty_study.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
