#pragma checksum "D:\DATA\IT\Allegiance Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\Pages\Messages.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "868e1819d041c4ce79f145d6fb4c25dce86bbcdf"
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
#line 1 "D:\DATA\IT\Allegiance Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DATA\IT\Allegiance Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DATA\IT\Allegiance Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DATA\IT\Allegiance Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DATA\IT\Allegiance Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DATA\IT\Allegiance Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DATA\IT\Allegiance Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\DATA\IT\Allegiance Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\_Imports.razor"
using BlazorSignalRApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\DATA\IT\Allegiance Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\_Imports.razor"
using BlazorSignalRApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DATA\IT\Allegiance Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\Pages\Messages.razor"
using Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DATA\IT\Allegiance Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\Pages\Messages.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Messages/{userInput}")]
    public partial class Messages : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Second Page</h2>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "You are ");
            __builder.AddContent(3, 
#nullable restore
#line 8 "D:\DATA\IT\Allegiance Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\Pages\Messages.razor"
            userInput

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " years old.");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "label");
            __builder.AddMarkupContent(10, "\r\n        Message:\r\n        ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "size", "50");
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "D:\DATA\IT\Allegiance Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\Pages\Messages.razor"
                      messageInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => messageInput = __value, messageInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "D:\DATA\IT\Allegiance Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\Pages\Messages.razor"
                  Send

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "disabled", 
#nullable restore
#line 16 "D:\DATA\IT\Allegiance Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\Pages\Messages.razor"
                                    !IsConnected

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(21, "Send");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n<hr>\r\n\r\n");
            __builder.OpenElement(23, "ul");
            __builder.AddAttribute(24, "id", "messagesList");
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 20 "D:\DATA\IT\Allegiance Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\Pages\Messages.razor"
     foreach (var message in messages)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "        ");
            __builder.OpenElement(27, "li");
            __builder.AddContent(28, 
#nullable restore
#line 22 "D:\DATA\IT\Allegiance Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\Pages\Messages.razor"
             message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 23 "D:\DATA\IT\Allegiance Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\Pages\Messages.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "D:\DATA\IT\Allegiance Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\Pages\Messages.razor"
       
    [Parameter]
    public string userInput { get; set; }

    private HubConnection hubConnection;
    private List<string> messages = new List<string>();
    string clear = "";
    private string NameInput;
    private string SNameInput;
    private string messageInput;


    protected override async Task OnInitializedAsync()
    {
        hubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/chathub"))
            .Build();

        hubConnection.On<string, string>("ReceiveMessage", (user, message) =>
        {
            messageInput = "";
            var encodedMsg = $"{user}: {message}";
            messages.Add(encodedMsg);
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