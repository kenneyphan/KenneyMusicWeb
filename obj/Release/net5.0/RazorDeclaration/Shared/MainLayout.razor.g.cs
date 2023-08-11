// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
