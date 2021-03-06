#pragma checksum "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\Pages\LISTECITIES.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d0c6c809c385d30432960560a23c3aaa2736ddb"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDB.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\_Imports.razor"
using BlazorDB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\_Imports.razor"
using BlazorDB.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\Pages\LISTECITIES.razor"
using BlazorDB.Data.INTERFACES;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\Pages\LISTECITIES.razor"
using BlazorDB.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\Pages\LISTECITIES.razor"
using BlazorDB.Data.SERVICES;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listcities")]
    public partial class LISTECITIES : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>List des Villes</h2>\r\n");
            __builder.AddMarkupContent(1, "<a href=\"/addcities\">Ajouter une ville</a>\r\n");
#nullable restore
#line 9 "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\Pages\LISTECITIES.razor"
 if (cities == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p>loading...</p>\r\n");
#nullable restore
#line 12 "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\Pages\LISTECITIES.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table table-striped table-bordered table-hover table-borderless");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th>Name</th>\r\n                <th>State</th>\r\n                <th>Params</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 24 "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\Pages\LISTECITIES.razor"
             foreach (var city in cities)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 27 "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\Pages\LISTECITIES.razor"
                         city.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 28 "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\Pages\LISTECITIES.razor"
                         city.state

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.OpenElement(22, "a");
            __builder.AddAttribute(23, "class", "btn btn-info");
            __builder.AddAttribute(24, "href", "/editcity/" + (
#nullable restore
#line 30 "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\Pages\LISTECITIES.razor"
                                                                 city.id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "class", "btn btn-danger");
            __builder.AddAttribute(29, "href", "/suppression_de_la_ville/" + (
#nullable restore
#line 31 "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\Pages\LISTECITIES.razor"
                                                                                  city.id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(30, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 34 "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\Pages\LISTECITIES.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 38 "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\Pages\LISTECITIES.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\Pages\LISTECITIES.razor"
       
    IEnumerable<City> cities;
    protected override async Task OnInitializedAsync()
    {
        cities = await CityService.GetCities();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICITYSERVICES CityService { get; set; }
    }
}
#pragma warning restore 1591
