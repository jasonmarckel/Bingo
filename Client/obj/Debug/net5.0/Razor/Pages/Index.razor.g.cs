#pragma checksum "C:\Users\jason\Source\Bingo\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "435d479d0682958b04a0b850984b406b6e0d53b2"
// <auto-generated/>
#pragma warning disable 1591
namespace Bingo.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jason\Source\Bingo\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jason\Source\Bingo\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jason\Source\Bingo\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jason\Source\Bingo\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jason\Source\Bingo\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jason\Source\Bingo\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jason\Source\Bingo\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jason\Source\Bingo\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jason\Source\Bingo\Client\_Imports.razor"
using Bingo.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jason\Source\Bingo\Client\_Imports.razor"
using Bingo.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jason\Source\Bingo\Client\Pages\Index.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style type=""text/css"">
    #BingoCard
    {
        width: 100%;
    }
    #BingoCard td 
    {
        border: 3px solid black;
        width: 20%;
        text-align: center;
        font-weight: bold;
        padding-bottom: 5%;
        padding-top: 5%;
    }
    #BingoCard thead td
    {
        font-size: x-large;
        font-weight: 900;
    }
    .DefaultStamp
    {
        background-color: yellow;
    }
</style>

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "form-group");
            __builder.OpenElement(3, "label");
            __builder.AddMarkupContent(4, "\r\n        Name: \r\n        ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "class", "form-control");
            __builder.AddAttribute(8, "placeholder", "player name");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\jason\Source\Bingo\Client\Pages\Index.razor"
                                                       playerName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => playerName = __value, playerName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "form-group");
            __builder.OpenElement(14, "label");
            __builder.AddMarkupContent(15, "\r\n        Message:\r\n        ");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "size", "50");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "C:\Users\jason\Source\Bingo\Client\Pages\Index.razor"
                      messageInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => messageInput = __value, messageInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\jason\Source\Bingo\Client\Pages\Index.razor"
                  Send

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "disabled", 
#nullable restore
#line 43 "C:\Users\jason\Source\Bingo\Client\Pages\Index.razor"
                                    !IsConnected

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(24, "Send");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n<hr>\r\n\r\n");
            __builder.OpenElement(26, "ul");
            __builder.AddAttribute(27, "id", "messagesList");
#nullable restore
#line 48 "C:\Users\jason\Source\Bingo\Client\Pages\Index.razor"
     foreach (var message in messages)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(28, "li");
            __builder.AddContent(29, 
#nullable restore
#line 50 "C:\Users\jason\Source\Bingo\Client\Pages\Index.razor"
             message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 51 "C:\Users\jason\Source\Bingo\Client\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n<br>\r\n\r\n");
            __builder.OpenElement(31, "table");
            __builder.AddAttribute(32, "id", "BingoCard");
            __builder.AddMarkupContent(33, "<thead><tr><td>B</td>\r\n            <td>I</td>\r\n            <td>N</td>\r\n            <td>G</td>\r\n            <td>O</td></tr></thead>");
#nullable restore
#line 66 "C:\Users\jason\Source\Bingo\Client\Pages\Index.razor"
     for (int r = 0; r < 5; r++)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "tr");
#nullable restore
#line 69 "C:\Users\jason\Source\Bingo\Client\Pages\Index.razor"
         for (int c = 0; c < 5; c++)
        {
            var row = r;
            var col = c;            

#line default
#line hidden
#nullable disable
            __builder.OpenElement(35, "td");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\jason\Source\Bingo\Client\Pages\Index.razor"
                          eventargs => StampSquare(eventargs, row, col, card.StampClass)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "class", 
#nullable restore
#line 73 "C:\Users\jason\Source\Bingo\Client\Pages\Index.razor"
                                                                                                  card.Squares[r,c].StampClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(38, 
#nullable restore
#line 73 "C:\Users\jason\Source\Bingo\Client\Pages\Index.razor"
                                                                                                                                 card.Squares[r,c].Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 74 "C:\Users\jason\Source\Bingo\Client\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 76 "C:\Users\jason\Source\Bingo\Client\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "C:\Users\jason\Source\Bingo\Client\Pages\Index.razor"
       
    private Card card;
    private string playerName = "Jason";
    private HubConnection hubConnection;
    private List<string> messages = new List<string>();
    private string messageInput;

    public class Card
    {
        public string StampClass { get; set; }
        public Square[,] Squares { get; set; } = new Square[5,5];

        public Card()
        {
            StampClass = "DefaultStamp";    
            GenerateNewCard();
        }

        public void GenerateNewCard()
        {
            var rnd = new Random();
            var uniqueValues = new HashSet<int>();

            // generate a set of 5 unique integers for each column
            for (int c = 0; c < 5; c++)
            {
                // determine the low and high numbers for the column
                int minValue = 1 + (c * 15);
                int maxValue = 15 + (c * 15);
                // initialize the HashSet for the column to hold the uniqe values
                uniqueValues.Clear();
                // generate random numbers until we have 5 unique numbers for the column
                while (uniqueValues.Count < 5)
                {
                    // generate a random number
                    int x  = rnd.Next(minValue, maxValue);
                    // the number will only be added to the HashSet if it
                    // does not already exist in the HashSet
                    uniqueValues.Add(x);
                }
                // copy the unique values for the column to the card
                for (int r = 0; r < 5; r++)
                {
                    Squares[r,c] = new Square() { Value = uniqueValues.ElementAt(r).ToString() };
                    if (c == 2 && r == 2)
                    {
                        Squares[r,c].Value = "FREE";
                        Squares[r,c].StampClass = StampClass;
                    }
                }
            }
        }

        public class Square
        {
            public string Value { get; set; }
            public bool IsStamped { get { return !string.IsNullOrWhiteSpace(StampClass); } }
            public string StampClass { get; set; }
        }

    }

    protected override async Task OnInitializedAsync()
    {
        card = new Card();

        hubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/callerhub"))
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
        hubConnection.SendAsync("SendMessage", playerName, messageInput);

    public bool IsConnected =>
        hubConnection.State == HubConnectionState.Connected;
        
    public async ValueTask DisposeAsync()
    {
        await hubConnection.DisposeAsync();
    }

    private void StampSquare(MouseEventArgs e, int row, int col, string stampClass)
    {
        if (row == 2 && col == 2) { return; }
        var square = card.Squares[row, col];
        square.StampClass = square.IsStamped ? string.Empty : card.StampClass;
    }
    private void GenerateNewCard()
    {
        card.GenerateNewCard();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591