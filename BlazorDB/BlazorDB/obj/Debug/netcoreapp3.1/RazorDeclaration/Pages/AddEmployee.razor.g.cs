#pragma checksum "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\Pages\AddEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "029207abf3de1b4ac07580f806d500645f3a4f3f"
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
#line 1 "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\Pages\AddEmployee.razor"
using BlazorDB.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\Pages\AddEmployee.razor"
using BlazorDB.Data.INTERFACES;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/enregistrer_employee")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/enregistrer_employees")]
    public partial class AddEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\Pages\AddEmployee.razor"
       
    Employee employee = new Employee();
    IEnumerable<City> cities = new List<City>();
    protected override async Task OnInitializedAsync()
    {
        cities = await cityservice.GetCities();
    }
    protected async Task Enregistrer()
    {
        await empservice.CreateEmployee(employee);
        NavigationManager.NavigateTo("liste_des_employees");
    }
    void cancel()
    {

        NavigationManager.NavigateTo("liste_des_employees");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICITYSERVICES cityservice { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEMPOYEESERVICE empservice { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
