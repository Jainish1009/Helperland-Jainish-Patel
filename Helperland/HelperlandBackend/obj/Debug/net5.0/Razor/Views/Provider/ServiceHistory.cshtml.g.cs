#pragma checksum "C:\Users\jaini\Downloads\jp\Helperland-master\Helperland\HelperlandBackend\Views\Provider\ServiceHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e161408feca14e9a03abf863cf2f90ff0f9af5a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Provider_ServiceHistory), @"mvc.1.0.view", @"/Views/Provider/ServiceHistory.cshtml")]
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
#line 1 "C:\Users\jaini\Downloads\jp\Helperland-master\Helperland\HelperlandBackend\Views\_ViewImports.cshtml"
using HelperlandBackend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jaini\Downloads\jp\Helperland-master\Helperland\HelperlandBackend\Views\_ViewImports.cshtml"
using HelperlandBackend.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e161408feca14e9a03abf863cf2f90ff0f9af5a1", @"/Views/Provider/ServiceHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ca02c3835b389d8e38f01c8d516e625dddf681f", @"/Views/_ViewImports.cshtml")]
    public class Views_Provider_ServiceHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/upcoming_service/arrow.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("sorting-arrow"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/home/window-close-regular.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("closebtn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/PServiceHistory.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\jaini\Downloads\jp\Helperland-master\Helperland\HelperlandBackend\Views\Provider\ServiceHistory.cshtml"
  
    Layout = "~/Views/Shared/_ProDashLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div id=""ServiceHistory"">
    <div>
        <div class=""modal fade"" id=""displaydataModal"" role=""dialog"">
            <div class=""modal-dialog modal-dialog-centered"""">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h4 class=""modal-title"">Service Details</h4>
                        <a class=""close"" data-dismiss=""modal""><img src=""~/image/home/window-close-regular.svg"" alt=""closebtn""></a>
                    </div>
                    <div class=""modal-body"">
                        <div id=""SerDetail"">
                            <p class=""date-time""><span id=""SerDate""></span> <span id=""SerStartTime""></span>-<span id=""SerEndTime""></span></p>
                            <span class=""title-text""><b>Duration : </b><span id=""SerDuration""></span> Hrs</span>
                            <hr />
                            <span class=""title-text""><b>Service Id : </b><span id=""SerId""></span></span>
                            <span class=""title-text");
            WriteLiteral(@"""><b>Extras :  </b><span id=""SerExtra""></span></span>
                            <span class=""title-text""><b>Net Amout : </b><span id=""SerPayment"" class=""NetAmount""></span></span>
                            <hr />
                            <span class=""title-text""><b>Service Address : </b><span id=""SerAddress""></span></span>
                            <span class=""title-text""><b>Billing Address : </b>Same as cleaning Address</span>
                            <span class=""title-text""><b>Name : </b><span id=""SerCustName""></span></span>
                            <span class=""title-text""><b>Phone : </b><span id=""SerMobile""></span></span>
                            <span class=""title-text""><b>Email : </b><span id=""SerEmail""></span></span>
                            <hr />
                            <span class=""title-text""><b>Comments : </b><span id=""SerComment""></span></span>
                            <span class=""title-text""><span id=""SerPets""></span></span>
                            <hr />
      ");
            WriteLiteral(@"                  </div>
                        <div>
                            <div id='CustMap'>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""d-flex datatable_heading"">
        <div class=""py-2"">Service History</div>
        <div class=""py-2 ml-3 mobile_sorting"">
            <a href=""#"" data-toggle=""modal"" data-target=""#mobileSorting"" data-dismiss=""modal"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e161408feca14e9a03abf863cf2f90ff0f9af5a18263", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>

        </div>
        <div class=""modal fade"" id=""mobileSorting"" role=""dialog"">
            <div class=""modal-dialog"">
                <!-- Modal content-->
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h4 class=""modal-title"">Choose Option</h4>
                        <a class=""close"" data-dismiss=""modal"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e161408feca14e9a03abf863cf2f90ff0f9af5a19776", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\n                    </div>\n                    <div class=\"modal-body forgot-password\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e161408feca14e9a03abf863cf2f90ff0f9af5a111008", async() => {
                WriteLiteral(@"
                            <input type=""radio"" name=""sortOption"" id=""ServiceIdOldest"" value=""ServiceId:Oldest"">&nbsp;Service Id : Oldest<br>
                            <input type=""radio"" name=""sortOption"" id=""ServiceIdOldest"" value=""ServiceId:Latest"">&nbsp;Service Id : Latest<br>
                            <input type=""radio"" name=""sortOption"" id=""ServiceDateOldest"" value=""ServiceDate:Oldest"">&nbsp;Service Date : Oldest<br>
                            <input type=""radio"" name=""sortOption"" id=""ServiceDateLatest"" value=""ServiceDate:Latest"">&nbsp;Service Date : Latest<br>
                            <input type=""radio"" name=""sortOption"" id=""CustomerDetailsAtoZ"" value=""CustomerDetails:AtoZ"">&nbsp;Customer Details : A to Z<br>
                            <input type=""radio"" name=""sortOption"" id=""CustomerDetailsZtoA"" value=""CustomerDetails:ZtoA"">&nbsp;Customer Details : Z to A<br>

                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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

        <div class=""ml-auto py-2""><button onclick=""ExcelSheetDown()"">Export</button></div>
    </div>
    <div class=""row"">
        <div class=""col"">
            <table id=""ServiceHistoryTbl"" class=""dataTable table"">
                <thead>
                    <tr>
                        <th>Service ID</th>
                        <th class=""text-center"">Service date</th>
                        <th class=""text-center"">Customer detail</th>
                    </tr>
                </thead>
                <tbody id=""ServiceHistoryTblData"">
                </tbody>
            </table>
        </div>
    </div>
</div>






");
            DefineSection("script", async() => {
                WriteLiteral("\n    <script src=\"https://unpkg.com/leaflet@1.7.1/dist/leaflet.js\"\n            integrity=\"sha512-XQoYMqMTK8LvdxXYG3nZ448hOEQiglfqkJs1NOQV44cWnUrBc8PkAOcXy20w0vlaXaVUearIOBhiXZ5V3ynxwA==\"");
                BeginWriteAttribute("crossorigin", "\n            crossorigin=\"", 5083, "\"", 5109, 0);
                EndWriteAttribute();
                WriteLiteral("></script>\n    <script type=\"text/javascript\" src=\"https://cdnjs.cloudflare.com/ajax/libs/xlsx/0.18.2/xlsx.full.min.js\"></script>\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e161408feca14e9a03abf863cf2f90ff0f9af5a114536", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
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
