#pragma checksum "C:\Users\ASUS\source\repos\NewStudentPos\Views\Home\AdvertisementsForPos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1f189e1cad70d49c036dc7cdb58e7782bf1d6d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AdvertisementsForPos), @"mvc.1.0.razor-page", @"/Views/Home/AdvertisementsForPos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1f189e1cad70d49c036dc7cdb58e7782bf1d6d1", @"/Views/Home/AdvertisementsForPos.cshtml")]
    public class Views_Home_AdvertisementsForPos : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script>
    var url = substr(5, location.pathname);
    $.get(
        url
    ).done(function (data) {
        let ads = data;
        for (let i = 0; i < data.length; i++) {
            $('.advertisementspos').append('<div class=""advertisement""><h1>' + ads[i].title + '</h1>' +
                '<h3>Зарплата: ' + ads[i].salary + ' KZT</h3><a href=""/home/advertisements/id=' + ads[i].advertisementId + '"">Узнать больше...</a></div>');
        }
    });
</script>
<style>
    .advertisementspos {
        font-family: Bahnschrift, Arial, Helvetica, sans-serif;
    }

        .advertisementspos .advertisement {
            margin: 40px 0;
            background: white;
            border: 2px solid black;
            padding: 20px;
            color: black;
        }

        .advertisementspos h1 {
            border-bottom: 2px solid crimson;
            padding-bottom: 10px;
            margin: 20px 0;
            font-size: 2em;
        }

        .advertisementspos h3 {
            color: dodgerblue;
         ");
            WriteLiteral(@"   margin: 20px 0;
        }

        .advertisementspos a {
            background-color: dodgerblue;
            border: 2px solid white;
            padding: 10px 20px;
            text-decoration: none;
            color: white;
            border: 2px solid black;
        }

            .advertisementspos a:hover {
                color: black;
                background-color: mediumspringgreen;
            }
</style>
<div class=""advertisementspos"">

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Views_Home_AdvertisementsForPos> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Views_Home_AdvertisementsForPos> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Views_Home_AdvertisementsForPos>)PageContext?.ViewData;
        public Views_Home_AdvertisementsForPos Model => ViewData.Model;
    }
}
#pragma warning restore 1591
