#pragma checksum "C:\Users\Henriques Sylvio\source\repos\JeuDeDame\JeuDeDame\Client\Checkerboard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c304c12078c73e99d4c9d0c790bf7ac2b3e885b"
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
#nullable restore
#line 55 "C:\Users\Henriques Sylvio\source\repos\JeuDeDame\JeuDeDame\Client\Checkerboard.razor"
 for (int i = 0; i < 8; i++)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
#nullable restore
#line 58 "C:\Users\Henriques Sylvio\source\repos\JeuDeDame\JeuDeDame\Client\Checkerboard.razor"
     for (int j = 0; j < 8; j++)
    {
        var checker = blackCheckers.FirstOrDefault(n => n.Column == j && n.Row == i);
        if (checker == null)
        {
            checker = whiteCheckers.FirstOrDefault(n => n.Column == j && n.Row == i);
        }

        bool canMoveHere = rowsPossible.Contains(i) && columnsPossible.Contains(j);


#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "cell" + " " + (
#nullable restore
#line 68 "C:\Users\Henriques Sylvio\source\repos\JeuDeDame\JeuDeDame\Client\Checkerboard.razor"
                           canMoveHere ? "active" : ""

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 69 "C:\Users\Henriques Sylvio\source\repos\JeuDeDame\JeuDeDame\Client\Checkerboard.razor"
             if (checker != null)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 71 "C:\Users\Henriques Sylvio\source\repos\JeuDeDame\JeuDeDame\Client\Checkerboard.razor"
                               () => { activeChecker = checker; EvaluateCheckerSpots(); }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "class", "checker" + " " + (
#nullable restore
#line 72 "C:\Users\Henriques Sylvio\source\repos\JeuDeDame\JeuDeDame\Client\Checkerboard.razor"
                                     checker.Color

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 72 "C:\Users\Henriques Sylvio\source\repos\JeuDeDame\JeuDeDame\Client\Checkerboard.razor"
                                                     checker == activeChecker ? "active" : ""

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 73 "C:\Users\Henriques Sylvio\source\repos\JeuDeDame\JeuDeDame\Client\Checkerboard.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 75 "C:\Users\Henriques Sylvio\source\repos\JeuDeDame\JeuDeDame\Client\Checkerboard.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 77 "C:\Users\Henriques Sylvio\source\repos\JeuDeDame\JeuDeDame\Client\Checkerboard.razor"
}

#line default
#line hidden
#nullable disable
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

        for (int i = 5; i < 8; i++)
        {
            for (int j = (i + 1) % 2; j < 8; j += 2)
            {
                blackCheckers.Add(new Checker
                {
                    Color = "white",
                    Column = j,
                    Row = i,
                    Direction = CheckerDirection.Up
                });
            }
        }
    }

    Checker activeChecker = null;
    List<int> rowsPossible = new List<int>();
    List<int> columnsPossible = new List<int>();
    void EvaluateCheckerSpots()
    {
        rowsPossible.Clear();
        columnsPossible.Clear();
        if (activeChecker != null)
        {
            rowsPossible.Add(activeChecker.Row +
                (1 * (activeChecker.Direction == CheckerDirection.Down ? 1 : -1)));

            columnsPossible.Add(activeChecker.Column - 1);
            columnsPossible.Add(activeChecker.Column + 1);
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
