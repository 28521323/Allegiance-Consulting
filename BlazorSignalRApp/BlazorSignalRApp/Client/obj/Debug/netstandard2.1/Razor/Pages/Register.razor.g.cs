#pragma checksum "d:\DATA\IT\Allegiance Consulting\Allegiance-Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d217787aa7a3a979f7acb81cd9f9b1a268134985"
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
#line 2 "d:\DATA\IT\Allegiance Consulting\Allegiance-Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\Pages\Register.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "d:\DATA\IT\Allegiance Consulting\Allegiance-Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\Pages\Register.razor"
using Pages;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "label");
            __builder.AddMarkupContent(4, "\r\n        Name:\r\n        ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "d:\DATA\IT\Allegiance Consulting\Allegiance-Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\Pages\Register.razor"
                      NameInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NameInput = __value, NameInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n        Surname:\r\n        ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "d:\DATA\IT\Allegiance Consulting\Allegiance-Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\Pages\Register.razor"
                      SNameInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SNameInput = __value, SNameInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group");
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "label");
            __builder.AddMarkupContent(19, "\r\n        UserName:\r\n        ");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "d:\DATA\IT\Allegiance Consulting\Allegiance-Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\Pages\Register.razor"
                      userInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userInput = __value, userInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "d:\DATA\IT\Allegiance Consulting\Allegiance-Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\Pages\Register.razor"
                  Navigate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "disabled", 
#nullable restore
#line 24 "d:\DATA\IT\Allegiance Consulting\Allegiance-Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\Pages\Register.razor"
                                       !IsConnected

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(29, "Start<br> Chat ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n<hr>\r\n\r\n");
            __builder.OpenElement(31, "ul");
            __builder.AddAttribute(32, "id", "messagesList");
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 29 "d:\DATA\IT\Allegiance Consulting\Allegiance-Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\Pages\Register.razor"
     foreach (var message in messages)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "        ");
            __builder.OpenElement(35, "li");
            __builder.AddContent(36, 
#nullable restore
#line 31 "d:\DATA\IT\Allegiance Consulting\Allegiance-Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\Pages\Register.razor"
             message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 32 "d:\DATA\IT\Allegiance Consulting\Allegiance-Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\Pages\Register.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "d:\DATA\IT\Allegiance Consulting\Allegiance-Consulting\BlazorSignalRApp\BlazorSignalRApp\Client\Pages\Register.razor"
       
    private HubConnection hubConnection;
    private List<string> messages = new List<string>();
    public string userInput = "";
    private string NameInput = "";
    private string SNameInput = "";
    private string messageInput = "";
    void Navigate()
    {
        if (NameInput == "")
        {
            messages.Add("Please provide a Name");
        }
        if (userInput == "")
        {
            messages.Add("Please provide a Username");
        }
        if ((NameInput != "") && (userInput != ""))
            UriHelper.NavigateTo("/chat/" + userInput);
    }

    protected override async Task OnInitializedAsync()
    {
        hubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/chathub"))
            .Build();

        hubConnection.On<string, string>("ReceiveMessage", (user, message) =>
        {
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
