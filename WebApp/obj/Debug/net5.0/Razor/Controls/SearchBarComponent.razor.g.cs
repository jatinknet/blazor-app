#pragma checksum "E:\Jatin work\WebApp\WebApp\Controls\SearchBarComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "254286e18e6c9197e6f72a09e8e41cdd2b45b97e"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp.Controls
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
    public partial class SearchBarComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "form");
            __builder.AddAttribute(1, "class", "form-inline");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "form-group mx-sm-3 mb-2");
            __builder.AddMarkupContent(4, "<label for=\"filter\" class=\"visually-hidden\">Search: &nbsp;</label>\r\n        ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "class", "form-control");
            __builder.AddAttribute(7, "id", "filter");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "E:\Jatin work\WebApp\WebApp\Controls\SearchBarComponent.razor"
                                                                         filter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => filter = __value, filter));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-auto");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "E:\Jatin work\WebApp\WebApp\Controls\SearchBarComponent.razor"
                           HandleSearch

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "type", "button");
            __builder.AddAttribute(17, "class", "btn btn-primary mb-3");
            __builder.AddContent(18, "Search");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "E:\Jatin work\WebApp\WebApp\Controls\SearchBarComponent.razor"
       


    private string filter;
    [Parameter]
    public EventCallback<string> OnSearch { get; set; }

    private void HandleSearch()
        {

        OnSearch.InvokeAsync(filter);

        }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
