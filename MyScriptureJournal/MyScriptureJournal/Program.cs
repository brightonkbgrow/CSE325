using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;
using RazorPagesMovie.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<MyScriptureJournalContext>(options =>

    options.UseSqlServer(builder.Configuration.GetConnectionString("MyScriptureJournalContext") ?? throw new InvalidOperationException("Connection string 'MyScriptureJournalContext' not found.")));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapRazorPages();
app.Run();
