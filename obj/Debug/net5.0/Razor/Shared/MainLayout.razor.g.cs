#pragma checksum "/Users/kenney/Projects/KenneyMusicWeb/KenneyMusicWeb/Shared/MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61f8582abbccf527a1dd5078836ecce17737fdcb"
// <auto-generated/>
#pragma warning disable 1591
namespace KenneyMusicWeb.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-kt0u5729jp");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "main");
            __builder.AddAttribute(5, "b-kt0u5729jp");
            __builder.AddMarkupContent(6, "<img src=\"/images/erebus-knight-chii.jpg\" class=\"banner\" id=\"banner\" b-kt0u5729jp>\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "px-4 navigation");
            __builder.AddAttribute(9, "id", "navigation");
            __builder.AddAttribute(10, "b-kt0u5729jp");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(11);
            __builder.AddAttribute(12, "href", "/");
            __builder.AddAttribute(13, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 13 "/Users/kenney/Projects/KenneyMusicWeb/KenneyMusicWeb/Shared/MainLayout.razor"
                                    NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "class", "px-3 nav-item");
            __builder.AddAttribute(15, "id", "nav-item");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "/Users/kenney/Projects/KenneyMusicWeb/KenneyMusicWeb/Shared/MainLayout.razor"
                                                                                                   Collapse

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(18, "HOME");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "href", "music");
            __builder.AddAttribute(22, "class", "px-3 nav-item");
            __builder.AddAttribute(23, "id", "nav-item");
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(25, "MUSIC");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(27);
            __builder.AddAttribute(28, "href", "contact");
            __builder.AddAttribute(29, "class", "px-3 nav-item");
            __builder.AddAttribute(30, "id", "nav-item");
            __builder.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(32, "CONTACT");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n\n        ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "body-container");
            __builder.AddAttribute(36, "id", "body-container");
            __builder.AddAttribute(37, "b-kt0u5729jp");
            __builder.AddContent(38, 
#nullable restore
#line 19 "/Users/kenney/Projects/KenneyMusicWeb/KenneyMusicWeb/Shared/MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n\n");
            __builder.AddMarkupContent(40, @"<style b-kt0u5729jp>
    .nav-item {
        color: white;
        font-family: fantasy;
        letter-spacing: 1px;
        color: #fff;
    }

        .nav-item.active {
        }

    .navigation a:hover {
        color: rgba(255,255,255,.4);
        text-decoration: none;
    }

    .navigation a:focus {
        color: white;
        text-decoration: none;
    }

    body {
        height: 100%;
        margin: 0;
        padding: 0;
        background-color: aliceblue !important;
    }

    @media only screen and (min-width: 1920px) and (min-height: 1080px) {
        .nav-item {
            font-size: 16px;
        }

        .main .body-container.sticky {
            margin-top: 410px;
        }
    }

    @media only screen and (min-width: 1440px) and (max-width: 1679px) {
        .main .body-container.sticky {
            margin-top: 350px;
        }
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "/Users/kenney/Projects/KenneyMusicWeb/KenneyMusicWeb/Shared/MainLayout.razor"
       
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        try
        {
            string pageName = NavigationManager.ToBaseRelativePath(NavigationManager.Uri);

            if (pageName.Equals("music"))
            {
                await JS.InvokeVoidAsync("musicSticky");
            }
            else
            {
                await JS.InvokeVoidAsync("navBarSticky");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public async void Collapse()
    {
        try
        {
            await JS.InvokeVoidAsync("collapse");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
#pragma warning restore 1591
