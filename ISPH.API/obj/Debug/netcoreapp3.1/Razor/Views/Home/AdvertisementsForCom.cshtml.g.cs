#pragma checksum "C:\Users\ASUS\source\repos\ISPH\ISPH.API\Views\Home\AdvertisementsForCom.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58251a5622ad6f227dcd18d87c5167eb3bc9ab21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AdvertisementsForCom), @"mvc.1.0.view", @"/Views/Home/AdvertisementsForCom.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58251a5622ad6f227dcd18d87c5167eb3bc9ab21", @"/Views/Home/AdvertisementsForCom.cshtml")]
    public class Views_Home_AdvertisementsForCom : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script>
    $(document).ready(function(){
        var url = substr(5, location.pathname);
        $.get(
            url
        ).done(function (data) {
            if (data.length === 0) $('.advertisements').append('<h1 style=""display; block;color: black; font-size: 2.2em; margin: 0 auto;"">Sorry, there are no advertisements for this company at the moment.</h1>')
            let ads = data;
            for (let i = 0; i < data.length; i++) {
                $('.advertisements').append('<div class=""advertisement""><h1>' + ads[i].title + '</h1>' +
                    '<h3>Зарплата: ' + ads[i].salary + ' KZT</h3><h3 style=""margin: 20px 0; color: mediumspringgreen;"">Компания: ' + ads[i].employer.companyName + '</h3><a href=""/home/advertisements/id=' + ads[i].advertisementId + '"">Узнать больше...</a></div>');
            }
        });
    });
</script>
<div class=""advertisements"">

</div>");
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
