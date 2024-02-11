using BlazorAppCustomElementsNet8.Client.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.RegisterCustomElement<Counter>("my-counter");

await builder.Build().RunAsync();
