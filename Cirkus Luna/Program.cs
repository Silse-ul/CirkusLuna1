using Cirkus_Luna.Pages;
using Cirkus_Luna.Pages.Services;
using Cirkus_Luna.Pages.Shared;
using LunaLibrary.Repository;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<IPerformanceRepository, PerformanceRepository>();
builder.Services.AddSingleton<IArtistRepository, ArtistRepository>();
builder.Services.AddSingleton<ITicketRepository, TicketRepository>();
builder.Services.AddSingleton<PerformanceService>();
builder.Services.AddSingleton<ArtistService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) 
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
    .WithStaticAssets();

app.Run();