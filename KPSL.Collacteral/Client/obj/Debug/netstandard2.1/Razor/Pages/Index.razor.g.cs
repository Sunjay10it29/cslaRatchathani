#pragma checksum "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7713f2d4360c91ff3a19c4f771264f204f2feb8f"
// <auto-generated/>
#pragma warning disable 1591
namespace KPSL.Collacteral.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/_Imports.razor"
using KPSL.Collacteral.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/_Imports.razor"
using KPSL.Collacteral.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/Index.razor"
using Csla.Rules;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/Index.razor"
using Csla.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/Index.razor"
using KPSL.Collacteral.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\r\n  ");
            __builder.OpenElement(3, "div");
            __builder.AddContent(4, "Username: ");
            __builder.AddContent(5, 
#nullable restore
#line 10 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/Index.razor"
                  Csla.ApplicationContext.User.Identity.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n  ");
            __builder.OpenElement(7, "div");
            __builder.AddContent(8, "IsAuthenticated: ");
            __builder.AddContent(9, 
#nullable restore
#line 11 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/Index.razor"
                         Csla.ApplicationContext.User.Identity.IsAuthenticated

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n");
            __builder.OpenElement(12, "div");
            __builder.AddContent(13, "(");
            __builder.AddContent(14, 
#nullable restore
#line 14 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/Index.razor"
       Csla.ApplicationContext.User.GetType().FullName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(15, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.OpenElement(17, "div");
            __builder.AddContent(18, "(");
            __builder.AddContent(19, 
#nullable restore
#line 15 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/Index.razor"
       Csla.ApplicationContext.User.Identity.GetType().FullName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(20, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.OpenElement(22, "p");
            __builder.AddMarkupContent(23, "\r\n  ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(24);
            __builder.AddAttribute(25, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(26, "\r\n      User authorized\r\n      ");
                __builder2.OpenElement(27, "div");
                __builder2.AddContent(28, "in role personcreator: ");
                __builder2.AddContent(29, 
#nullable restore
#line 20 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/Index.razor"
                                   Csla.ApplicationContext.User.IsInRole("admin")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n    ");
            }
            ));
            __builder.AddAttribute(31, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(32, "\r\n      User NOT authorized\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\r\n");
            __builder.OpenElement(35, "p");
            __builder.AddMarkupContent(36, "\r\n  ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(37);
            __builder.AddAttribute(38, "Policy", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "/Users/sunny-dev/cslaRatchathani/KPSL.Collacteral/Client/Pages/Index.razor"
                           CslaPolicy.GetPolicy(AuthorizationActions.CreateObject, typeof(PersonEdit))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(40, "\r\n      User can create a person object\r\n    ");
            }
            ));
            __builder.AddAttribute(41, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(42, "\r\n      User can NOT create a person object\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(43, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
