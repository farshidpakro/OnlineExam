#pragma checksum "C:\Users\farshid\source\repos\LMS\LMS\Pages\Studen\Exam.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e012873f067637f6616684bf12f16f9ad2859e70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LMS.Pages.Studen.Pages_Studen_Exam), @"mvc.1.0.razor-page", @"/Pages/Studen/Exam.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Studen/Exam.cshtml", typeof(LMS.Pages.Studen.Pages_Studen_Exam), null)]
namespace LMS.Pages.Studen
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\farshid\source\repos\LMS\LMS\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\farshid\source\repos\LMS\LMS\Pages\_ViewImports.cshtml"
using LMS;

#line default
#line hidden
#line 3 "C:\Users\farshid\source\repos\LMS\LMS\Pages\_ViewImports.cshtml"
using LMS.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e012873f067637f6616684bf12f16f9ad2859e70", @"/Pages/Studen/Exam.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd49f80ac16f3a2bd34335b2d63dc3f19733e2be", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Studen_Exam : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "radio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("direction:rtl; font-size:20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\farshid\source\repos\LMS\LMS\Pages\Studen\Exam.cshtml"
  
    ViewData["Title"] = "Exam";

#line default
#line hidden
            BeginContext(82, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(84, 1690, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c860f5c864e4e42afd5fd0a016d18d9", async() => {
                BeginContext(143, 135, true);
                WriteLiteral("\r\n    <div style=\"display:inline-block; font-size:20px; align-items:center; \">\r\n        <span style=\"margin:20px;\"><span> نام :</span> ");
                EndContext();
                BeginContext(279, 22, false);
#line 9 "C:\Users\farshid\source\repos\LMS\LMS\Pages\Studen\Exam.cshtml"
                                                  Write(Model.Students[0].Name);

#line default
#line hidden
                EndContext();
                BeginContext(301, 73, true);
                WriteLiteral("</span>\r\n        <span style=\"margin:20px;\"><span> نام خانوادگی :</span> ");
                EndContext();
                BeginContext(375, 26, false);
#line 10 "C:\Users\farshid\source\repos\LMS\LMS\Pages\Studen\Exam.cshtml"
                                                           Write(Model.Students[0].Lastname);

#line default
#line hidden
                EndContext();
                BeginContext(401, 76, true);
                WriteLiteral(" </span>\r\n        <span style=\"margin:20px;\"><span> شماره دانشجویی :</span> ");
                EndContext();
                BeginContext(478, 28, false);
#line 11 "C:\Users\farshid\source\repos\LMS\LMS\Pages\Studen\Exam.cshtml"
                                                             Write(Model.Students[0].Studentnum);

#line default
#line hidden
                EndContext();
                BeginContext(506, 78, true);
                WriteLiteral(" </span>\r\n        <span style=\"margin:20px;\"><span> نام گروه امتحانی :</span> ");
                EndContext();
                BeginContext(585, 23, false);
#line 12 "C:\Users\farshid\source\repos\LMS\LMS\Pages\Studen\Exam.cshtml"
                                                               Write(Model.Examlists[0].Name);

#line default
#line hidden
                EndContext();
                BeginContext(608, 71, true);
                WriteLiteral("</span>\r\n    </div>\r\n    <hr />\r\n    <hr />\r\n    <br /><br /><br />\r\n\r\n");
                EndContext();
#line 18 "C:\Users\farshid\source\repos\LMS\LMS\Pages\Studen\Exam.cshtml"
      int one = 0; 

#line default
#line hidden
                BeginContext(701, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 19 "C:\Users\farshid\source\repos\LMS\LMS\Pages\Studen\Exam.cshtml"
      int three = 1; 

#line default
#line hidden
                BeginContext(725, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 20 "C:\Users\farshid\source\repos\LMS\LMS\Pages\Studen\Exam.cshtml"
     foreach (var i in Model.Questions)
    {
        string[] str = { i.Anone, i.Antwo, i.Anthree, i.Anfour };


        int two = 1;

#line default
#line hidden
                BeginContext(866, 30, true);
                WriteLiteral("        <div>\r\n            <p>");
                EndContext();
                BeginContext(897, 5, false);
#line 27 "C:\Users\farshid\source\repos\LMS\LMS\Pages\Studen\Exam.cshtml"
          Write(three);

#line default
#line hidden
                EndContext();
                BeginContext(902, 8, true);
                WriteLiteral("-</p><p>");
                EndContext();
                BeginContext(911, 26, false);
#line 27 "C:\Users\farshid\source\repos\LMS\LMS\Pages\Studen\Exam.cshtml"
                        Write(Html.DisplayFor(m => i.Qs));

#line default
#line hidden
                EndContext();
                BeginContext(937, 6, true);
                WriteLiteral("</p>\r\n");
                EndContext();
#line 28 "C:\Users\farshid\source\repos\LMS\LMS\Pages\Studen\Exam.cshtml"
             foreach (var j in str)
            {

#line default
#line hidden
                BeginContext(995, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(1011, 92, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "44e98a3e511041cc8bd5f9764bead42f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 30 "C:\Users\farshid\source\repos\LMS\LMS\Pages\Studen\Exam.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Grades[one].Qsans);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
#line 31 "C:\Users\farshid\source\repos\LMS\LMS\Pages\Studen\Exam.cshtml"
                  WriteLiteral(two);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1103, 25, true);
                WriteLiteral("\r\n                <label>");
                EndContext();
                BeginContext(1129, 23, false);
#line 32 "C:\Users\farshid\source\repos\LMS\LMS\Pages\Studen\Exam.cshtml"
                  Write(Html.DisplayFor(m => j));

#line default
#line hidden
                EndContext();
                BeginContext(1152, 16, true);
                WriteLiteral("</label><br />\r\n");
                EndContext();
#line 33 "C:\Users\farshid\source\repos\LMS\LMS\Pages\Studen\Exam.cshtml"
                two++;
            }

#line default
#line hidden
                BeginContext(1207, 12, true);
                WriteLiteral("            ");
                EndContext();
                BeginContext(1219, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b0434d45dc554ce69cd4ceeae514ac98", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 35 "C:\Users\farshid\source\repos\LMS\LMS\Pages\Studen\Exam.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Grades[one].Qskey);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 35 "C:\Users\farshid\source\repos\LMS\LMS\Pages\Studen\Exam.cshtml"
                                                               WriteLiteral(i.Qskey);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1294, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1308, 95, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9477996844d341d08592c1f226620f2c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 36 "C:\Users\farshid\source\repos\LMS\LMS\Pages\Studen\Exam.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Grades[one].Stdforeinkey);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 36 "C:\Users\farshid\source\repos\LMS\LMS\Pages\Studen\Exam.cshtml"
                                                                      WriteLiteral(Model.Students[0].Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1403, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1417, 94, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8b74c310bcc2479e8926eec8f9f13097", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 37 "C:\Users\farshid\source\repos\LMS\LMS\Pages\Studen\Exam.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Grades[one].Examname);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 37 "C:\Users\farshid\source\repos\LMS\LMS\Pages\Studen\Exam.cshtml"
                                                                  WriteLiteral(Model.Examlists[0].Name);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1511, 80, true);
                WriteLiteral("\r\n            <br />\r\n            <hr />\r\n            <hr />\r\n\r\n        </div>\r\n");
                EndContext();
#line 43 "C:\Users\farshid\source\repos\LMS\LMS\Pages\Studen\Exam.cshtml"
        one++;
                    three++;

    }

#line default
#line hidden
                BeginContext(1646, 121, true);
                WriteLiteral("    <button type=\"submit\" class=\"btn btn-success\">\r\n        <p style=\"font-size:20px;\">اتمام ازمون</p>\r\n    </button>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1774, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LMS.Pages.Studen.ExamModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LMS.Pages.Studen.ExamModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LMS.Pages.Studen.ExamModel>)PageContext?.ViewData;
        public LMS.Pages.Studen.ExamModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
