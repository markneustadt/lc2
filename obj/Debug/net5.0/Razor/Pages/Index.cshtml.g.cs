#pragma checksum "/Users/markneustadt/Projects/lc2/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48e6a0357b16c1195ab1adbca7bbd5eb8874778c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(lc2.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace lc2.Pages
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
#line 1 "/Users/markneustadt/Projects/lc2/Pages/_ViewImports.cshtml"
using lc2;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48e6a0357b16c1195ab1adbca7bbd5eb8874778c", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcb86c02a68987ac8f08ed34a333488efde97b5f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/markneustadt/Projects/lc2/Pages/Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    var mod2 = Model.Results.Results;
    //TimeZoneInfo cstZone = TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time");
    //DateTime cstTime = TimeZoneInfo.ConvertTimeFromUtc(@mod2.AsOfDate.DateTime, cstZone);
    var cst = @mod2.AsOfDate.DateTime.ToLocalTime().ToLongDateString();
    var asOfDate = cst;//Time.ToLongDateString();

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .markrules {\r\n        width: 60px;\r\n        height: 40px;\r\n        box-shadow: unset;\r\n        font-size: x-large;\r\n        text-align: center\r\n    }\r\n</style>\r\n");
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">LottoChecker</h1>
    <p>Enter the winning numbers here</p>

    <div class=""row"">
        <div class=""col"">
            <div class=""form-group"">
                <label for=""win1"">1</label>
                <input class=""markrules"" onkeyup=""doEval()""");
            BeginWriteAttribute("value", " value=\"", 918, "\"", 947, 1);
#nullable restore
#line 30 "/Users/markneustadt/Projects/lc2/Pages/Index.cshtml"
WriteAttributeValue("", 926, mod2.Values[0].Value, 926, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""text"" id=""win1"" name=""win1"" maxlength=""2"" />
            </div>
        </div>
        <div class=""col"">
            <div class=""form-group"">
                <label for=""win2"">2</label>
                <input class=""markrules"" onkeyup=""doEval()""");
            BeginWriteAttribute("value", " value=\"", 1206, "\"", 1235, 1);
#nullable restore
#line 36 "/Users/markneustadt/Projects/lc2/Pages/Index.cshtml"
WriteAttributeValue("", 1214, mod2.Values[1].Value, 1214, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""text"" id=""win2"" name=""win2"" maxlength=""2"" />
            </div>
        </div>
        <div class=""col"">
            <div class=""form-group"">
                <label for=""win3"">3</label>
                <input class=""markrules"" onkeyup=""doEval()""");
            BeginWriteAttribute("value", " value=\"", 1494, "\"", 1523, 1);
#nullable restore
#line 42 "/Users/markneustadt/Projects/lc2/Pages/Index.cshtml"
WriteAttributeValue("", 1502, mod2.Values[2].Value, 1502, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""text"" id=""win3"" name=""win3"" maxlength=""2"" />
            </div>
        </div>
        <div class=""col"">
            <div class=""form-group"">
                <label for=""win4"">4</label>
                <input class=""markrules"" onkeyup=""doEval()""");
            BeginWriteAttribute("value", " value=\"", 1782, "\"", 1811, 1);
#nullable restore
#line 48 "/Users/markneustadt/Projects/lc2/Pages/Index.cshtml"
WriteAttributeValue("", 1790, mod2.Values[3].Value, 1790, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""text"" id=""win4"" name=""win4"" maxlength=""2"" />
            </div>
        </div>
        <div class=""col"">
            <div class=""form-group"">
                <label for=""win5"">5</label>
                <input class=""markrules"" onkeyup=""doEval()""");
            BeginWriteAttribute("value", " value=\"", 2070, "\"", 2099, 1);
#nullable restore
#line 54 "/Users/markneustadt/Projects/lc2/Pages/Index.cshtml"
WriteAttributeValue("", 2078, mod2.Values[4].Value, 2078, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""text"" id=""win5"" name=""win5"" maxlength=""2"" />
            </div>
        </div>
        <div class=""col"">
            <div class=""form-group"">
                <label for=""winPB"">Power</label>
                <input class=""markrules"" onkeyup=""doEval()""");
            BeginWriteAttribute("value", " value=\"", 2363, "\"", 2392, 1);
