#pragma checksum "C:\Users\Henriques Sylvio\source\repos\JeuDeDame\JeuDeDame\Client\Checkerboard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44b9407f1c68fa0f27ae5fdbc85806c24cd63827"
// <auto-generated/>
#pragma warning disable 1591
namespace JeuDeDame.Client
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Henriques Sylvio\source\repos\JeuDeDame\JeuDeDame\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Henriques Sylvio\source\repos\JeuDeDame\JeuDeDame\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Henriques Sylvio\source\repos\JeuDeDame\JeuDeDame\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Henriques Sylvio\source\repos\JeuDeDame\JeuDeDame\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Henriques Sylvio\source\repos\JeuDeDame\JeuDeDame\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Henriques Sylvio\source\repos\JeuDeDame\JeuDeDame\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Henriques Sylvio\source\repos\JeuDeDame\JeuDeDame\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Henriques Sylvio\source\repos\JeuDeDame\JeuDeDame\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Henriques Sylvio\source\repos\JeuDeDame\JeuDeDame\Client\_Imports.razor"
using JeuDeDame.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Henriques Sylvio\source\repos\JeuDeDame\JeuDeDame\Client\_Imports.razor"
using JeuDeDame.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class Checkerboard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\Henriques Sylvio\source\repos\JeuDeDame\JeuDeDame\Client\Checkerboard.razor"
 for (int i = 0; i < 8; i++)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
#nullable restore
#line 4 "C:\Users\Henriques Sylvio\source\repos\JeuDeDame\JeuDeDame\Client\Checkerboard.razor"
     for (int j = 0; j < 8; j++)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<div class=\"cell\"></div>");
#nullable restore
#line 7 "C:\Users\Henriques Sylvio\source\repos\JeuDeDame\JeuDeDame\Client\Checkerboard.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 9 "C:\Users\Henriques Sylvio\source\repos\JeuDeDame\JeuDeDame\Client\Checkerboard.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591