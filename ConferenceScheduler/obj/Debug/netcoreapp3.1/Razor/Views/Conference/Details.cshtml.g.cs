#pragma checksum "C:\Users\User\source\repos\Codexio\Conference_Scheduler\ConferenceScheduler\Views\Conference\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94d57883efd4c2a1f4316aea8e8427eb4f82e1f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Conference_Details), @"mvc.1.0.view", @"/Views/Conference/Details.cshtml")]
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
#line 1 "C:\Users\User\source\repos\Codexio\Conference_Scheduler\ConferenceScheduler\Views\_ViewImports.cshtml"
using ConferenceScheduler;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\Codexio\Conference_Scheduler\ConferenceScheduler\Views\_ViewImports.cshtml"
using ConferenceScheduler.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94d57883efd4c2a1f4316aea8e8427eb4f82e1f4", @"/Views/Conference/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c02ce30af10617455c9b197a208bd93d8684059", @"/Views/_ViewImports.cshtml")]
    public class Views_Conference_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConferenceScheduler.Data.Models.Conference>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<table>\r\n    <tr>\r\n        <th>Name</th>\r\n        <th>Description</th>\r\n        <th>Start</th>\r\n        <th>End</th>\r\n        <th>Edit</th>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 14 "C:\Users\User\source\repos\Codexio\Conference_Scheduler\ConferenceScheduler\Views\Conference\Details.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 15 "C:\Users\User\source\repos\Codexio\Conference_Scheduler\ConferenceScheduler\Views\Conference\Details.cshtml"
       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 16 "C:\Users\User\source\repos\Codexio\Conference_Scheduler\ConferenceScheduler\Views\Conference\Details.cshtml"
       Write(Model.StartTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 17 "C:\Users\User\source\repos\Codexio\Conference_Scheduler\ConferenceScheduler\Views\Conference\Details.cshtml"
       Write(Model.EndTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>\r\n            <div class=\"dropdown\">\r\n                <button onclick=\"myFunction()\" class=\"dropbtn\">Edit</button>\r\n                <div id=\"myDropdown\" class=\"dropdown-content\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 568, "\"", 594, 2);
            WriteAttributeValue("", 575, "/Hall/Add/", 575, 10, true);
#nullable restore
#line 22 "C:\Users\User\source\repos\Codexio\Conference_Scheduler\ConferenceScheduler\Views\Conference\Details.cshtml"
WriteAttributeValue("", 585, Model.Id, 585, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Add Hall</a>
                    <a href=""/Session/Add/"">Add Session</a>
                    <a href=""#contact"">Add Speaker</a>
                </div>
            </div>
        </td>
    </tr>
</table>

<style>
    .dropbtn {
        background-color: #3498DB;
        color: white;
        padding: 16px;
        font-size: 16px;
        border: none;
        cursor: pointer;
    }

        .dropbtn:hover, .dropbtn:focus {
            background-color: #2980B9;
        }

    .dropdown {
        position: relative;
        display: inline-block;
    }

    .dropdown-content {
        display: none;
        position: absolute;
        background-color: #f1f1f1;
        min-width: 160px;
        overflow: auto;
        box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
        z-index: 1;
    }

        .dropdown-content a {
            color: black;
            padding: 12px 16px;
            text-decoration: none;
            display: block;
        }

    .dropdown a:");
            WriteLiteral(@"hover {
        background-color: #ddd;
    }

    .show {
        display: block;
    }
</style>

<script>
    /* When the user clicks on the button,
    toggle between hiding and showing the dropdown content */
    function myFunction() {
        document.getElementById(""myDropdown"").classList.toggle(""show"");
    }

    // Close the dropdown if the user clicks outside of it
    window.onclick = function (event) {
        if (!event.target.matches('.dropbtn')) {
            var dropdowns = document.getElementsByClassName(""dropdown-content"");
            var i;
            for (i = 0; i < dropdowns.length; i++) {
                var openDropdown = dropdowns[i];
                if (openDropdown.classList.contains('show')) {
                    openDropdown.classList.remove('show');
                }
            }
        }
    }
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConferenceScheduler.Data.Models.Conference> Html { get; private set; }
    }
}
#pragma warning restore 1591
