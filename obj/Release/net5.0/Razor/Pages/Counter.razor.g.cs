#pragma checksum "/Users/kenney/Projects/KenneyMusicWeb/KenneyMusicWeb/Pages/Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "022956f2ee5f9a0edf816095f5cee71b16747764"
// <auto-generated/>
#pragma warning disable 1591
namespace KenneyMusicWeb.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/kenney/Projects/KenneyMusicWeb/KenneyMusicWeb/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/kenney/Projects/KenneyMusicWeb/KenneyMusicWeb/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/kenney/Projects/KenneyMusicWeb/KenneyMusicWeb/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/kenney/Projects/KenneyMusicWeb/KenneyMusicWeb/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/kenney/Projects/KenneyMusicWeb/KenneyMusicWeb/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/kenney/Projects/KenneyMusicWeb/KenneyMusicWeb/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/kenney/Projects/KenneyMusicWeb/KenneyMusicWeb/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/kenney/Projects/KenneyMusicWeb/KenneyMusicWeb/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/kenney/Projects/KenneyMusicWeb/KenneyMusicWeb/_Imports.razor"
using KenneyMusicWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/kenney/Projects/KenneyMusicWeb/KenneyMusicWeb/_Imports.razor"
using KenneyMusicWeb.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\n\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 5 "/Users/kenney/Projects/KenneyMusicWeb/KenneyMusicWeb/Pages/Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\n\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "/Users/kenney/Projects/KenneyMusicWeb/KenneyMusicWeb/Pages/Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "/Users/kenney/Projects/KenneyMusicWeb/KenneyMusicWeb/Pages/Counter.razor"
       
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
