#pragma checksum "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\Pages\EDITCITY.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4fb7a9960284a06d60c4dad5f9683b785112ba3"
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
#line 2 "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\Pages\EDITCITY.razor"
using BlazorDB.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\Pages\EDITCITY.razor"
using BlazorDB.Data.INTERFACES;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editcity/{id:int}")]
    public partial class EDITCITY : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>MODIFICATION</h3>\r\n<hr>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\Pages\EDITCITY.razor"
 if (city == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p>Loadind...</p>\r\n");
#nullable restore
#line 13 "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\Pages\EDITCITY.razor"
}
else
{




#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "form");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-md-8");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "form-group");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.AddMarkupContent(14, "<label for=\"Name\" class=\"custom-control-label\">Name</label>\r\n                ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "form", "Name");
            __builder.AddAttribute(17, "class", "form-control");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\Pages\EDITCITY.razor"
                                                                city.name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => city.name = __value, city.name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.AddMarkupContent(21, "<label for=\"Name\" class=\"custom-control-label\">Name</label>\r\n                ");
            __builder.OpenElement(22, "input");
            __builder.AddAttribute(23, "form", "Name");
            __builder.AddAttribute(24, "class", "form-control");
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\Pages\EDITCITY.razor"
                                                                city.state

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => city.state = __value, city.state));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "row");
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "form-group");
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "type", "button");
            __builder.AddAttribute(39, "class", "btn btn-primary");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\Pages\EDITCITY.razor"
                                                                    UpdateCity

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "value", "Modifier");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
#nullable restore
#line 36 "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\Pages\EDITCITY.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\EXAUCE\source\repos\BLAZORDAPP\BlazorDB\BlazorDB\Pages\EDITCITY.razor"
       
    [Parameter]
    public int id { get; set; }
    City city = new City();
    protected override async Task OnInitializedAsync()
    {
        city = await CityService.SingleCity(id);
    }
    protected async Task UpdateCity()
    {
        await CityService.EditCity(id, city);
        NavigationManager.NavigateTo("listcities");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICITYSERVICES CityService { get; set; }
    }
}
#pragma warning restore 1591