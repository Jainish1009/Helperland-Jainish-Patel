#pragma checksum "D:\Tatvasoft git\Helperland-Jainish-Patel\Helperland\HelperlandBackend\Views\Customer\ServiceHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb0b49940e9f24977e3133a857e24f4297b17e47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_ServiceHistory), @"mvc.1.0.view", @"/Views/Customer/ServiceHistory.cshtml")]
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
#line 1 "D:\Tatvasoft git\Helperland-Jainish-Patel\Helperland\HelperlandBackend\Views\_ViewImports.cshtml"
using HelperlandBackend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Tatvasoft git\Helperland-Jainish-Patel\Helperland\HelperlandBackend\Views\_ViewImports.cshtml"
using HelperlandBackend.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb0b49940e9f24977e3133a857e24f4297b17e47", @"/Views/Customer/ServiceHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ca02c3835b389d8e38f01c8d516e625dddf681f", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_ServiceHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/home/window-close-regular.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("closebtn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/upcoming_service/arrow.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("sorting-arrow"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Cservice_history.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\Tatvasoft git\Helperland-Jainish-Patel\Helperland\HelperlandBackend\Views\Customer\ServiceHistory.cshtml"
  
    Layout = "~/Views/Shared/_CustDashLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""ServiceHistory"">

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
                    <span class=""title-text""><b>Extras :  </b><span id=""SerExtra""></span></span>
                    <span class=""");
            WriteLiteral(@"title-text""><b>Net Amout : </b><span id=""SerPayment"" class=""NetAmount""></span></span>
                    <hr />
                    <span class=""title-text""><b>Service Address : </b><span id=""SerAddress""></span></span>
                    <span class=""title-text""><b>Billing Address : </b>Same as cleaning Address</span>
                    <span class=""title-text""><b>Phone : </b><span id=""SerMobile""></span></span>
                    <span class=""title-text""><b>Email : </b><span id=""SerEmail""></span></span>
                    <hr />
                    <span class=""title-text""><b>Comments : </b><span id=""SerComment""></span></span>
                    <span class=""title-text""><span id=""SerPets""></span></span>
                    <hr />
                    </div>
                    <div id=""AccepetedSp"">
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""modal fade"" id=""ratingModal"" role=""dialog"">
        <div class=""modal-dialog"">
            <div c");
            WriteLiteral("lass=\"modal-content\">\n                <div class=\"modal-body\">\n                    <a class=\"close\" data-dismiss=\"modal\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cb0b49940e9f24977e3133a857e24f4297b17e477876", async() => {
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
            WriteLiteral("</a>\n                    <div id=\"SpDetails\">\n                    </div>\n                    <h4>Rate Your Service Provider</h4>\n                    <hr />\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb0b49940e9f24977e3133a857e24f4297b17e479169", async() => {
                WriteLiteral(@"
                    <input type=""text"" class=""d-none"" id=""rateServiceId"" />
                    <div class=""row"">
                        <div class=""col-6 title"">
                            <span class=""title-text"">On time arrival</span>
                        </div>
                        <div class=""col-6"">
                            <div class=""rating"">
                                <input id=""radio1"" type=""radio"" name=""ontime"" value=""5"" class=""star"" />
                                <label for=""radio1"">&#9733;</label>
                                <input id=""radio2"" type=""radio"" name=""ontime"" value=""4"" class=""star"" />
                                <label for=""radio2"">&#9733;</label>
                                <input id=""radio3"" type=""radio"" name=""ontime"" value=""3"" class=""star"" />
                                <label for=""radio3"">&#9733;</label>
                                <input id=""radio4"" type=""radio"" name=""ontime"" value=""2"" class=""star"" />
                                <label ");
                WriteLiteral(@"for=""radio4"">&#9733;</label>
                                <input id=""radio5"" type=""radio"" name=""ontime"" value=""1"" class=""star"" />
                                <label for=""radio5"">&#9733;</label>
                            </div>
                        </div>
                        <div class=""col-6 title"">
                            <span class=""title-text"">Friendly</span>
                        </div>
                        <div class=""col-6"">
                            <div class=""rating"">
                                <input id=""radio6"" type=""radio"" name=""friendly"" value=""5"" class=""star"" />
                                <label for=""radio6"">&#9733;</label>
                                <input id=""radio7"" type=""radio"" name=""friendly"" value=""4"" class=""star"" />
                                <label for=""radio7"">&#9733;</label>
                                <input id=""radio8"" type=""radio"" name=""friendly"" value=""3"" class=""star"" />
                                <label for=""radio8"">&#9733;<");
                WriteLiteral(@"/label>
                                <input id=""radio9"" type=""radio"" name=""friendly"" value=""2"" class=""star"" />
                                <label for=""radio9"">&#9733;</label>
                                <input id=""radio10"" type=""radio"" name=""friendly"" value=""1"" class=""star"" />
                                <label for=""radio10"">&#9733;</label>
                            </div>
                        </div>
                        <div class=""col-6 title"">
                            <span class=""title-text"">Quality of service</span>
                        </div>
                        <div class=""col-6"">
                            <div class=""rating"">
                                <input id=""radio11"" type=""radio"" name=""quality"" value=""5"" class=""star"" />
                                <label for=""radio11"">&#9733;</label>
                                <input id=""radio12"" type=""radio"" name=""quality"" value=""4"" class=""star"" />
                                <label for=""radio12"">&#9733;</labe");
                WriteLiteral(@"l>
                                <input id=""radio13"" type=""radio"" name=""quality"" value=""3"" class=""star"" />
                                <label for=""radio13"">&#9733;</label>
                                <input id=""radio14"" type=""radio"" name=""quality"" value=""2"" class=""star"" />
                                <label for=""radio14"">&#9733;</label>
                                <input id=""radio15"" type=""radio"" name=""quality"" value=""1"" class=""star"" />
                                <label for=""radio15"">&#9733;</label>
                            </div>
                        </div>
                    </div>
                    <div class=""feedback mt-3"">
                        <span>Feedback on service provider</span>
                        <textarea class=""form-control"" id=""feedback"" rows=""3"" maxlength=""300""></textarea>
                    </div>
                    <button type=""button"" class=""btn"" id=""RatingSaveMdodelBtn"" onclick=""saveRating();"" disabled=""disabled"">Save</button>
                   ");
                WriteLiteral(" ");
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


    <div class=""d-flex datatable_heading"">
        <div class=""py-2"">Service History</div>
        <div class=""py-2 ml-3 mobile_sorting"">
            <a href=""#"" data-toggle=""modal"" data-target=""#mobileSorting"" data-dismiss=""modal"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cb0b49940e9f24977e3133a857e24f4297b17e4715183", async() => {
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
            WriteLiteral(@"</a>

        </div>
        <div class=""modal fade"" id=""mobileSorting"" role=""dialog"">
            <div class=""modal-dialog"">
                <!-- Modal content-->
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h4 class=""modal-title"">Choose Option</h4>
                        <a class=""close"" data-dismiss=""modal"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cb0b49940e9f24977e3133a857e24f4297b17e4716697", async() => {
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
            WriteLiteral("</a>\n                    </div>\n                    <div class=\"modal-body forgot-password\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb0b49940e9f24977e3133a857e24f4297b17e4717930", async() => {
                WriteLiteral(@"
                            <input type=""radio"" name=""sortOption"" id=""ServiceIdOldest"" value=""ServiceId:Oldest"">&nbsp;Service Id : Oldest<br>
                            <input type=""radio"" name=""sortOption"" id=""ServiceIdOldest"" value=""ServiceId:Latest"">&nbsp;Service Id : Latest<br>
                            <input type=""radio"" name=""sortOption"" id=""ServiceDateOldest"" value=""ServiceDate:Oldest"">&nbsp;Service Date : Oldest<br>
                            <input type=""radio"" name=""sortOption"" id=""ServiceDateLatest"" value=""ServiceDate:Latest"">&nbsp;Service Date : Latest<br>
                            <input type=""radio"" name=""sortOption"" id=""ServiceProviderAtoZ"" value=""ServiceProvider:AtoZ"">&nbsp;Service Provider : A to Z<br>
                            <input type=""radio"" name=""sortOption"" id=""ServiceProvider:ZtoA"" value=""ServiceProvider:ZtoA"">&nbsp;Service Provider : Z to A<br>
                            <input type=""radio"" name=""sortOption"" id=""PaymentLowtoHigh"" value=""PaymentLowtoHigh"">&nbsp;Payment Low");
                WriteLiteral(" to High<br>\n                            <input type=\"radio\" name=\"sortOption\" id=\"PaymentHightoLow\" value=\"PaymentHightoLow\">&nbsp;Payment High to Low<br>\n\n                        ");
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
            <table class=""dataTable table"" id=""service_history_table"">
                <thead>
                    <tr>
                        <th>Service Id</th>
                        <th>Service Details</th>
                        <th>Service Provider</th>
                        <th>Payment</th>
                        <th>Status</th>
                        <th>Rate SP</th>
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
                WriteLiteral("\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb0b49940e9f24977e3133a857e24f4297b17e4721388", async() => {
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
                WriteLiteral("\n                <script type=\"text/javascript\" src=\"https://cdnjs.cloudflare.com/ajax/libs/xlsx/0.18.2/xlsx.full.min.js\"></script>\n            ");
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
