#pragma checksum "C:\Users\SahibAkbar\Desktop\BackEnd\EduHomeProcekt(Edmin)\Eduhome\Views\CourseDetails\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05f5373048234ccf6fb076541602c0e3a70109a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CourseDetails_Index), @"mvc.1.0.view", @"/Views/CourseDetails/Index.cshtml")]
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
#line 1 "C:\Users\SahibAkbar\Desktop\BackEnd\EduHomeProcekt(Edmin)\Eduhome\Views\_ViewImports.cshtml"
using Eduhome;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SahibAkbar\Desktop\BackEnd\EduHomeProcekt(Edmin)\Eduhome\Views\_ViewImports.cshtml"
using Eduhome.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05f5373048234ccf6fb076541602c0e3a70109a3", @"/Views/CourseDetails/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6091ccab12f21ca0012fc9480c7c06eee40dc83c", @"/Views/_ViewImports.cshtml")]
    public class Views_CourseDetails_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Eduhome.Models.ViewModels.HomeModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("http://preview.hasthemes.com/eduhome/mail.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "BlogDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mr-10 mb-10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\SahibAkbar\Desktop\BackEnd\EduHomeProcekt(Edmin)\Eduhome\Views\CourseDetails\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Banner Area Start -->
<div class=""banner-area-wrapper"">
    <div class=""banner-area text-center"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <div class=""banner-content-wrapper"">
                        <div class=""banner-content"">
                            <h2>Courses details</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Banner Area End -->
<!-- Blog Start -->
<div class=""courses-details-area blog-area pt-150 pb-140"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8"">
                <div class=""courses-details"">
                    <div class=""courses-details-img"">
                        <img src=""img/course/courses-details.jpg"" alt=""courses-details"">
                    </div>
                    <div class=""course-details-content"">
                        <h2>");
#nullable restore
#line 33 "C:\Users\SahibAkbar\Desktop\BackEnd\EduHomeProcekt(Edmin)\Eduhome\Views\CourseDetails\Index.cshtml"
                       Write(Model.CourseContent.FirstHead);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                        <p>");
#nullable restore
#line 34 "C:\Users\SahibAkbar\Desktop\BackEnd\EduHomeProcekt(Edmin)\Eduhome\Views\CourseDetails\Index.cshtml"
                      Write(Model.CourseContent.FirstTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n                        <div class=\"course-details-left\">\n                            <div class=\"single-course-left\">\n                                <h3>");
#nullable restore
#line 37 "C:\Users\SahibAkbar\Desktop\BackEnd\EduHomeProcekt(Edmin)\Eduhome\Views\CourseDetails\Index.cshtml"
                               Write(Model.CourseContent.SecondHead);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                                <p>");
#nullable restore
#line 38 "C:\Users\SahibAkbar\Desktop\BackEnd\EduHomeProcekt(Edmin)\Eduhome\Views\CourseDetails\Index.cshtml"
                              Write(Model.CourseContent.SecondTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            </div>\n                            <div class=\"single-course-left\">\n                                <h3>");
#nullable restore
#line 41 "C:\Users\SahibAkbar\Desktop\BackEnd\EduHomeProcekt(Edmin)\Eduhome\Views\CourseDetails\Index.cshtml"
                               Write(Model.CourseContent.ThirdHead);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                                <p>");
#nullable restore
#line 42 "C:\Users\SahibAkbar\Desktop\BackEnd\EduHomeProcekt(Edmin)\Eduhome\Views\CourseDetails\Index.cshtml"
                              Write(Model.CourseContent.ThirdTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            </div>\n                            <div class=\"single-course-left\">\n                                <h3>");
#nullable restore
#line 45 "C:\Users\SahibAkbar\Desktop\BackEnd\EduHomeProcekt(Edmin)\Eduhome\Views\CourseDetails\Index.cshtml"
                               Write(Model.CourseContent.SecondHead);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                                <p class=\"margin\">");
