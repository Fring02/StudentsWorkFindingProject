#pragma checksum "C:\Users\ASUS\source\repos\ISPH\ISPH.API\Views\Home\Advertisement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0fb02df29c4575e92493a949a9ad73ed7408cf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Advertisement), @"mvc.1.0.view", @"/Views/Home/Advertisement.cshtml")]
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
#line 1 "C:\Users\ASUS\source\repos\ISPH\ISPH.API\Views\Home\Advertisement.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0fb02df29c4575e92493a949a9ad73ed7408cf1", @"/Views/Home/Advertisement.cshtml")]
    public class Views_Home_Advertisement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/microsoft/signalr/dist/browser/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0fb02df29c4575e92493a949a9ad73ed7408cf13122", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    let emp = null;
    var url = substr(5, location.pathname);
    $.get(
        url
    ).done(function (data) {
        let ad = data;
        emp = ad.employer;
        $('.adstitle').html(ad.title);
        $('.adssalary').html('Зарплата: ' + ad.salary + ' KZT');
        $('.adscompany').html('Компания: ' + emp.companyName);
        $('.adsinfo').html(ad.description);
        $('.contact-name').html(emp.firstName + "" "" + emp.lastName);
        $('.contact-email').html('Почта: ' + emp.email);
        let userName = '");
#nullable restore
#line 18 "C:\Users\ASUS\source\repos\ISPH\ISPH.API\Views\Home\Advertisement.cshtml"
                   Write(HttpContextAccessor.HttpContext.Session.GetString("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n        let role = \'");
#nullable restore
#line 19 "C:\Users\ASUS\source\repos\ISPH\ISPH.API\Views\Home\Advertisement.cshtml"
               Write(HttpContextAccessor.HttpContext.Session.GetString("Role"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n        let id = \'");
#nullable restore
#line 20 "C:\Users\ASUS\source\repos\ISPH\ISPH.API\Views\Home\Advertisement.cshtml"
             Write(HttpContextAccessor.HttpContext.Session.GetInt32("Id"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n        if (role !== \"employer\") {\r\n            let fav = \'/users/students/id=");
#nullable restore
#line 22 "C:\Users\ASUS\source\repos\ISPH\ISPH.API\Views\Home\Advertisement.cshtml"
                                     Write(HttpContextAccessor.HttpContext.Session.GetInt32("Id"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"/favourites/ad=' + ad.advertisementId;
            $.get(
                fav
            ).done(function (data) {
                if (data === undefined) {
                    $('.favourites').append('<form action=""' + fav + '/add"" method=""post"">' +
                        '<button type=""submit"" class=""hoverbtn signout"" style=""background-color: mediumspringgreen"">Добавить в избранное</button></form>');
                } else {
                    $('.favourites').append('<form action=""' + fav + '/delete"" method=""post"">' +
                '<button type=""submit"" class=""hoverbtn signout"" style=""background-color: crimson"">Удалить из избранного</button></form>');
                }
            });
        }
        if (id > 0) {
            $.get(
                '/users/employers/id=' + id
            ).done(function (employer) {
                if (employer.email == emp.email) {
                    $('.adsblock').append('<ul style=""margin-top: 20px;"">' +
                        '<li style=""mar");
            WriteLiteral(@"gin-bottom: 15px; list-style-type: none;"" class=""changeadstitleli""><button type=""button"" id=""changeadstitlebtn"" class=""signout hoverbtn"">Изменить заголовок</button></li>' +

                        '<li style=""margin-bottom: 15px; list-style-type: none;"" class=""changeadssalaryli""><button type=""button"" id=""changeadssalarybtn"" class=""signout hoverbtn"">Изменить зарплату</button></li>' +

                        '<li style=""margin-bottom: 15px; list-style-type: none;"" class=""changeadsdescli""><button type=""button"" id=""changeadsdescbtn"" class=""signout hoverbtn"">Изменить описание</button></li></ul>');

                    $('#changeadstitlebtn').click(function () {
                        $('.changeadstitleli').append('<h5 id=""changeadstitleinfo""></h5><form id=""changeadstitle-form""><input type=""text"" id=""newadstitle"" style=""font-size: 17px; padding: 3px 0;""><br><br><button type=""submit"" class=""signout hoverbtn"" style=""background-color: dodgerblue"">Отправить</button></form>');
                        $('#chan");
            WriteLiteral(@"geadstitle-form').submit(function (e) {
                            e.preventDefault();
                            ad.title = $('#newadstitle').val();
                            $.ajax({
                                method: ""PUT"",
                                headers: {
                                    'Authorization': ""Bearer ");
#nullable restore
#line 55 "C:\Users\ASUS\source\repos\ISPH\ISPH.API\Views\Home\Advertisement.cshtml"
                                                        Write(HttpContextAccessor.HttpContext.Session.GetString("Token"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
                                },
                                async: false,
                                url: ""/advertisements/id="" + ad.advertisementId + ""/update"",
                                data: JSON.stringify(ad),
                                contentType: ""application/json; charset=utf-8"",
                                success: function (data) {
                                    window.location.reload();
                                },
                                error: function (data) {
                                    $('#changeadstitleinfo').html(""<span style='color: crimson;'>Failed to update password</span>"");
                                }
                            });
                        });
                    });



                    $('#changeadssalarybtn').click(function () {
                        $('.changeadssalaryli').append('<h5 id=""changeadssalaryinfo""></h5><form id=""changeadssalary-form""><input type=""number"" id=""newadssalary");
            WriteLiteral(@""" style=""font-size: 17px; padding: 3px 0;""><br><br><button type=""submit"" class=""signout hoverbtn"" style=""background-color: dodgerblue"">Отправить</button></form>');
                        $('#changeadssalary-form').submit(function (e) {
                            e.preventDefault();
                            ad.salary = $('#newadssalary').val();
                            $.ajax({
                                method: ""PUT"",
                                headers: {
                                    'Authorization': ""Bearer ");
#nullable restore
#line 81 "C:\Users\ASUS\source\repos\ISPH\ISPH.API\Views\Home\Advertisement.cshtml"
                                                        Write(HttpContextAccessor.HttpContext.Session.GetString("Token"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
                                },
                                async: false,
                                url: ""/advertisements/id="" + ad.advertisementId + ""/update"",
                                data: JSON.stringify(ad),
                                contentType: ""application/json; charset=utf-8"",
                                success: function (data) {
                                    window.location.reload();
                                },
                                error: function (data) {
                                    $('#changeadssalaryinfo').html(""<span style='color: crimson;'>Failed to update password</span>"");
                                }
                            });
                        });
                    });

                    $('#changeadsdescbtn').click(function () {
                        $('.changeadsdescli').append('<h5 id=""changeadsdescinfo""></h5><form id=""changeadsdesc-form""><textarea id=""newadsdesc"" style=""font-size: 15px");
            WriteLiteral(@";""></textarea><br><br><button type=""submit"" class=""signout hoverbtn"" style=""background-color: dodgerblue"">Отправить</button></form>');
                        $('#changeadsdesc-form').submit(function (e) {
                            e.preventDefault();
                            ad.description = $('#newadsdesc').val();
                            $.ajax({
                                method: ""PUT"",
                                headers: {
                                    'Authorization': ""Bearer ");
#nullable restore
#line 105 "C:\Users\ASUS\source\repos\ISPH\ISPH.API\Views\Home\Advertisement.cshtml"
                                                        Write(HttpContextAccessor.HttpContext.Session.GetString("Token"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
                                },
                                async: false,
                                url: ""/advertisements/id="" + ad.advertisementId + ""/update"",
                                data: JSON.stringify(ad),
                                contentType: ""application/json; charset=utf-8"",
                                success: function (data) {
                                    window.location.reload();
                                },
                                error: function (data) {
                                    $('#changeadsdescinfo').html(""<span style='color: crimson;'>Failed to update password</span>"");
                                }
                            });
                        });
                    });
                }
            });
        }
        if (userName !== '') {
            let role = '");
#nullable restore
#line 124 "C:\Users\ASUS\source\repos\ISPH\ISPH.API\Views\Home\Advertisement.cshtml"
                   Write(HttpContextAccessor.HttpContext.Session.GetString("Role"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n            let resume = null;\r\n            if (role !== \"employer\") {\r\n                $.get(\r\n                    \'/users/students/id=");
#nullable restore
#line 128 "C:\Users\ASUS\source\repos\ISPH\ISPH.API\Views\Home\Advertisement.cshtml"
                                   Write(HttpContextAccessor.HttpContext.Session.GetInt32("Id"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"/resume'
                ).done(function (data) {
                    if (data === undefined) resume = null;
                    else resume = data;
                });
            }
            const hubConnection = new signalR.HubConnectionBuilder()
                .withUrl(""/chat"")
                .build();
            hubConnection.on('Send', function (message, userName) {
                if (message.length !== 0) {
                    $('#chatroom').append(""<p><span style='font-weight:bold;'>"" + userName + ""<span>: "" + message + ""</p><br>"");
                }
                
            });
            hubConnection.on('SendResume', function (url) {
                $.get(
                    url
                ).done(function (data) {
                    $('#chatroom').append('<form style=""margin: 20px 0;"" action=""' + url + '"" method=""post"" enctype=""multipart/form-data"">' +
                        '<button type=""submit"" class=""signout hoverbtn"" style=""background-color: mediumspringg");
            WriteLiteral(@"reen; pad""> ' + data.name + '</button></form>');
                });
            });
            $(""#sendBtn"").click(function (e) {
                let message = document.getElementById(""message"").value;
                hubConnection.invoke(""Send"", message, userName, emp.firstName, role);
            });
            $(""#sendResumeBtn"").click(function (e) {
                if (resume === null) {
                    $('.chaterror').html(""Sorry, but you don't have your resume uploaded in profile"");
                }
                else {
                    let url = ""/users/students/id=");
#nullable restore
#line 160 "C:\Users\ASUS\source\repos\ISPH\ISPH.API\Views\Home\Advertisement.cshtml"
                                             Write(HttpContextAccessor.HttpContext.Session.GetInt32("Id"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"/resume"";
                    hubConnection.invoke(""SendResume"", url);
                }
            });
            hubConnection.start().then(function () {
                hubConnection.invoke(""Send"", """", userName, emp.firstName, role);
            });
        } else {
            $(""#sendBtn"").click(function() {
                $('.chaterror').html(""Вы должны войти в систему"");
            });
        }
    });
</script>
<style>
    .adsblock {
        font-family: Bahnschrift, Arial, serif;
        padding: 20px;
        border: 2px solid black;
        background: rgba(0,0,0,0.8);
        color: white;
    }

    .adstitle {
        font-style: italic;
        font-size: 2.5em;
    }

    .adssalary {
        margin-left: 30px;
        font-size: 20px;
        color: dodgerblue;
    }

    .adscompany {
        font-size: 25px;
        font-weight: bold;
        margin: 30px 0;
        color: crimson;
        margin-left: 30px;
    }

    .contact-list {
       ");
            WriteLiteral(@" border-top: 2px solid black;
        border-bottom: 2px solid black;
        padding: 10px;
        list-style-type: none;
    }

    .adsinfo {
        padding: 10px;
        font-size: 1.3em;
        color: black;
    }
</style>
<div class=""adsblock"">
");
#nullable restore
#line 216 "C:\Users\ASUS\source\repos\ISPH\ISPH.API\Views\Home\Advertisement.cshtml"
          
            string role = HttpContextAccessor.HttpContext.Session.GetString("Role");
            if (role != "employer")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h1 class=\"favourites\"></h1>\r\n");
#nullable restore
#line 221 "C:\Users\ASUS\source\repos\ISPH\ISPH.API\Views\Home\Advertisement.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <h1 class=""adstitle"" style=""margin: 20px 0;""></h1>
        <div class=""adssalary"" style=""margin: 20px 0;""></div>
        <div class=""adscompany"" style=""margin: 20px 0;""></div>
        <div class=""adsinfo"" style=""margin: 20px 0; color: white;"">
        </div>
        <ul class=""contact-list"" style=""margin: 20px 0;"">
            <h2 class=""contact-title"">Контакты:</h2>
            <li class=""contact-name""></li>
            <li class=""contact-email""></li>
        </ul>
        <div class=""chat"">
            <h4>Написать</h4>
            <div id=""chatroom"" style=""border: 2px solid black; padding: 20px; max-width: 50%; margin: 20px; background: white; color: black;""></div>
            <div id=""inputForm"" style=""margin-bottom: 30px"">
                <textarea placeholder=""Введите здесь сообщение..."" type=""text"" id=""message"" style=""background: black; border: none; color: white; padding: 15px; font-size: 18px;""></textarea>
                <button type=""button"" id=""sendBtn"" class=""signout hoverb");
            WriteLiteral("tn\" style=\"background: dodgerblue; padding: 10px 20px; margin-left: 20px;\">Отправить</button>\r\n");
#nullable restore
#line 238 "C:\Users\ASUS\source\repos\ISPH\ISPH.API\Views\Home\Advertisement.cshtml"
                 if (role != "employer")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button type=\"button\" id=\"sendResumeBtn\" class=\"signout hoverbtn\" style=\"background: dodgerblue; padding: 10px 20px; margin-left: 20px;\">Отправить резюме</button>\r\n");
#nullable restore
#line 241 "C:\Users\ASUS\source\repos\ISPH\ISPH.API\Views\Home\Advertisement.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h3 class=\"chaterror\" style=\"color: crimson; margin-left: 20px; margin-top: 20px\"></h3>\r\n            </div>\r\n        </div>\r\n");
            WriteLiteral("    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
