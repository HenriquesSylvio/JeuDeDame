// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 1 "C:\Users\Henriques Sylvio\source\repos\JeuDeDame\JeuDeDame\Client\Checkerboard.razor"
using JeuDeDame.Client.Data;

#line default
#line hidden
#nullable disable
    public partial class Checkerboard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 2 "C:\Users\Henriques Sylvio\source\repos\JeuDeDame\JeuDeDame\Client\Checkerboard.razor"
       
    List<Checker> blackCheckers = new List<Checker>();
    List<Checker> whiteCheckers = new List<Checker>();

    protected override void OnInitialized()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = (i + 1) % 2; j < 8; j += 2)
            {
                blackCheckers.Add(new Checker
                {
                    Color = "black",
                    Column = j,
                    Row = i,
                    Direction = CheckerDirection.Down
                });
            }
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
