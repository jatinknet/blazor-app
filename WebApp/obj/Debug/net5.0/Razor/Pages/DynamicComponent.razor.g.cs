#pragma checksum "E:\Jatin work\WebApp\WebApp\Pages\DynamicComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "498b67d4a4c6bc875dcce6bd5854a6e1b7915aec"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Jatin work\WebApp\WebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Jatin work\WebApp\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Jatin work\WebApp\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Jatin work\WebApp\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Jatin work\WebApp\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Jatin work\WebApp\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Jatin work\WebApp\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Jatin work\WebApp\WebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Jatin work\WebApp\WebApp\_Imports.razor"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Jatin work\WebApp\WebApp\_Imports.razor"
using WebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Jatin work\WebApp\WebApp\_Imports.razor"
using eShop.UseCases.SearchProductScreen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\Jatin work\WebApp\WebApp\_Imports.razor"
using eShop.CoreBusiness.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\Jatin work\WebApp\WebApp\_Imports.razor"
using WebApp.Controls;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/dynamic")]
    public partial class DynamicComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>This is my first dynamic data...</h3>\r\n<br>\r\n<br>\r\n\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "E:\Jatin work\WebApp\WebApp\Pages\DynamicComponent.razor"
                  HandleBlazorServerClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(3, "Blazor Server");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "E:\Jatin work\WebApp\WebApp\Pages\DynamicComponent.razor"
                   HandleBlazorWebAssemblyClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(7, "Blazor WebAssembly");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n<br>\r\n<br>\r\n");
            __builder.OpenElement(9, "h3");
            __builder.AddContent(10, 
#nullable restore
#line 11 "E:\Jatin work\WebApp\WebApp\Pages\DynamicComponent.razor"
     title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.OpenElement(12, "h3");
            __builder.AddContent(13, 
#nullable restore
#line 12 "E:\Jatin work\WebApp\WebApp\Pages\DynamicComponent.razor"
     content

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "E:\Jatin work\WebApp\WebApp\Pages\DynamicComponent.razor"
       

    private string title;
    private string content;


    private void HandleBlazorServerClick()
    {
        title = "Balzor Server Click";
        content = "THis is Blazor Server button click event...";

    }

    private void HandleBlazorWebAssemblyClick()
    {
        title = "Balzor Web Assembly Click";
        content = "THis is Blazor Web Assembly button click event...";

    }





#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
