#pragma checksum "C:\Users\ASUS\source\repos\ISPH\ISPH.API\Views\Home\LoginForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10ec565dee9a379ead2652d24b0173208784fe6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_LoginForm), @"mvc.1.0.view", @"/Views/Home/LoginForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10ec565dee9a379ead2652d24b0173208784fe6f", @"/Views/Home/LoginForm.cshtml")]
    public class Views_Home_LoginForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""modal fade"" id=""signinModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""signinModalLabel"" aria-hidden=""true"">
      <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
          <div class=""modal-header"">
            <h5 class=""modal-title"" id=""exampleModalLabel"">Sign in</h5>
            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
              <span aria-hidden=""true"">&times;</span>
            </button>
          </div>
          <div class=""modal-body"">
            
              <form method=""post"" id=""authorisation"">

                  <div class=""form-row row"">
                      <label class=""role-block d-block col-md-6"">
                          <span style=""margin-left: 30px;"">Employer</span>
                          <input class=""employerradio"" name=""authuser"" value=""employer"" id=""regemp"" type=""radio"">
                          <span class=""checkmark""></span>
                      </label>
             ");
            WriteLiteral(@"         <label class=""role-block d-block col-md-6"">
                          <span style=""margin-left: 30px;"">Student</span>
                          <input class=""studentradio"" name=""authuser"" value=""student"" id=""regst"" type=""radio"" checked>
                          <span class=""checkmark""></span>
                      </label>
                  </div>

                  <div class=""form-row"">
                      <h4 id=""autherror"" style=""color: crimson; text-align: center; font-weight: normal;""></h4>
                  </div>
                  <div class=""form-row"">
                      <label for=""AuthEmail"">Email</label>
                      <input type=""email"" class=""form-control"" id=""AuthEmail"" placeholder=""Email"">
                  </div>
                  <div class=""form-row"">
                      <label for=""AuthPassword"">Password</label>
                      <input type=""password"" class=""form-control"" id=""AuthPassword"" placeholder=""Password"">
                  </div>

  ");
            WriteLiteral(@"                <button type=""submit"" class=""btn btn-primary"" style=""margin-top: 30px;"">Sign in</button>
              </form>


          </div>
          <div class=""modal-footer"">
            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
          </div>
        </div>
      </div>
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
