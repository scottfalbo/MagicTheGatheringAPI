// ------------------------------------
// Magic The Gathering Look Up UI
// ------------------------------------

using MagicTheGatheringAPI;
using MtgApiManager.Lib.Service;

var builder = WebApplication.CreateBuilder(args);

var serviceProvider = new MtgServiceProvider();
var service = serviceProvider.GetCardService();
builder.Services.AddSingleton(service);

builder.Services.AddTransient<IProcessor, Processor>();

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();