#nullable restore
#line 46 "C:\Users\SahibAkbar\Desktop\BackEnd\EduHomeProcekt(Edmin)\Eduhome\Views\CourseDetails\Index.cshtml"
                                             Write(Model.CourseContent.SecondTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                <p>I must explain to you how all this a mistaken idea of ncing great explorer of the rut the is lder of human</p>
                            </div>
                        </div>
                        <div class=""course-details-right"">
                            <h3>COURSE FEATURES</h3>
                            <ul>
                                <li>starts <span>");
#nullable restore
#line 53 "C:\Users\SahibAkbar\Desktop\BackEnd\EduHomeProcekt(Edmin)\Eduhome\Views\CourseDetails\Index.cshtml"
                                            Write(Model.CourseFeature.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\n                                <li>duration <span>");
#nullable restore
#line 54 "C:\Users\SahibAkbar\Desktop\BackEnd\EduHomeProcekt(Edmin)\Eduhome\Views\CourseDetails\Index.cshtml"
                                              Write(Model.CourseFeature.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\n                                <li>class duration <span>");
#nullable restore
#line 55 "C:\Users\SahibAkbar\Desktop\BackEnd\EduHomeProcekt(Edmin)\Eduhome\Views\CourseDetails\Index.cshtml"
                                                    Write(Model.CourseFeature.ClassDuration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\n                                <li>skill level <span>");
#nullable restore
#line 56 "C:\Users\SahibAkbar\Desktop\BackEnd\EduHomeProcekt(Edmin)\Eduhome\Views\CourseDetails\Index.cshtml"
                                                 Write(Model.CourseFeature.SkillLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\n                                <li>language <span>");
#nullable restore
#line 57 "C:\Users\SahibAkbar\Desktop\BackEnd\EduHomeProcekt(Edmin)\Eduhome\Views\CourseDetails\Index.cshtml"
                                              Write(Model.CourseFeature.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\n                                <li>students <span>");
#nullable restore
#line 58 "C:\Users\SahibAkbar\Desktop\BackEnd\EduHomeProcekt(Edmin)\Eduhome\Views\CourseDetails\Index.cshtml"
                                              Write(Model.CourseFeature.Student);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\n                                <li>assesments <span>");
#nullable restore
#line 59 "C:\Users\SahibAkbar\Desktop\BackEnd\EduHomeProcekt(Edmin)\Eduhome\Views\CourseDetails\Index.cshtml"
                                                Write(Model.CourseFeature.Assesment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\n                            </ul>\n                            <h3 class=\"red\">course fee $");
#nullable restore
#line 61 "C:\Users\SahibAkbar\Desktop\BackEnd\EduHomeProcekt(Edmin)\Eduhome\Views\CourseDetails\Index.cshtml"
                                                   Write(Model.CourseFeature.CoursePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                        </div>
                    </div>
                    <div class=""reply-area"">
                        <h3>LEAVE A REPLY</h3>
                        <p>I must explain to you how all this a mistaken idea of ncing great explorer of the rut<br> the is lder of human happinescias unde omnis iste natus error sit volptatem </p>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05f5373048234ccf6fb076541602c0e3a70109a313930", async() => {
                WriteLiteral(@"
                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <p>Name</p>
                                    <input type=""text"" name=""name"" id=""name"">
                                </div>
                                <div class=""col-md-12"">
                                    <p>Email</p>
                                    <input type=""text"" name=""email"" id=""email"">
                                </div>
                                <div class=""col-md-12"">
                                    <p>Subject</p>
                                    <input type=""text"" name=""subject"" id=""subject"">
                                    <p>Massage</p>
                                    <textarea name=""message"" id=""message"" cols=""15"" rows=""10""></textarea>
                                </div>
                            </div>
                            <a class=""reply-btn"" href=""#"" data-text=""send""><span>send message</span></a>
     ");
                WriteLiteral("                       <p class=\"form-messege\"></p>\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""blog-sidebar right"">
                    <div class=""single-blog-widget mb-50"">
                        <h3>search</h3>
                        <div class=""blog-search"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05f5373048234ccf6fb076541602c0e3a70109a317039", async() => {
                WriteLiteral(@"
                                <input type=""search"" placeholder=""Search..."" name=""search"" />
                                <button type=""submit"">
                                    <span><i class=""fa fa-search""></i></span>
                                </button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </div>\n                    </div>\n                    <div class=\"single-blog-widget mb-50\">\n                        <h3>categories</h3>\n                        <ul>\n");
#nullable restore
#line 106 "C:\Users\SahibAkbar\Desktop\BackEnd\EduHomeProcekt(Edmin)\Eduhome\Views\CourseDetails\Index.cshtml"
                             foreach (var item in Model.CourseCategories)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><a href=\"#\">");
#nullable restore
#line 108 "C:\Users\SahibAkbar\Desktop\BackEnd\EduHomeProcekt(Edmin)\Eduhome\Views\CourseDetails\Index.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (10)</a></li>\n");
#nullable restore
#line 109 "C:\Users\SahibAkbar\Desktop\BackEnd\EduHomeProcekt(Edmin)\Eduhome\Views\CourseDetails\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                    </div>
                    <div class=""single-blog-widget mb-50"">
                        <div class=""single-blog-banner"">
                            <a href=""blog-details.html"" id=""blog""><img src=""img/blog/blog-img.jpg"" alt=""blog""></a>
                            <h2>best<br> eductaion<br> theme</h2>
                        </div>
                    </div>
                    <div class=""single-blog-widget mb-50"">
                        <h3>latest post</h3>
                        <div class=""single-post mb-30"">
                            <div class=""single-post-img"">
                                <a href=""blog-details.html"">
                                    <img src=""img/post/post1.jpg"" alt=""post"">
                                    <div class=""blog-hover"">
                                        <i class=""fa fa-link""></i>
                                    </div>
                                </a>
                            </div>
            ");
            WriteLiteral(@"                <div class=""single-post-content"">
                                <h4><a href=""blog-details.html"">English Language Course for you</a></h4>
                                <p>By Alex  /  June 20, 2017</p>
                            </div>
                        </div>
                        <div class=""single-post mb-30"">
                            <div class=""single-post-img"">
                                <a href=""blog-details.html"">
                                    <img src=""img/post/post2.jpg"" alt=""post"">
                                    <div class=""blog-hover"">
                                        <i class=""fa fa-link""></i>
                                    </div>
                                </a>
                            </div>
                            <div class=""single-post-content"">
                                <h4><a href=""blog-details.html"">Advance Web Design and Develop</a></h4>
                                <p>By Alex  /  June 20, 2017</p>
           ");
            WriteLiteral(@"                 </div>
                        </div>
                        <div class=""single-post"">
                            <div class=""single-post-img"">
                                <a href=""blog-details.html"">
                                    <img src=""img/post/post3.jpg"" alt=""post"">
                                    <div class=""blog-hover"">
                                        <i class=""fa fa-link""></i>
                                    </div>
                                </a>
                            </div>
                            <div class=""single-post-content"">
                                <h4><a href=""blog-details.html"">English Language Course for you</a></h4>
                                <p>By Alex  /  June 20, 2017</p>
                            </div>
                        </div>
                    </div>
                    <div class=""single-blog-widget"">
                        <h3>tags</h3>
                        <div class=""single-tag"">
");
#nullable restore
#line 166 "C:\Users\SahibAkbar\Desktop\BackEnd\EduHomeProcekt(Edmin)\Eduhome\Views\CourseDetails\Index.cshtml"
                             foreach (var item in Model.Tags)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05f5373048234ccf6fb076541602c0e3a70109a323366", async() => {
#nullable restore
#line 168 "C:\Users\SahibAkbar\Desktop\BackEnd\EduHomeProcekt(Edmin)\Eduhome\Views\CourseDetails\Index.cshtml"
                                                                                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 169 "C:\Users\SahibAkbar\Desktop\BackEnd\EduHomeProcekt(Edmin)\Eduhome\Views\CourseDetails\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n<!-- Blog End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Eduhome.Models.ViewModels.HomeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
