#pragma checksum "C:\Users\minhm\source\repos\WebCovid_DA\WebCovid_DA\WepApp\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b248232d9c1f0a93f07084732c4091c642fdff8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\minhm\source\repos\WebCovid_DA\WebCovid_DA\WepApp\Views\_ViewImports.cshtml"
using WepApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\minhm\source\repos\WebCovid_DA\WebCovid_DA\WepApp\Views\_ViewImports.cshtml"
using WepApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b248232d9c1f0a93f07084732c4091c642fdff8", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35881990136e32ae488f6d16f5989a6100247a67", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-wrapper"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\minhm\source\repos\WebCovid_DA\WebCovid_DA\WepApp\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""page-header"">
            <div class=""container"">
                <div class=""page-title"">
                    <h2>Products Page</h2>
                    <ul class=""breadcrumb lab-ul"">
                        <li><a href=""index.html"">Home</a></li>
                        <li>Shop Page</li>
                    </ul>
                </div>
            </div>
        </section>
        <!-- Page Header Section Ending Here -->

        <!-- Shop Page Section start here -->		            
        <section class=""shop-page padding-tb"">
            <div class=""container"">
                <div class=""row justify-content-center"">
                    <div class=""col-lg-9 col-12 sticky-widget"">
                        <div class=""shop-title d-flex flex-wrap justify-content-between"">
                            <p>Hiển thị 01 - 12 trên 139 kết quả</p>
                            <div class=""product-view-mode"">
                                <a class=""active"" data-target=""grid""><i clas");
            WriteLiteral(@"s=""icofont-ghost""></i></a>
                                <a data-target=""list""><i class=""icofont-listine-dots""></i></a>
                            </div>
                        </div>
                        <div class=""shop-product-wrap grid row justify-content-center"">
");
#nullable restore
#line 32 "C:\Users\minhm\source\repos\WebCovid_DA\WebCovid_DA\WepApp\Views\Product\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""col-lg-4 col-md-6 col-12"">
                                    <div class=""product-item"">
                                        <div class=""product-thumb"">
                                            <div class=""pro-thumb"">
                                                <img src=""assets/images/product/kit1.png"" alt=""shop"">
                                            </div>
                                            <div class=""product-action-link"">
                                                <a class=""view-modal"" data-target=""#quick_view""><i class=""icofont-eye""></i></a>
                                                <a href=""#""><i class=""icofont-heart""></i></a>
                                                <a href=""#""><i class=""icofont-cart-alt""></i></a>
                                            </div>
                                        </div>
                                        <div class=""product-content"">
                       ");
            WriteLiteral("                     <h5><a href=\"#\"> ");
#nullable restore
#line 47 "C:\Users\minhm\source\repos\WebCovid_DA\WebCovid_DA\WepApp\Views\Product\Index.cshtml"
                                                        Write(Html.ActionLink("Covid-19 Ag Home test ", "Details", "product"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                                            <p><i class=\"icofont-star\"></i><i class=\"icofont-star\"></i><i class=\"icofont-star\"></i><i class=\"icofont-star\"></i><i class=\"icofont-star\"></i></p>\r\n                                            <h6>");
#nullable restore
#line 49 "C:\Users\minhm\source\repos\WebCovid_DA\WebCovid_DA\WepApp\Views\Product\Index.cshtml"
                                           Write(item.Dongia);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                                        </div>
                                    </div>
                                    <div class=""product-list-item"">
                                        <div class=""product-thumb"">
                                            <div class=""pro-thumb"">
                                                <img src=""assets/images/product/kit1.png"" alt=""shop"">
                                            </div>
                                            <div class=""product-action-link"">
                                                <a class=""view-modal"" data-target=""#quick_view""><i class=""icofont-eye""></i></a>
                                                <a href=""#""><i class=""icofont-heart""></i></a>
                                                <a href=""#""><i class=""icofont-cart-alt""></i></a>
                                            </div>
                                        </div>
                                        <div class=""product-co");
            WriteLiteral("ntent\">\r\n                                            <h5><a href=\"#\"> ");
#nullable restore
#line 64 "C:\Users\minhm\source\repos\WebCovid_DA\WebCovid_DA\WepApp\Views\Product\Index.cshtml"
                                                        Write(Html.ActionLink("Covid-19 Ag Home test ", "Details", "product"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></h5>
                                            <p><i class=""icofont-star""></i><i class=""icofont-star""></i><i class=""icofont-star""></i><i class=""icofont-star""></i><i class=""icofont-star""></i></p>
                                            <h6>
                                                ");
#nullable restore
#line 67 "C:\Users\minhm\source\repos\WebCovid_DA\WebCovid_DA\WepApp\Views\Product\Index.cshtml"
                                           Write(item.Dongia);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </h6>
                                            <p>
                                                Thiết bị được thiết kế để phát hiện định tính kháng nguyên SARS-CoV-2 qua mẫu dịch ngoáy mũi ở người nghi ngờ nhiễm COVID-19<br />
                                                - Kháng thể đơn dòng kháng SARS-CoV-2 Nucleocapsid<br />
                                                - Kháng thể đơn dòng đặc hiệu với RBD Spike Protein của SARS-CoV-2<br />
                                                - Kháng thể dê kháng IgG chuột
                                            </p>
                                        </div>
                                    </div>
                                </div>
");
#nullable restore
#line 78 "C:\Users\minhm\source\repos\WebCovid_DA\WebCovid_DA\WepApp\Views\Product\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                
                            </div>
                        <div class=""paginations"">
                            <ul class=""d-flex flex-wrap lab-ul justify-content-center"">
                                <li>
                                    <a href=""#"">1</a>
                                </li>
                                <li class=""d-none d-sm-block"">
                                    <a href=""#"">2</a>
                                </li>
                                <li class=""d-none d-sm-block"">
                                    <a href=""#"" class=""active"">3</a>
                                </li>
                                <li>
                                    <a class=""dot"">...</a>
                                </li>
                                <li class=""d-none d-sm-block"">
                                    <a href=""#"">9</a>
                                </li>
                                <li class=""d-none d-sm-b");
            WriteLiteral(@"lock"">
                                    <a href=""#"">10</a>
                                </li>
                                <li>
                                    <a href=""#"">11</a>
                                </li>
                            </ul>
                        </div>
                    </div>

                    <div class=""col-lg-3 col-md-7 col-12"">
                        <aside>
                            <div class=""widget widget-search"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b248232d9c1f0a93f07084732c4091c642fdff812524", async() => {
                WriteLiteral("\r\n                                    <input type=\"text\" name=\"s\" placeholder=\"Search...\">\r\n                                    <button type=\"submit\"><i class=\"icofont-search-2\"></i></button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>

                            <div class=""widget shop-widget"">
                                <div class=""widget-header"">
                                    <h5>Doanh mục sản phẩm</h5>
                                </div>
                                <div class=""widget-wrapper"">
                                    <ul class=""shop-menu lab-ul"">
                                        <li>
                                            <a href=""#"">Hỗ trợ covid-19</a>
                                            <ul class=""shop-submenu lab-ul"">
                                                <li><a href=""#"">Bộ kit xét nghiệm</a>
");
            WriteLiteral(@"                                                </li>
                                                <li><a href=""#"">khử khuẩn</a></li>
                                                <li><a href=""#"">găng tay y tế</a></li>
                                                <li><a href=""#"">khẩu trang</a></li>
                                                <li><a href=""#"">thuốc</a></li>
                                                <li><a href=""#"">đồ bảo hộ</a></li>

                                            </ul>
                                        </li>
                                        <!--<li><a href=""#"">Monitoring Ranking</a>-->
");
            WriteLiteral("                                        <!--</li>\r\n                                        <li><a href=\"#\">Target Strategy</a>-->\r\n");
            WriteLiteral("                                        <!--</li>\r\n                                        <li><a href=\"#\">Nap Syndication</a>-->\r\n");
            WriteLiteral("                                        <!--</li>\r\n                                        <li><a href=\"#\">SEO Support</a>-->\r\n");
            WriteLiteral("                                        <!--</li>\r\n                                        <li><a href=\"#\">Email Marketing</a>-->\r\n");
            WriteLiteral("                                        <!--</li>\r\n                                        <li><a href=\"#\">Engine Marketing</a>-->\r\n");
            WriteLiteral(@"                                        <!--</li>-->
                                    </ul>
                                </div>
                            </div>

                            <div class=""widget letest-product"">
                                <div class=""widget-header"">
                                    <h5>Latests Products</h5>
                                </div>
                                <div class=""widget-wrapper"">
                                    <ul class=""lab-ul"">
                                        <li>
                                            <div class=""product-thumb"">
                                                <img src=""assets/images/shop/01.jpg"" alt=""shop"">
                                            </div>
                                            <div class=""product-content"">
                                                <h6><a href=""#"">Product Title Here</a></h6>
                                                <p><i class=""ico");
            WriteLiteral(@"font-star""></i><i class=""icofont-star""></i><i class=""icofont-star""></i><i class=""icofont-star""></i><i class=""icofont-star""></i> <span>(3 review)</span></p>
                                                <h6>₫200</h6>
                                            </div>
                                        </li>
                                        <li>
                                            <div class=""product-thumb"">
                                                <img src=""assets/images/product/Que-test-nhanh-Biomerica.jpg"" alt=""shop"">
                                            </div>
                                            <div class=""product-content"">
                                                <h6><a href=""#"">Product Title Here</a></h6>
                                                <p><i class=""icofont-star""></i><i class=""icofont-star""></i><i class=""icofont-star""></i><i class=""icofont-star""></i><i class=""icofont-star""></i> <span>(3 review)</span></p>
                      ");
            WriteLiteral(@"                          <h6>₫200</h6>
                                            </div>
                                        </li>
                                        <li>
                                            <div class=""product-thumb"">
                                                <img src=""assets/images/shop/03.jpg"" alt=""shop"">
                                            </div>
                                            <div class=""product-content"">
                                                <h6><a href=""#"">Product Title Here</a></h6>
                                                <p><i class=""icofont-star""></i><i class=""icofont-star""></i><i class=""icofont-star""></i><i class=""icofont-star""></i><i class=""icofont-star""></i> <span>(3 review)</span></p>
                                                <h6>₫200</h6>
                                            </div>
                                        </li>
                                        <li>
                  ");
            WriteLiteral(@"                          <div class=""product-thumb"">
                                                <img src=""assets/images/product/kit1.png"" alt=""shop"">
                                            </div>
                                            <div class=""product-content"">
                                                <h6><a href=""#"">Product Title Here</a></h6>
                                                <p><i class=""icofont-star""></i><i class=""icofont-star""></i><i class=""icofont-star""></i><i class=""icofont-star""></i><i class=""icofont-star""></i> <span>(3 review)</span></p>
                                                <h6>₫200</h6>
                                            </div>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </aside>
                    </div>
                </div>
                
                <div class=""modal"" id=""q");
            WriteLiteral(@"uick_view"">
                    <div class=""modal-dialog modal-lg modal-dialog-centered"">
                        <div class=""modal-content"">
                            <button type=""button"" class=""close"" data-dismiss=""modal""><i class=""icofont-close""></i></button>
                            <div class=""modal-body"">
                                <div class=""product-details-inner"">
                                    <div class=""row align-items-center"">
                                        <div class=""col-lg-5 col-12"">
                                            <div class=""thumb text-center"">
                                                <div class=""pro-thumb"">
                                                    <img src=""assets/images/shop/09.jpg"" alt=""shop"">
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""col-lg-7"">
              ");
            WriteLiteral(@"                              <div class=""product-content"">
                                                <h5><a href=""#"">Product Title Here</a></h5>
                                                <p>
                                                    <i class=""icofont-star""></i><i class=""icofont-star""></i><i class=""icofont-star""></i><i class=""icofont-star""></i><i class=""icofont-star""></i>
                                                </p>
                                                <h6>₫200</h6>
                                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo</p>
                                            </div>
                                            <div class=""cart-button"">
                                                <div class=""cart-plus-minus"">
                          ");
            WriteLiteral(@"                          <div class=""dec qtybutton"">-</div>
                                                    <input class=""cart-plus-minus-box"" type=""text"" name=""qtybutton"" value=""2"">
                                                    <div class=""inc qtybutton"">+</div>
                                                </div>
                                                <a href=""#"" class=""lab-btn""><span>Add to Cart</span></a>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
