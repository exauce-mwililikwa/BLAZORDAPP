#pragma checksum "C:\Users\EXAUCE\source\repos\BlazorDB\BlazorDB\Pages\LISTECITIES.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87ee7f5038a8b069d452b2603914c4735fb2abf4"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorDB.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\EXAUCE\source\repos\BlazorDB\BlazorDB\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\EXAUCE\source\repos\BlazorDB\BlazorDB\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\EXAUCE\source\repos\BlazorDB\BlazorDB\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\EXAUCE\source\repos\BlazorDB\BlazorDB\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\EXAUCE\source\repos\BlazorDB\BlazorDB\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\EXAUCE\source\repos\BlazorDB\BlazorDB\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\EXAUCE\source\repos\BlazorDB\BlazorDB\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\EXAUCE\source\repos\BlazorDB\BlazorDB\_Imports.razor"
using BlazorDB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\EXAUCE\source\repos\BlazorDB\BlazorDB\_Imports.razor"
using BlazorDB.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\EXAUCE\source\repos\BlazorDB\BlazorDB\Pages\LISTECITIES.razor"
using BlazorDB.Data.INTERFACES;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\EXAUCE\source\repos\BlazorDB\BlazorDB\Pages\LISTECITIES.razor"
using BlazorDB.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\EXAUCE\source\repos\BlazorDB\BlazorDB\Pages\LISTECITIES.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\EXAUCE\source\repos\BlazorDB\BlazorDB\Pages\LISTECITIES.razor"
       
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