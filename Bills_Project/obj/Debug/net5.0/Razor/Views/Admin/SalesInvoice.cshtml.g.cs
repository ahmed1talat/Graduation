#pragma checksum "E:\PROJECT\Graduation\Bills_Project\Views\Admin\SalesInvoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d5fd7ac1144a1b4116febb32690441733bd3ee8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_SalesInvoice), @"mvc.1.0.view", @"/Views/Admin/SalesInvoice.cshtml")]
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
#line 1 "E:\PROJECT\Graduation\Bills_Project\Views\_ViewImports.cshtml"
using Bills_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\PROJECT\Graduation\Bills_Project\Views\_ViewImports.cshtml"
using Bills_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d5fd7ac1144a1b4116febb32690441733bd3ee8", @"/Views/Admin/SalesInvoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9f0c01533b917663e3738a8117ba4820469a16a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_SalesInvoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("disabled", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Ahmed", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "ali", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@" <div class=""main-panel"">
            <div class=""main-content"">
               <div class=""content-wrapper"">
                  <div class=""container-fluid"">
                    <section id=""horizontal-form-layouts"">
                        <div class=""row"">
                         
                        </div>
                        <div class=""row"">
                            <div class=""col-md-12"">
                                <div class=""card"">
                                    <div class=""card-header"">
                                        <div class=""card-title-wrap bar-success"">
                                            <h4 class=""card-title"" id=""horz-layout-basic"">Sales Invoice</h4>
                                        </div>
                                        <p class=""mb-0"">This is the basic horizontal form with labels on left and cost estimation form is the default position.</p>
                                    </div>
                                    <di");
            WriteLiteral("v class=\"card-body\">\r\n                                        <div class=\"px-3\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d5fd7ac1144a1b4116febb32690441733bd3ee86520", async() => {
                WriteLiteral(@"
                                                <div class=""form-body"">
                                                    <h4 class=""form-section"">
                                                        <i class=""icon-user""></i>Bills Details</h4>
                                                    <div class=""form-group row"">
                                                        <label class=""col-md-3 label-control"" for=""projectinput1"">Bills Date : </label>
                                                        <div class=""col-md-9"">
                                                            <input type=""text"" id=""projectinput1"" class=""form-control"" name=""fname"">
                                                        </div>
                                                    </div>
                                                    <div class=""form-group row"">
                                                        <label class=""col-md-3 label-control"" for=""projectinput2"">Bills NUmber: </");
                WriteLiteral(@"label>
                                                        <div class=""col-md-9"">
                                                            <input type=""text"" id=""projectinput2"" class=""form-control"" name=""lname"">
                                                        </div>
                                                    </div>
                                                    <div class=""form-group row"">
                                                        <label class=""col-md-3 label-control"" for=""projectinput7"">Client Name : </label>
                                                        <div class=""col-md-9"">
                                                            <select id=""projectinput7"" name=""budget"" class=""form-control"">
                                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d5fd7ac1144a1b4116febb32690441733bd3ee88721", async() => {
                    WriteLiteral("Choose From Clients ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d5fd7ac1144a1b4116febb32690441733bd3ee810196", async() => {
                    WriteLiteral("Ahmed ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d5fd7ac1144a1b4116febb32690441733bd3ee811484", async() => {
                    WriteLiteral("Ali");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                                              
                                                            </select>
                                                        </div>
                                                    </div>
                                                    <div class=""form-group row"">
                                                        <label class=""col-md-3 label-control"" for=""projectinput7"">Species Name : </label>
                                                        <div class=""col-md-9"">
                                                            <select id=""projectinput7"" name=""budget"" class=""form-control"">
                                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d5fd7ac1144a1b4116febb32690441733bd3ee813466", async() => {
                    WriteLiteral("Choose From Species ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d5fd7ac1144a1b4116febb32690441733bd3ee814942", async() => {
                    WriteLiteral("Ahmed ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d5fd7ac1144a1b4116febb32690441733bd3ee816230", async() => {
                    WriteLiteral("Ali");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                                              
                                                            </select>
                                                        </div>
                                                    </div>
                                                    <div class=""form-group row"">
                                                        <label class=""col-md-3 label-control"" for=""projectinput2"">selling price
                                                            : </label>
                                                        <div class=""col-md-9"">
                                                            <input type=""text"" id=""projectinput2"" class=""form-control"" name=""lname"">
                                                        </div>
                                                    </div>
                                                    <div class=""form-group row"">
                                                        <lab");
                WriteLiteral(@"el class=""col-md-3 label-control"" for=""projectinput2"">Buying Quintity: </label>
                                                        <div class=""col-md-9"">
                                                            <input type=""text"" id=""projectinput2"" class=""form-control"" name=""lname"">
                                                        </div>
                                                    </div>
                                                    <div class=""form-group row"">
                                                        <label class=""col-md-3 label-control"" for=""projectinput2"">Total: </label>
                                                        <div class=""col-md-9"">
                                                            <input type=""text"" id=""projectinput2"" class=""form-control"" name=""lname"">
                                                        </div>
                                                    </div>
                    
                                ");
                WriteLiteral(@"                    <h4 class=""form-section"">
                                                        <i class=""icon-book-open""></i>Other Details</h4>
                                    
                                     
                                    <div class=""form-group row"">
                                                        <label class=""col-md-3 label-control"" for=""projectinput9""> Bills Total  </label>
                                                        <div class=""col-md-9"">
                                                            <input type=""text"" id=""projectinput9"" class=""form-control"" name=""Type"">
                                                        </div>
                                                    </div>
                                                    <div class=""form-group row"">
                                                        <label class=""col-md-3 label-control"" for=""projectinput9""> percentage discount
                                   ");
                WriteLiteral(@"                     </label>
                                                        <div class=""col-md-9"">
                                                            <input type=""text"" id=""projectinput9"" class=""form-control"" name=""Type"">
                                                        </div>
                                                    </div>
                                                    <div class=""form-group row"">
                                                        <label class=""col-md-3 label-control"" for=""projectinput9""> value discount
                                                        </label>
                                                        <div class=""col-md-9"">
                                                            <input type=""text"" id=""projectinput9"" class=""form-control"" name=""Type"">
                                                        </div>
                                                    </div>
                                        ");
                WriteLiteral(@"            <div class=""form-group row"">
                                                        <label class=""col-md-3 label-control"" for=""projectinput9""> The Net </label>
                                                        <div class=""col-md-9"">
                                                            <input type=""text"" id=""projectinput9"" class=""form-control"" name=""Type"">
                                                        </div>
                                                    </div>
                                                    <div class=""form-group row"">
                                                        <label class=""col-md-3 label-control"" for=""projectinput9""> paid up
                                                        </label>
                                                        <div class=""col-md-9"">
                                                            <input type=""text"" id=""projectinput9"" class=""form-control"" name=""Type"">
                           ");
                WriteLiteral(@"                             </div>
                                                    </div>
                                                    <div class=""form-group row"">
                                                        <label class=""col-md-3 label-control"" for=""projectinput9""> The rest
                                                        </label>
                                                        <div class=""col-md-9"">
                                                            <input type=""text"" id=""projectinput9"" class=""form-control"" name=""Type"">
                                                        </div>
                                                    </div>
                             
                    
                                                </div>
                    
                                                <div class=""form-actions"">
                                                    <button type=""button"" class=""btn btn-danger mr-1"">
      ");
                WriteLiteral(@"                                                  <i class=""icon-trash""></i> Cancel
                                                    </button>
                                                    <button type=""button"" class=""btn btn-success"">
                                                        <i class=""icon-note""></i> Save
                                                    </button>
                                                </div>
                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
                            </div>
                        </div>
                    
                    
                    </section>
                  
                  </div>
               </div>
            </div>
           
         </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
