#pragma checksum "C:\Users\ahmed\Desktop\get\Graduation\Bills_Project\Views\Shared\_LoginLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8f7d127af1137152f7e9f86ebc26b1b3a950131"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LoginLayout), @"mvc.1.0.view", @"/Views/Shared/_LoginLayout.cshtml")]
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
#line 1 "C:\Users\ahmed\Desktop\get\Graduation\Bills_Project\Views\_ViewImports.cshtml"
using Bills_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ahmed\Desktop\get\Graduation\Bills_Project\Views\_ViewImports.cshtml"
using Bills_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8f7d127af1137152f7e9f86ebc26b1b3a950131", @"/Views/Shared/_LoginLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9f0c01533b917663e3738a8117ba4820469a16a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LoginLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8f7d127af1137152f7e9f86ebc26b1b3a9501313283", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />



     <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"">
      <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
      <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, user-scalable=0, minimal-ui"">
      <title>Bills-system</title>
      <link rel=""apple-touch-icon"" sizes=""60x60"" href=""  /img/ico/apple-icon-60.html"">
      <link rel=""apple-touch-icon"" sizes=""76x76"" href=""  /img/ico/apple-icon-76.html"">
      <link rel=""apple-touch-icon"" sizes=""120x120"" href=""  /img/ico/apple-icon-120.html"">
      <link rel=""apple-touch-icon"" sizes=""152x152"" href=""  /img/ico/apple-icon-152.html"">
      <link rel=""shortcut icon"" type=""image/png"" href=""  /img/logo.png"">
      <meta name=""apple-mobile-web-app-capable"" content=""yes"">
      <meta name=""apple-touch-fullscreen"" content=""yes"">
      <meta name=""apple-mobile-web-app-status-bar-style"" content=""default"">
      <link href=""https://fonts.googleapis.com/cs");
                WriteLiteral(@"s?family=Rubik:300,400,500,700,900%7CMontserrat:300,400,500,600,700,800,900"" rel=""stylesheet"">
      <link rel=""stylesheet"" type=""text/css"" href=""  /fonts/feather/style.min.css"">
      <link rel=""stylesheet"" type=""text/css"" href=""  /fonts/simple-line-icons/style.css"">
      <link rel=""stylesheet"" type=""text/css"" href=""  /fonts/font-awesome/css/font-awesome.min.css"">
      <link rel=""stylesheet"" type=""text/css"" href=""  /vendors/css/perfect-scrollbar.min.css"">
      <link rel=""stylesheet"" type=""text/css"" href=""  /vendors/css/prism.min.css"">
      <link rel=""stylesheet"" type=""text/css"" href=""  /vendors/css/chartist.min.css"">
      <link rel=""stylesheet"" type=""text/css"" href=""  /css/app.css"">
      <style>
        

 body {
	 background: #031323;
	 overflow: hidden;
}
 .fas {
	 width: 32px;
}
 section {
	 display: flex;
	 justify-content: center;
	 align-items: center;
	 min-height: 100vh;
	 background: linear-gradient(-45deg, #ee7752, #e73c7e, #23a6d5, #23d5ab);
	 background-size: 400% 40");
                WriteLiteral("0%;\r\n\t animation: gradient 10s ease infinite;\r\n}\r\n  ");
                WriteLiteral(@"@keyframes gradient {
	 0% {
		 background-position: 0% 50%;
	}
	 50% {
		 background-position: 100% 50%;
	}
	 100% {
		 background-position: 0% 50%;
	}
}
 .box {
	 position: relative;
}
 .box .square {
	 position: absolute;
	 background: rgba(255, 255, 255, 0.1);
	 backdrop-filter: blur(5px);
	 box-shadow: 0 25px 45px rgba(0, 0, 0, 0.1);
	 border: 1px solid rgba(255, 255, 255, 0.15);
	 border-radius: 15px;
	 animation: square 10s linear infinite;
	 animation-delay: calc(-1s * var(--i));
}
 ");
                WriteLiteral(@"@keyframes square {
	 0%, 100% {
		 transform: translateY(-20px);
	}
	 50% {
		 transform: translateY(20px);
	}
}
 .box .square:nth-child(1) {
	 width: 100px;
	 height: 100px;
	 top: -15px;
	 right: -45px;
}
 .box .square:nth-child(2) {
	 width: 150px;
	 height: 150px;
	 top: 105px;
	 left: -125px;
	 z-index: 2;
}
 .box .square:nth-child(3) {
	 width: 60px;
	 height: 60px;
	 bottom: 85px;
	 right: -45px;
	 z-index: 2;
}
 .box .square:nth-child(4) {
	 width: 50px;
	 height: 50px;
	 bottom: 35px;
	 left: -95px;
}
 .box .square:nth-child(5) {
	 width: 50px;
	 height: 50px;
	 top: -15px;
	 left: -25px;
}
 .box .square:nth-child(6) {
	 width: 85px;
	 height: 85px;
	 top: 165px;
	 right: -155px;
	 z-index: 2;
}
 .container {
	 position: relative;
	 padding: 50px;

	 min-height: 380px;
	 display: flex;
	 justify-content: center;
	 align-items: center;
	 background: rgba(255, 255, 255, 0.1);
	 backdrop-filter: blur(5px);
	 border-radius: 10px;
	 box-shadow: 0 ");
                WriteLiteral(@"25px 45px rgba(0, 0, 0, 0.2);
}
 .container::after {
	 content: '';
	 position: absolute;
	 top: 5px;
	 right: 5px;
	 bottom: 5px;
	 left: 5px;
	 border-radius: 5px;
	 pointer-events: none;
	 background: linear-gradient(to bottom, rgba(255, 255, 255, 0.1) 0%, rgba(255, 255, 255, 0.1) 2%);
}
 .form {
	 position: relative;
	 width: 100%;
	 height: 100%;
}
 .form h2 {
	 color: #fff;
	 letter-spacing: 2px;
	 margin-bottom: 30px;
}
 .form .inputBx {
	 position: relative;
	 width: 100%;
	 margin-bottom: 20px;
}
 .form .inputBx input {
	 width: 100%;
	 outline: none;
	 border: none;
	 border: 1px solid rgba(255, 255, 255, 0.2);
	 background: rgba(255, 255, 255, 0.2);
	 padding: 8px 10px;
	 padding-left: 40px;
	 border-radius: 15px;
	 color: #fff;
	 font-size: 16px;
	 box-shadow: 0 5px 15px rgba(0, 0, 0, 0.05);
}
 .form .inputBx .password-control {
	 position: absolute;
	 top: 11px;
	 right: 10px;
	 display: inline-block;
	 width: 20px;
	 height: 20px;
	 background: url");
                WriteLiteral(@"(https://snipp.ru/demo/495/view.svg) 0 0 no-repeat;
	 transition: 0.5s;
}
 .form .inputBx .view {
	 background: url(https://snipp.ru/demo/495/no-view.svg) 0 0 no-repeat;
	 transition: 0.5s;
}
 .form .inputBx .fas {
	 position: absolute;
	 top: 13px;
	 left: 13px;
}
 .form .inputBx input[type=""submit""] {
	 background: #fff;
	 color: #111;
	 max-width: 100px;
	 padding: 8px 10px;
	 box-shadow: none;
	 letter-spacing: 1px;
	 cursor: pointer;
	 transition: 1.5s;
}
 .form .inputBx input[type=""submit""]:hover {
	 background: linear-gradient(115deg, rgba(0, 0, 0, 0.10), rgba(255, 255, 255, 0.25));
	 color: #fff;
	 transition: 0.5s;
}
 .form .inputBx input::placeholder {
	 color: #fff;
}
 .form .inputBx span {
	 position: absolute;
	 left: 30px;
	 padding: 10px;
	 display: inline-block;
	 color: #fff;
	 transition: 0.5s;
	 pointer-events: none;
}
 .form .inputBx input:focus ~ span, .form .inputBx input:valid ~ span {
	 transform: translateX(-30px) translateY(-25px);
	 font-size");
                WriteLiteral(@": 12px;
}
 .form p {
	 color: #fff;
	 font-size: 15px;
	 margin-top: 5px;
}
 .form p a {
	 color: #fff;
}
 .form p a:hover {
	 background-color: #000;
	 background-image: linear-gradient(to right, #434343 0%, black 100%);
/*	 -webkit-background-clip: text;
*/	 -webkit-text-fill-color: transparent;
}
 .remember {
	 position: relative;
	 display: inline-block;
	 color: #fff;
	 margin-bottom: 10px;
	 cursor: pointer;
}
.form .inputBx {
    position: relative;
    width: 100%;
    margin-bottom: 20px
;
    font-weight: 600;
    font-size: 17px;
}
.text-center img  {
    height: 90px;
    margin-bottom: 25px;
}
 
      </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8f7d127af1137152f7e9f86ebc26b1b3a95013110972", async() => {
                WriteLiteral("\r\n    <div>\r\n        ");
#nullable restore
#line 259 "C:\Users\ahmed\Desktop\get\Graduation\Bills_Project\Views\Shared\_LoginLayout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