#nullable restore
#line 60 "/Users/markneustadt/Projects/lc2/Pages/Index.cshtml"
WriteAttributeValue("", 2371, mod2.Values[5].Value, 2371, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""text"" id=""winPB"" name=""winPB"" maxlength=""2"" />
            </div>
        </div>
        <div class=""col"">
            <div class=""form-group"">
                <button class='btn-primary' style='height:40px;' onclick='clearWinners()' value='Clear winners'>Clear Winners</button>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col"">
            <p>
                <h2>Results as of: ");
#nullable restore
#line 72 "/Users/markneustadt/Projects/lc2/Pages/Index.cshtml"
                              Write(asOfDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
            </p>
        </div>
    </div>
    <div class=""row"">
        <div class=""col"">
            <table class=""table table-striped"">
                <thead class=""thead-dark"">
                    <tr>
                        <th>One</th>
                        <th>Two</th>
                        <th>Three</th>
                        <th>Four</th>
                        <th>Five</th>
                        <th>Power</th>
                        <th>Result</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>
                            <input class=""markrules"" onkeyup=""doEval()"" type=""text"" id=""pick11"" name=""pick11"" maxlength=""2"" />
                        </td>
                        <td>
                            <input class=""markrules"" onkeyup=""doEval()"" type=""text"" id=""pick12"" name=""pick12"" maxlength=""2"" />
                        </td>
                        <td>
               ");
            WriteLiteral(@"             <input class=""markrules"" onkeyup=""doEval()"" type=""text"" id=""pick13"" name=""pick13"" maxlength=""2"" />
                        </td>
                        <td>
                            <input class=""markrules"" onkeyup=""doEval()"" type=""text"" id=""pick14"" name=""pick14"" maxlength=""2"" />
                        </td>
                        <td>
                            <input class=""markrules"" onkeyup=""doEval()"" type=""text"" id=""pick15"" name=""pick15"" maxlength=""2"" />
                        </td>
                        <td>
                            <input class=""markrules"" onkeyup=""doEval()"" type=""text"" id=""pick1P"" name=""pick1P"" maxlength=""2"" />
                        </td>
                        <td>
                            <span id=""result1"" name=""result1""></span>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <input class=""markrules"" onkeyup=""doEval()"" type=""text"" id=""pick21"" na");
            WriteLiteral(@"me=""pick21"" maxlength=""2"" />
                        </td>
                        <td>
                            <input class=""markrules"" onkeyup=""doEval()"" type=""text"" id=""pick22"" name=""pick22"" maxlength=""2"" />
                        </td>
                        <td>
                            <input class=""markrules"" onkeyup=""doEval()"" type=""text"" id=""pick23"" name=""pick23"" maxlength=""2"" />
                        </td>
                        <td>
                            <input class=""markrules"" onkeyup=""doEval()"" type=""text"" id=""pick24"" name=""pick24"" maxlength=""2"" />
                        </td>
                        <td>
                            <input class=""markrules"" onkeyup=""doEval()"" type=""text"" id=""pick25"" name=""pick25"" maxlength=""2"" />
                        </td>
                        <td>
                            <input class=""markrules"" onkeyup=""doEval()"" type=""text"" id=""pick2P"" name=""pick2P"" maxlength=""2"" />
                        </td>
                  ");
            WriteLiteral(@"      <td>
                            <span id=""result2"" name=""result2""></span>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <input class=""markrules"" onkeyup=""doEval()"" type=""text"" id=""pick31"" name=""pick31"" maxlength=""2"" />
                        </td>
                        <td>
                            <input class=""markrules"" onkeyup=""doEval()"" type=""text"" id=""pick32"" name=""pick32"" maxlength=""2"" />
                        </td>
                        <td>
                            <input class=""markrules"" onkeyup=""doEval()"" type=""text"" id=""pick33"" name=""pick33"" maxlength=""2"" />
                        </td>
                        <td>
                            <input class=""markrules"" onkeyup=""doEval()"" type=""text"" id=""pick34"" name=""pick34"" maxlength=""2"" />
                        </td>
                        <td>
                            <input class=""markrules"" onkeyup=""doEval()""");
            WriteLiteral(@" type=""text"" id=""pick35"" name=""pick35"" maxlength=""2"" />
                        </td>
                        <td>
                            <input class=""markrules"" onkeyup=""doEval()"" type=""text"" id=""pick3P"" name=""pick3P"" maxlength=""2"" />
                        </td>
                        <td>
                            <span id=""result3"" name=""result3""></span>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <input class=""markrules"" onkeyup=""doEval()"" type=""text"" id=""pick41"" name=""pick41"" maxlength=""2"" />
                        </td>
                        <td>
                            <input class=""markrules"" onkeyup=""doEval()"" type=""text"" id=""pick42"" name=""pick42"" maxlength=""2"" />
                        </td>
                        <td>
                            <input class=""markrules"" onkeyup=""doEval()"" type=""text"" id=""pick43"" name=""pick43"" maxlength=""2"" />
                        </");
            WriteLiteral(@"td>
                        <td>
                            <input class=""markrules"" onkeyup=""doEval()"" type=""text"" id=""pick44"" name=""pick44"" maxlength=""2"" />
                        </td>
                        <td>
                            <input class=""markrules"" onkeyup=""doEval()"" type=""text"" id=""pick45"" name=""pick45"" maxlength=""2"" />
                        </td>
                        <td>
                            <input class=""markrules"" onkeyup=""doEval()"" type=""text"" id=""pick4P"" name=""pick4P"" maxlength=""2"" />
                        </td>
                        <td>
                            <span id=""result4"" name=""result4""></span>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <input class=""markrules"" onkeyup=""doEval()"" type=""text"" id=""pick51"" name=""pick51"" maxlength=""2"" />
                        </td>
                        <td>
                            <input class=""markru");
            WriteLiteral(@"les"" onkeyup=""doEval()"" type=""text"" id=""pick52"" name=""pick52"" maxlength=""2"" />
                        </td>
                        <td>
                            <input class=""markrules"" onkeyup=""doEval()"" type=""text"" id=""pick53"" name=""pick53"" maxlength=""2"" />
                        </td>
                        <td>
                            <input class=""markrules"" onkeyup=""doEval()"" type=""text"" id=""pick54"" name=""pick54"" maxlength=""2"" />
                        </td>
                        <td>
                            <input class=""markrules"" onkeyup=""doEval()"" type=""text"" id=""pick55"" name=""pick55"" maxlength=""2"" />
                        </td>
                        <td>
                            <input class=""markrules"" onkeyup=""doEval()"" type=""text"" id=""pick5P"" name=""pick5P"" maxlength=""2"" />
                        </td>
                        <td>
                            <span id=""result5"" name=""result5""></span>
                        </td>
                    </tr>");
            WriteLiteral(@"
                </tbody>
            </table>
        </div>
    </div>
    <div class='row'>
        <div class='col-md-6'>
            <h2 class='align-center'>Powerball information</h2>
            <table class='table table-hover'>
                <thead class=""thead-dark"">
                    <tr>
                        <th>Matches</th>
                        <th>Prize</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>5 of 5 + POWERBALL</td><td>JACKPOT</td>
                    </tr>
                    <tr>
                        <td>5 of 5</td><td>$1,000,000</td>
                    </tr>
                    <tr>
                        <td>4 of 5 + POWERBALL</td><td>$50,000</td>
                    </tr>
                    <tr>
                        <td>4 of 5</td><td>$100</td>
                    </tr>
                    <tr>
                        <td>3 of 5 + POWERBALL</td><td>$100");
            WriteLiteral(@"</td>
                    </tr>
                    <tr>
                        <td>3 of 5</td><td>$7</td>
                    </tr>
                    <tr>
                        <td>2 of 5 + POWERBALL</td><td>$7</td>
                    </tr>
                    <tr>
                        <td>1 of 5 + POWERBALL</td><td>$4</td>
                    </tr>
                    <tr>
                        <td>0 of 5 + POWERBALL</td><td>$4</td>
                    </tr>

                </tbody>
            </table>
        </div>
        <div class='col-md-6'>
            <h2 class='align-center'>Megamillions information</h2>
            <table class='table table-hover'>
                <thead class=""thead-dark"">
                    <tr>
                        <th>Matches</th>
                        <th>Prize</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>5 of 5 + MEGABALL</td><td>JACKPOT</td");
            WriteLiteral(@">
                    </tr>
                    <tr>
                        <td>5 of 5</td><td>$1,000,000</td>
                    </tr>
                    <tr>
                        <td>4 of 5 + MEGABALL</td><td>$10,000</td>
                    </tr>
                    <tr>
                        <td>4 of 5</td><td>$500</td>
                    </tr>
                    <tr>
                        <td>3 of 5 + MEGABALL</td><td>$200</td>
                    </tr>
                    <tr>
                        <td>3 of 5</td><td>$10</td>
                    </tr>
                    <tr>
                        <td>2 of 5 + MEGABALL</td><td>$10</td>
                    </tr>
                    <tr>
                        <td>1 of 5 + MEGABALL</td><td>$4</td>
                    </tr>
                    <tr>
                        <td>0 of 5 + MEGABALL</td><td>$2</td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
    ");
            WriteLiteral("</div>\r\n");
            WriteLiteral(@"<script>

    function clearWinners() {
        $(""#win1"").val('');
        $(""#win2"").val('');
        $(""#win3"").val('');
        $(""#win4"").val('');
        $(""#win5"").val('');
        $(""#winPB"").val('');  
    }

    function doEval() {
        var win1 = $(""#win1"").val();
        var win2 = $(""#win2"").val();
        var win3 = $(""#win3"").val();
        var win4 = $(""#win4"").val();
        var win5 = $(""#win5"").val();
        var winPB = $(""#winPB"").val();

        var winners = [win1, win2, win3, win4, win5];

        evalElement($(""#pick11""), winners);
        evalElement($(""#pick12""), winners);
        evalElement($(""#pick13""), winners);
        evalElement($(""#pick14""), winners);
        evalElement($(""#pick15""), winners);
        evalPB($(""#pick1P""), winPB);

        evalElement($(""#pick21""), winners);
        evalElement($(""#pick22""), winners);
        evalElement($(""#pick23""), winners);
        evalElement($(""#pick24""), winners);
        evalElement($(""#pick25""), wi");
            WriteLiteral(@"nners);
        evalPB($(""#pick2P""), winPB);

        evalElement($(""#pick31""), winners);
        evalElement($(""#pick32""), winners);
        evalElement($(""#pick33""), winners);
        evalElement($(""#pick34""), winners);
        evalElement($(""#pick35""), winners);
        evalPB($(""#pick3P""), winPB);

        evalElement($(""#pick41""), winners);
        evalElement($(""#pick42""), winners);
        evalElement($(""#pick43""), winners);
        evalElement($(""#pick44""), winners);
        evalElement($(""#pick45""), winners);
        evalPB($(""#pick4P""), winPB);

        evalElement($(""#pick51""), winners);
        evalElement($(""#pick52""), winners);
        evalElement($(""#pick53""), winners);
        evalElement($(""#pick54""), winners);
        evalElement($(""#pick55""), winners);
        evalPB($(""#pick5P""), winPB);

        setResults($(""#pick11""), $(""#pick12""), $(""#pick13""), $(""#pick14""), $(""#pick15""), $(""#pick1P""), $(""#result1""));
        setResults($(""#pick21""), $(""#pick22""), $(""#pick23""),");
            WriteLiteral(@" $(""#pick24""), $(""#pick25""), $(""#pick2P""), $(""#result2""));
        setResults($(""#pick31""), $(""#pick32""), $(""#pick33""), $(""#pick34""), $(""#pick35""), $(""#pick3P""), $(""#result3""));
        setResults($(""#pick41""), $(""#pick42""), $(""#pick43""), $(""#pick44""), $(""#pick45""), $(""#pick4P""), $(""#result4""));
        setResults($(""#pick51""), $(""#pick52""), $(""#pick53""), $(""#pick54""), $(""#pick55""), $(""#pick5P""), $(""#result5""));

    };

    function evalElement(e, winners) {
        console.log('eval element of ' + e.attr('id') + ' = ' + e.val());
        if (winners.includes(e.val()))
            e.css(""background-color"", ""green"");
        else
            e.css(""background-color"", ""white"");
    };

    function evalPB(e, pb) {
        console.log('eval element of ' + e.attr('id') + ' = ' + e.val());
        if (e.val()===pb)
            e.css(""background-color"", ""green"");
        else
            e.css(""background-color"", ""white"");
    };

    function setResults(a, b, c, d, e, p, result) {
        ");
            WriteLiteral(@"var count = 0;
        var labelText = '';
        var pbText = '';
        if (a.css('background-color') === 'rgb(0, 128, 0)') {
            count++;
        }
        if (b.css('background-color') === 'rgb(0, 128, 0)') {
            count++;
        }
        if (c.css('background-color') === 'rgb(0, 128, 0)') {
            count++;
        }
        if (d.css('background-color') === 'rgb(0, 128, 0)') {
            count++;
        }
        if (e.css('background-color') === 'rgb(0, 128, 0)') {
            count++;
        }
        if (p.css('background-color') === 'rgb(0, 128, 0)') {
            pbText = ' + POWERBALL';
        }

        labelText = count + ' of 5' + pbText;
        result.text(labelText);
    };



</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
