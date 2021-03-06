#pragma checksum "C:\Users\Justin\OneDrive\dotNET CA\Views\Home\ProductDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67ded919c265dbb4ac144fb759fd25153fa81155"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ProductDetails), @"mvc.1.0.view", @"/Views/Home/ProductDetails.cshtml")]
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
#line 1 "C:\Users\Justin\OneDrive\dotNET CA\Views\_ViewImports.cshtml"
using ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Justin\OneDrive\dotNET CA\Views\_ViewImports.cshtml"
using ShoppingCart.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67ded919c265dbb4ac144fb759fd25153fa81155", @"/Views/Home/ProductDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a65a8198b297c3ea7f3bc4f7f8cdac67c148a265", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ProductDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Justin\OneDrive\dotNET CA\Views\Home\ProductDetails.cshtml"
  
    Layout = "_Layout2";
    ViewData["Title"] = "ProductDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Justin\OneDrive\dotNET CA\Views\Home\ProductDetails.cshtml"
  
    var productDetails = (Product)ViewData["productDetails"];
    var similarProducts = (List<Product>)ViewData["similarproducts"];
    var similartext = (string)ViewData["similarText"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\Justin\OneDrive\dotNET CA\Views\Home\ProductDetails.cshtml"
  

    var comments = (List<ProductComments>)ViewData["Comments"];
    var ratingSum =(int) ViewData["RatingSum"];
    var ratingCount = (int)ViewData["RatingCount"];

    decimal rating = 0;
    if (ratingCount > 0)
    {
        rating = (ratingSum / ratingCount);
    }
    var totalRating = decimal.Parse(rating.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script type=\'text/javascript\' src=\'//ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js\'></script>\r\n");
            WriteLiteral("\r\n<h1>Product Details</h1>\r\n<p>\r\n    <img");
            BeginWriteAttribute("src", " src=", 847, "", 876, 1);
#nullable restore
#line 32 "C:\Users\Justin\OneDrive\dotNET CA\Views\Home\ProductDetails.cshtml"
WriteAttributeValue("", 852, productDetails.ImageURL, 852, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 876, "\"", 902, 1);
#nullable restore
#line 32 "C:\Users\Justin\OneDrive\dotNET CA\Views\Home\ProductDetails.cshtml"
WriteAttributeValue("", 882, productDetails.Name, 882, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 25%\" /><br /><br />\r\n    <b>Price:</b> $");
#nullable restore
#line 33 "C:\Users\Justin\OneDrive\dotNET CA\Views\Home\ProductDetails.cshtml"
              Write(productDetails.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    <b>Name:</b> ");
#nullable restore
#line 34 "C:\Users\Justin\OneDrive\dotNET CA\Views\Home\ProductDetails.cshtml"
            Write(productDetails.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    <b>Category:</b> ");
#nullable restore
#line 35 "C:\Users\Justin\OneDrive\dotNET CA\Views\Home\ProductDetails.cshtml"
                Write(productDetails.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    <b>Brand:</b> ");
#nullable restore
#line 36 "C:\Users\Justin\OneDrive\dotNET CA\Views\Home\ProductDetails.cshtml"
             Write(productDetails.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    <b>Description:</b> ");
#nullable restore
#line 37 "C:\Users\Justin\OneDrive\dotNET CA\Views\Home\ProductDetails.cshtml"
                   Write(productDetails.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
    <div>
        <span class=""starFadeN"" id=""sRate1""> </span>
        <span class=""starFadeN"" id=""sRate2""> </span>
        <span class=""starFadeN"" id=""sRate3""></span>
        <span class=""starFadeN"" id=""sRate4""></span>
        <span class=""starFadeN"" id=""sRate5""></span>
    </div>
    ");
#nullable restore
#line 45 "C:\Users\Justin\OneDrive\dotNET CA\Views\Home\ProductDetails.cshtml"
Write(Html.ActionLink("Add to cart", "AddToCart", "MyCart", new { productid = productDetails.Id }, new { @class = "btn btn-xs btn-outline btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n    ");
#nullable restore
#line 46 "C:\Users\Justin\OneDrive\dotNET CA\Views\Home\ProductDetails.cshtml"
Write(Html.ActionLink("Back To Gallery", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n");
#nullable restore
#line 48 "C:\Users\Justin\OneDrive\dotNET CA\Views\Home\ProductDetails.cshtml"
 foreach (var c in comments)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <hr />\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            <i>");
#nullable restore
#line 53 "C:\Users\Justin\OneDrive\dotNET CA\Views\Home\ProductDetails.cshtml"
          Write(c.ThisDateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n            <br />\r\n");
#nullable restore
#line 55 "C:\Users\Justin\OneDrive\dotNET CA\Views\Home\ProductDetails.cshtml"
             for (var i = 1; i <= c.Rating; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"starGlowN\"></span>\r\n");
#nullable restore
#line 58 "C:\Users\Justin\OneDrive\dotNET CA\Views\Home\ProductDetails.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\Justin\OneDrive\dotNET CA\Views\Home\ProductDetails.cshtml"
             for (var i = (c.Rating + 1); i <= 5; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"starFadeN\"></span>\r\n");
#nullable restore
#line 62 "C:\Users\Justin\OneDrive\dotNET CA\Views\Home\ProductDetails.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"col-md-9\">\r\n");
#nullable restore
#line 65 "C:\Users\Justin\OneDrive\dotNET CA\Views\Home\ProductDetails.cshtml"
             if (c.Comments != null)
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\Justin\OneDrive\dotNET CA\Views\Home\ProductDetails.cshtml"
           Write(Html.Raw(c.Comments.Replace("\n", "<br />")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 71 "C:\Users\Justin\OneDrive\dotNET CA\Views\Home\ProductDetails.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<hr />\r\n");
#nullable restore
#line 73 "C:\Users\Justin\OneDrive\dotNET CA\Views\Home\ProductDetails.cshtml"
Write(Html.Partial("_CommentBox", new ViewDataDictionary(ViewData) { { "ProductDetail", productDetails } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script>\r\n    function SCRate() {\r\n\r\n            for (var i = 1; i <= ");
#nullable restore
#line 77 "C:\Users\Justin\OneDrive\dotNET CA\Views\Home\ProductDetails.cshtml"
                            Write(totalRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("; i++) {\r\n            $(\"#sRate\" + i).attr(\'class\', \'starGlowN\');\r\n\r\n        }\r\n    }\r\n    $(document).ready(function () {\r\n        SCRate();\r\n    });\r\n</script>\r\n<h2>");
#nullable restore
#line 86 "C:\Users\Justin\OneDrive\dotNET CA\Views\Home\ProductDetails.cshtml"
Write(similartext);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<div class=\"col-md-12 row\">\r\n");
#nullable restore
#line 88 "C:\Users\Justin\OneDrive\dotNET CA\Views\Home\ProductDetails.cshtml"
     foreach (Product sproduct in similarProducts)
    {
        if (sproduct.Id != productDetails.Id)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-2 text-center align-items-center\">\r\n                <img");
            BeginWriteAttribute("src", " src=", 2923, "", 2946, 1);
#nullable restore
#line 93 "C:\Users\Justin\OneDrive\dotNET CA\Views\Home\ProductDetails.cshtml"
WriteAttributeValue("", 2928, sproduct.ImageURL, 2928, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2946, "\"", 2966, 1);
#nullable restore
#line 93 "C:\Users\Justin\OneDrive\dotNET CA\Views\Home\ProductDetails.cshtml"
WriteAttributeValue("", 2952, sproduct.Name, 2952, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%\" /><br />\r\n                $");
#nullable restore
#line 94 "C:\Users\Justin\OneDrive\dotNET CA\Views\Home\ProductDetails.cshtml"
            Write(sproduct.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                ");
#nullable restore
#line 95 "C:\Users\Justin\OneDrive\dotNET CA\Views\Home\ProductDetails.cshtml"
           Write(Html.ActionLink(sproduct.Name, "ProductDetails", "Home",
                new { productid = sproduct.Id }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
            WriteLiteral("                ");
#nullable restore
#line 98 "C:\Users\Justin\OneDrive\dotNET CA\Views\Home\ProductDetails.cshtml"
           Write(Html.ActionLink("Add to cart", "AddToCart", "MyCart", new { productid = sproduct.Id }, new { @class = "btn btn-xs btn-outline btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 101 "C:\Users\Justin\OneDrive\dotNET CA\Views\Home\ProductDetails.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
