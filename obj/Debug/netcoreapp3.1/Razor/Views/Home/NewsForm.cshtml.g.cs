#pragma checksum "C:\Users\ASUS\source\repos\NewStudentPos\Views\Home\NewsForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1813fede53e951752e51945a46e50951fab85b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_NewsForm), @"mvc.1.0.razor-page", @"/Views/Home/NewsForm.cshtml")]
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
#line 2 "C:\Users\ASUS\source\repos\NewStudentPos\Views\Home\NewsForm.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1813fede53e951752e51945a46e50951fab85b0", @"/Views/Home/NewsForm.cshtml")]
    public class Views_Home_NewsForm : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js\"></script>\r\n<style>\r\n    ");
            WriteLiteral(@"@media screen and (max-width: 600px) {
        .col-25, .col-75, input[type=submit] {
            width: 100%;
            margin-top: 0;
        }
    }

    #addads input {
        font-size: 18px;
    }

    .adsfield {
        width: 100%;
        padding: 12px;
        border: 1px solid #ccc;
        border-radius: 4px;
        resize: vertical;
    }

    label {
        padding: 12px 12px 12px 0;
        display: inline-block;
    }

    #adssubmit {
        background-color: dodgerblue;
        color: white;
        padding: 12px 20px;
        border: none;
        border-radius: 4px;
        cursor: pointer;
        float: right;
    }

        #adssubmit:hover {
            background-color: mediumspringgreen;
        }

    .addnews {
        border-radius: 5px;
        border: 2px solid black;
        background: white;
        color: black;
        padding: 20px;
    }

    .col-25 {
        float: left;
        width: 25%;
        margin-top: 6px;");
            WriteLiteral(@"
    }

    .col-75 {
        float: left;
        width: 75%;
        margin-top: 6px;
    }

    /* Clear floats after the columns */
    .row:after {
        content: """";
        display: table;
        clear: both;
    }

    input::-webkit-outer-spin-button,
    input::-webkit-inner-spin-button {
        -webkit-appearance: none;
        margin: 0;
    }

    /* Firefox */
    #publishDate {
        -moz-appearance: textfield;
    }
</style>
<script>
    $(document).ready(function () {
        $('#addnewsblock').hide();
        $('#addNewsbtn').click(function () {
            $('#addnewsblock').show();
            $('#addarticleblock').hide();
        });
    });

</script>
<div id=""addnewsblock"" class=""addnews"">
    <h1>Новые новости</h1>
    <form method=""post"" id=""addnewsform"">
        <h4 id=""adserror"" style=""color: crimson; font-weight: normal;""></h4>
        <div class=""row"">
            <div class=""col-25"">
                <label for=""title"">Заголовок</la");
            WriteLiteral(@"bel>
            </div>
            <div class=""col-75"">
                <input type=""text"" id=""newstitle"" name=""title"" placeholder=""Ваш заголовок..."" class=""adsfield"">
            </div>
        </div>
        <div class=""row"">
            <div class=""col-25"">
                <label for=""salary"">Дата публикации</label>
            </div>
            <div class=""col-75"">
                <input type=""date"" id=""newspublishDate"" name=""publishDate"" placeholder=""Ваша дата публикации..."" class=""adsfield"">
            </div>
        </div>
        <div class=""row"">
            <div class=""col-25"">
                <label for=""description"">Описание</label>
            </div>
            <div class=""col-75"">
                <textarea id=""newsdescription"" class=""adsfield"" name=""description"" placeholder=""Разместите здесь описание новостей..."" style=""height:200px""></textarea>
            </div>
        </div>
        <div class=""row"">
            <input type=""submit"" value=""Submit"" id=""adssubmit"">
");
            WriteLiteral(@"        </div>
    </form>
</div>
<script>

    $('#addnewsform').submit(function (e) {
        e.preventDefault();
        let art = {
            Title: $('#newstitle').val(),
            PublishDate: $('#newspublishDate').val(),
            Description: $('#newsdescription').val()
        };
        alert(JSON.stringify(art));
        var isValid = false;
        for (var key in art) {
            if (art[key] === '') isValid = true;
        };
        if (isValid === true) $('#adserror').html(""Fill all fields"");
        else {
            $.ajax({
                method: ""POST"",
                headers: {
               'Authorization': ""Bearer ");
#nullable restore
#line 144 "C:\Users\ASUS\source\repos\NewStudentPos\Views\Home\NewsForm.cshtml"
                                   Write(HttpContextAccessor.HttpContext.Session.GetString("Token"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
                },
                async: false,
                url: ""/news/add"",
                data: JSON.stringify(art),
                contentType: ""application/json; charset=utf-8"",
                success: function (response) {
                    window.location.replace('/home/index');
                },
                error: function (response) {
                    alert(JSON.stringify(response));
                    $('#adserror').html(""These news already exist"");
                }
            });
        }
    });
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Views_Home_NewsForm> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Views_Home_NewsForm> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Views_Home_NewsForm>)PageContext?.ViewData;
        public Views_Home_NewsForm Model => ViewData.Model;
    }
}
#pragma warning restore 1591
