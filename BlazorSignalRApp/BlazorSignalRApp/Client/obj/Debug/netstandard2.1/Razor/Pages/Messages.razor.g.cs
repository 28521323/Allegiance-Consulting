#pragma checksum "d:\DATA\IT\Allegiance Consulting\Allegiance-Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\Pages\Messages.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d00fa6dcbd3dc8b1cebe31b22376a4be65a5315"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorSignalRApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "d:\DATA\IT\Allegiance Consulting\Allegiance-Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\DATA\IT\Allegiance Consulting\Allegiance-Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "d:\DATA\IT\Allegiance Consulting\Allegiance-Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "d:\DATA\IT\Allegiance Consulting\Allegiance-Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "d:\DATA\IT\Allegiance Consulting\Allegiance-Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "d:\DATA\IT\Allegiance Consulting\Allegiance-Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "d:\DATA\IT\Allegiance Consulting\Allegiance-Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "d:\DATA\IT\Allegiance Consulting\Allegiance-Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\_Imports.razor"
using BlazorSignalRApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "d:\DATA\IT\Allegiance Consulting\Allegiance-Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\_Imports.razor"
using BlazorSignalRApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\DATA\IT\Allegiance Consulting\Allegiance-Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\Pages\Messages.razor"
using Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "d:\DATA\IT\Allegiance Consulting\Allegiance-Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\Pages\Messages.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/chat/{userInput}")]
    public partial class Messages : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "ul");
            __builder.AddAttribute(1, "id", "messagesList");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 9 "d:\DATA\IT\Allegiance Consulting\Allegiance-Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\Pages\Messages.razor"
     foreach (var message in messages)
    {
        if (nameReceive == NameInput)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "            ");
            __builder.OpenElement(4, "li");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "style", "text-align: left");
            __builder.AddContent(7, " ");
            __builder.AddContent(8, 
#nullable restore
#line 13 "d:\DATA\IT\Allegiance Consulting\Allegiance-Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\Pages\Messages.razor"
                                                message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 14 "d:\DATA\IT\Allegiance Consulting\Allegiance-Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\Pages\Messages.razor"
        }
        if (nameReceive != NameInput)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "            ");
            __builder.OpenElement(11, "li");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "style", "text-align: center");
            __builder.AddContent(14, " ");
            __builder.AddContent(15, 
#nullable restore
#line 17 "d:\DATA\IT\Allegiance Consulting\Allegiance-Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\Pages\Messages.razor"
                                                  message

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(16, " ");
            __builder.AddContent(17, 
#nullable restore
#line 17 "d:\DATA\IT\Allegiance Consulting\Allegiance-Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\Pages\Messages.razor"
                                                           DateTime.Now

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 18 "d:\DATA\IT\Allegiance Consulting\Allegiance-Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\Pages\Messages.razor"
        }


    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "fixed-bottom form-group");
            __builder.AddAttribute(22, "style", "text-align: center");
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.OpenElement(24, "label");
            __builder.AddMarkupContent(25, "\r\n        Message:\r\n        ");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "size", "50");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "d:\DATA\IT\Allegiance Consulting\Allegiance-Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\Pages\Messages.razor"
                      messageInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => messageInput = __value, messageInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                         \r\n        ");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "d:\DATA\IT\Allegiance Consulting\Allegiance-Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\Pages\Messages.razor"
                          Send

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "disabled", 
#nullable restore
#line 29 "d:\DATA\IT\Allegiance Consulting\Allegiance-Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\Pages\Messages.razor"
                                            !IsConnected

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(34, "Send");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n<hr>");
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "d:\DATA\IT\Allegiance Consulting\Allegiance-Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\Pages\Messages.razor"
       
    [Parameter]
    public string userInput { get; set; }

    private HubConnection hubConnection;
    private List<string> messages = new List<string>();
    string clear = "";
    private string NameInput;
    private string SNameInput;
    private string messageInput;
    private string nameReceive;


    protected override async Task OnInitializedAsync()
    {
        hubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/chathub"))
            .Build();

        hubConnection.On<string, string>("ReceiveMessage", (user, message) =>
        {
            messageInput = "";
            nameReceive = user;
            var encodedMsg = $"{user}: {message}";
            messages.Add(encodedMsg+ "                      ");
            StateHasChanged();

        });

        await hubConnection.StartAsync();
    }

    Task Send() =>
        hubConnection.SendAsync("SendMessage", userInput, messageInput);

    public bool IsConnected =>
        hubConnection.State == HubConnectionState.Connected;

    public void Dispose()
    {
        _ = hubConnection.DisposeAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
    }
}
#pragma warning restore 1591
